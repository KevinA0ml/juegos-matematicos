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
    public partial class frmresta : Form
    {
        public frmresta()
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
        private void frmresta_Load(object sender, EventArgs e)
        {
            d1.Enabled = false;
            d2.Enabled = false;
            datosJugador();
        }
        Metod_prim metodos = new Metod_prim();
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
        int contbuenas = 0, contmalas = 0, prueba =0;

        private void button1_Click(object sender, EventArgs e)
        {
            if ((d1.Text == "") || (d2.Text == "") || (mtbresp.Text == ""))
            {
                MessageBox.Show("\n Error", " usted no a seleccionado ningun nivel o no a ingresado su respuesta");
                mtbresp.Focus();
                return;
            }
            double contro;
            bool ry = Double.TryParse(mtbresp.Text, out contro);
            if (ry == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                mtbresp.Text = "";
                mtbresp.Focus();
                return;
            }
            // creacion de variables
            int  v1, v2, ru;
            v1 = Convert.ToInt32(d1.Text);
            v2 = Convert.ToInt32(d2.Text);
            //obtengo la respuesta del usuario
            ru = Convert.ToInt32(mtbresp.Text);
            //respuesta correcta al problema
           
            if (metodos.revisionRes(v1, v2, ru))
            {
                contbuenas++;
                MessageBox.Show("su respuesta es Correcta", "\n lleva un punteo de:  " + contbuenas);
                rc.Text = Convert.ToString(contbuenas);
                puntos++;
                datos_jug dj = new datos_jug(nombre,apellidoz, puntos);
                point.Text = puntos.ToString();
                d1.Text = "";
                limpiar();
            }
            else
            {
                prueba++;
                MessageBox.Show("por favor vuelva a intentar");
            }
            if (prueba >= 3)
            {
                contmalas++;
                MessageBox.Show("la respuesta es incorrecta ," + "\n la respuesta correcta es :" + metodos.rsres(v1,v2) + "\n,lleva :" + contmalas + " respuestas equivocadas");
                ri.Text = Convert.ToString(contmalas);
                prueba = 0;
                limpiar();
            }
            // limitar el juego a solamente 3 respuestas malas
            if (contmalas >= 3)
            {
                MessageBox.Show("a tenido 3 respuestas erroneas, ¡perdio!");
                this.Close();
                datos_jug mijugador = new datos_jug(nombre,apellidoz, puntos);
                misjugadores.modjugador(mijugador, posAct);
                punteo punteo = new punteo();
                punteo.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
            MessageBox.Show("Nueva partida! seleccione el nivel para jugar!");
            rc.Text = "";
            ri.Text = "";
            contbuenas = 0;
            contmalas = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            datos_jug mijugador = new datos_jug(nombre,apellidoz, puntos);
            misjugadores.modjugador(mijugador, posAct);
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            help.h_resta ayuda = new help.h_resta();
            ayuda.ShowDialog();
        }

        private void limpiar()
        {
            d1.Text = "";
            d2.Text = "";
            mtbresp.Text = "";
            mtbresp.Focus();
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

