using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juego_educativo.nivel_primario
{
    public partial class frmsuma : Form
    {
        public frmsuma()
        {
            InitializeComponent();
        }
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
        // habilitacion de espacios
        private void frmsuma_Load(object sender, EventArgs e)
        {
            d1.Enabled = false;
            d2.Enabled = false;
            datosJugador();

        }
        // creacion de instancia para comunicarse con la clase
        Metod_prim metodos = new Metod_prim();
        // condiciones de seleccionar un radio button
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int vmen = 1;
            int vmay = 10;
           d1.Text = metodos.valoresr(vmen, vmay);
           d2.Text = metodos.valoresra(vmen, vmay);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int vmen = 10;
            int vmay = 100;
            d1.Text = metodos.valoresr(vmen, vmay);
            d2.Text = metodos.valoresra(vmen, vmay);
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int vmen = 100;
            int vmay = 1000;
            d1.Text = metodos.valoresr(vmen, vmay);
            d2.Text = metodos.valoresra(vmen, vmay);
        }

        // calcular si la respuesta es correcta, y llevar el conteo

        int contbuenas = 0, contmalas = 0, prueba = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            if ((d1.Text == "") || (d2.Text == "") || (txtresp.Text == "")) {
                MessageBox.Show("\n Error", " usted no a seleccionado ningun nivel o no a ingresado su respuesta");
                txtresp.Focus();
                return;
            }
            double contro;
            bool ry = Double.TryParse(txtresp.Text, out contro);
            if (ry == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                txtresp.Text = "";
                txtresp.Focus();
                return;
            }
            // variables 
            int a, b;
            // obtenemos valores
            a = Convert.ToInt32(d1.Text);
            b = Convert.ToInt32(d2.Text);
            //obtengo la respuesta del usuario
            int ru = Convert.ToInt32(txtresp.Text);


            /// conteo de buenas y malas 
            if (metodos.revisionSum(a, b, ru))
            {
                contbuenas++;
                MessageBox.Show("su respuesta es Correcta", "\n lleva un punteo de:  " + contbuenas);
                rc.Text = Convert.ToString(contbuenas);
                puntos++;
                datos_jug dj = new datos_jug(nombre,apellidoz, puntos);
                point.Text = puntos.ToString();
                clear();
                txtresp.Focus();

            }
            else
            {
                prueba++;
                MessageBox.Show("por favor vuelva a intentar");

            } 
            //despues de 3 intntos se marca la respuesta mal
             if (prueba >=3)
            {
                contmalas++;
                MessageBox.Show("la respuesta es incorrecta ," + "\n la respuesta correcta es :" + metodos.rssum(a, b) +"\n,lleva :" + contmalas + " respuestas equivocadas") ;
                ri.Text = Convert.ToString(contmalas);
                clear();
                txtresp.Focus();
                prueba = 0;
                
            }

            // limitar el juego a solamente 4 respuestas malas
            if (contmalas >= 3)
            {
                MessageBox.Show("a tenido 3 respuestas erroneas, ¡perdio!");
                this.Close();
                datos_jug mijugador = new datos_jug(nombre,apellidoz, puntos );
                misjugadores.modjugador(mijugador, posAct);
                punteo punteo = new punteo();
                punteo.Show();
            }

        }

        // empezar nueva partida en el juego 
        // elimina el punteo recorrido
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nueva partida! seleccione el nivel para jugar!");
            rc.Text = "";
            ri.Text = "";
            contbuenas = 0;
            contmalas = 0;
            clear();
        }
     // boton de salida
        private void button3_Click(object sender, EventArgs e)
        {
            datos_jug mijugador = new datos_jug(nombre,apellidoz, puntos);
            misjugadores.modjugador(mijugador, posAct);
            this.Close(); 
        }
        // boton de ayuda
        private void button4_Click(object sender, EventArgs e)
        {
            help.h_suma suma = new help.h_suma();
            suma.ShowDialog();
        }

        //void para limpiar los datos
        private void clear()
        {
            d1.Text = "";
            d2.Text = "";
            txtresp.Text = "";
            txtresp.Focus();
            var radiolist = groupBox1.Controls.OfType<RadioButton>().ToList();
            foreach (var radio in radiolist)
            {
                radio.Checked = false;
            }
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
