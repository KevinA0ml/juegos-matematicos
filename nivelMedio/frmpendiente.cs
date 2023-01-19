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
    public partial class frmpendiente : Form
    {
        public frmpendiente()
        {
            InitializeComponent();
        }
        // llamar a la clase donde encuentran los metodos
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
        
        // asignamos condiciones a los radiobotones llamando al private void
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int vmen = 1;
            int vmay = 10;
            y.Text = medio.valoresr1(vmen, vmay);
            b.Text = medio.valoresr2(vmen, vmay); 
            x.Text = medio.valoresr3(vmen, vmay);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int vmen = 10;
            int vmay = 100;
            y.Text = medio.valoresr1(vmen, vmay);
            b.Text = medio.valoresr2(vmen, vmay);
            x.Text = medio.valoresr3(vmen, vmay);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int vmen = 100;
            int vmay = 500;
            y.Text = medio.valoresr1(vmen, vmay);
            b.Text = medio.valoresr2(vmen, vmay);
            x.Text = medio.valoresr3(vmen, vmay);
        }
  
        // lo que hace el boton calcular
        private void calcular_Click(object sender, EventArgs e)
        {
            // validar de que no hayan espacios vacios
            if ((y.Text == "Y") || (b.Text == "B") || (x.Text == "X"))
            {
                MessageBox.Show("\n Error", " usted no a seleccionado ningun nivel");
                rusuario.Focus();
                return;
            }
            if (rusuario.Text == "")
            {
                MessageBox.Show("no a ingresado ningun dato ", "\n por favor ingrese su respuesta.");
                rusuario.Focus();
                return;
            }
            // validacion de datos
            // confirmacion de que los datos que ingresa el usuario son numericos
            double contro;
            bool ry = Double.TryParse(rusuario.Text, out contro);
            if (ry == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                rusuario.Text = "";
                rusuario.Focus();
                return;
            }
            Double y1, x1, b1, ru;



            // extraccion de datos random
            y1 = Convert.ToDouble(y.Text);
            x1 = Convert.ToDouble(x.Text);
            b1 = Convert.ToDouble(b.Text);
            ru = Convert.ToDouble(rusuario.Text);
            // mostramos la respuesta 
            // si es correcta
            if (medio.revisionpend(y1,b1,x1,ru))
            {
                contbuenas++;
                MessageBox.Show("Su respuesta es Correcta!\n ", "lleva un total de " + contbuenas + " respuestas correctas");
                puntos++;
                datos_jug dj = new datos_jug(nombre,apellidoz, puntos);
                point.Text = puntos.ToString();
                rc.Text = Convert.ToString(contbuenas);
                clear();
            }
            // si es incorrecta
            else
            {
                prueba++;
                MessageBox.Show("por favor vuelva a intentar");
            }
            if (prueba >= 3)
            {
                contmalas++;
                MessageBox.Show("la respuesta es incorrecta ," + "\n la respuesta correcta es :" + medio.rspendiente(y1,b1,x1) + "\n,lleva :" + contmalas + " respuestas equivocadas");
                ri.Text = Convert.ToString(contmalas);
                clear();
                prueba = 0;
            }
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
        // boton NUEVO
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
            rc.Text = "";
            ri.Text = "";
            contbuenas = 0;
            contmalas = 0;
        }
        // boton de salida
        private void button1_Click(object sender, EventArgs e)
        {
            datos_jug mijugador = new datos_jug(nombre, apellidoz, puntos);
            misjugadores.modjugador(mijugador, posAct);
            Close();

        }
                       // void para limpiar espacios 
        private void clear()
        {
            // eliminar la seleccion de los radiobuttons
            var radiolist = groupBox2.Controls.OfType<RadioButton>().ToList();
            foreach (var radio in radiolist)
            {
                radio.Checked = false;
            }
            y.Text = "Y";
            b.Text = "B";
            x.Text = "X";
            rusuario.Text = "";
            rusuario.Focus();
    
        }
                     // creamos variables para conteo de respuestas
        int contmalas = 0, contbuenas = 0, prueba = 0;
        // boton de AYUDA
        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ejecute la operacion segun se encuentra la formula:\n"+" realize la operacion dentro del parentesis primero\n"+" luego opere la division");
        }

        private void frmpendiente_Load(object sender, EventArgs e)
        {
            datosJugador();
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
