using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juego_educativo.nivelMedio
{
    public partial class frmpend2 : Form
    {
        public frmpend2()
        {
            InitializeComponent();
        }

        // llamamos a la clase donde estan los metodos
        Metod_med medio = new Metod_med();
        // variable privada para llevar datos a clase de jugaddores
        private Opejugadores misjugadores;
        public void setdatos(Opejugadores misjugadores)
        {
            this.misjugadores = misjugadores;
        }
        // instanciaa clase de datos jugadores
        datos_jug dj = new datos_jug();

        // variable para la posicion actual del jugador 
        int posAct;

        //deshabilitar las casillas donde se muestran las cantidades 
        // variables para datos de jugadores
        string nombre;
        string apellidoz;
        int puntos;
        // radio botones
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int vmen = 1;
            int vmay = 10;
            y1.Text = medio.valoresr1(vmen, vmay) + 1;
            y2.Text = medio.valoresr2(vmen, vmay);
            x1.Text = medio.valoresr3(vmen, vmay) + 2;
            x2.Text = medio.valoresr4(vmen, vmay);
            div0();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int vmen = 10;
            int vmay = 100;
            y1.Text = medio.valoresr1(vmen, vmay) + 1;
            y2.Text = medio.valoresr2(vmen, vmay);
            x1.Text = medio.valoresr3(vmen, vmay) + 2;
            x2.Text = medio.valoresr4(vmen, vmay);
            div0();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int vmen = 100;
            int vmay = 1000;
            y1.Text = medio.valoresr1(vmen, vmay) + 1;
            y2.Text = medio.valoresr2(vmen, vmay);
            x1.Text = medio.valoresr3(vmen, vmay) + 2;
            x2.Text = medio.valoresr4(vmen, vmay);
            div0();
        }
        //contador de respuestas 
        int contmalas = 0, contbuenas = 0, prueba = 0;

        private void calcular_Click(object sender, EventArgs e)
        {
            //cuidando que se seleccione un radiobutton
            if ((y1.Text == "0") || (y2.Text == "0") || (x1.Text == "0") || (x2.Text == "0"))
            {
                MessageBox.Show("\n Error", " usted no a seleccionado ningun nivel");
                resp.Focus();
                return;
            }
            // cuidando espacios vacios
            if (resp.Text == "")
            {
                MessageBox.Show("no a ingresado ningun dato ", "\n por favor ingrese su respuesta.");
                resp.Focus();
                return;
            }

            // validacion de datos
            // confirmacion de que los datos que ingresa el usuario son numericos
            double control;
            bool ry = Double.TryParse(resp.Text, out control);
            if (ry == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                resp.Text = "";
                resp.Focus();
                return;
            }
            Double t1, t2, c1, c2, ru;
            // obtenemos variables
            t1 = Convert.ToDouble(y1.Text);
            t2 = Convert.ToDouble(y2.Text);
            c1 = Convert.ToDouble(x1.Text);
            c2 = Convert.ToDouble(x2.Text);
            ru = Convert.ToDouble(resp.Text);
            // comparamos si la respuesta es correcta
            if (medio.revisionpend2(t1,t2,c1,c2,ru))
            {
                contbuenas++;
                MessageBox.Show("Su respuesta es Correcta!\n ", "lleva un total de " + contbuenas + " respuestas correctas");
                puntos++;
                datos_jug dj = new datos_jug(nombre, apellidoz, puntos);
                point.Text = puntos.ToString();
                rc.Text = Convert.ToString(contbuenas);
                limpiar();
            }
            // si la respuesta es erronea
            else
            {
                prueba++;
                MessageBox.Show("por favor vuelva a intentar");
            }
            if(prueba>=3)
            {
                contmalas++;
                MessageBox.Show("la respuesta es incorrecta ," + "\n la respuesta correcta es :" + medio.rspendiente2(t1,t2,c1,c2)+ "\n,lleva :" + contmalas + " respuestas equivocadas");
                ri.Text = Convert.ToString(contmalas);
                limpiar();
                prueba = 0;
            }
            // limite de tres malas
            if (contmalas >= 3)
            {
                MessageBox.Show("a tenido 4 respuestas erroneas, ¡perdio!");
                this.Close();
                datos_jug mijugador = new datos_jug(nombre, apellidoz, puntos);
                misjugadores.modjugador(mijugador, posAct);
                punteo punteo = new punteo();
                punteo.Show();
            }
                

        }
        // BOTON DE NUEVO
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nueva partida! elija el nivel con el cual comenzar");
            limpiar();
            rc.Text = "";
            ri.Text = "";
            contbuenas = 0;
            contmalas = 0;
         
        }
        // BOTON DE SALIDA
        private void button1_Click(object sender, EventArgs e)
        {
            datos_jug mijugador = new datos_jug(nombre, apellidoz, puntos);
            misjugadores.modjugador(mijugador, posAct);
            this.Close();

        }
      
        // void para calculo de la operacion 
        // y calificacion de la respuesta obtenida
        private void div0()
        {

            //evitamos la division entre 0
            if (x1.Text == x2.Text)
            {
                int x3 = Convert.ToInt32(x2.Text) + 1;
                x2.Text = Convert.ToString(x3);

                // obtenemos la respuesta del jugador
            }
                
        }
        help.h_pendiente2 pend2 = new help.h_pendiente2();

        /// BOTON DE AYUDA
        private void help_Click(object sender, EventArgs e)
        {
            pend2.ShowDialog();
        }

        private void frmpend2_Load(object sender, EventArgs e)
        {
            datosJugador();
        }

        // VOID PARA LIMPIAR
        private void limpiar()
        {
            // dejar sin checkear los radiobuttons
            var radiolist = groupBox2.Controls.OfType<RadioButton>().ToList();
            foreach (var radio in radiolist)
            {
                radio.Checked = false;
            }
            y1.Text = "0";
            y2.Text = "0";
            x1.Text = "0";
            x2.Text = "0";
            resp.Text = "";
            resp.Focus();
          
        }
        // void para los datos del jugador
        private void datosJugador()
        {
            datos_jug dj = new datos_jug();
            nombre = misjugadores.Get_Jugs()[dj.Pos].Nombre;
            apellidoz = misjugadores.Get_Jugs()[dj.Pos].Apellidos;
            puntos = misjugadores.Get_Jugs()[dj.Pos].Puntos;
            player.Text = nombre;
            apel.Text = apellidoz;
            point.Text = puntos.ToString();
            // le asignamos la variable a la posicion actual
            posAct = dj.Pos;
        }
    }
}
