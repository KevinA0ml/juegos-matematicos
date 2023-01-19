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
    public partial class Geometria : Form
    {
        public Geometria()
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
        private void Geometria_Load(object sender, EventArgs e)
        {
            radio.Enabled = false;
            datosJugador();
        }
        Metod_med medio = new Metod_med();
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int vmen = 1;
            int vmay = 10;
            radio.Text = medio.valoresr1(vmen, vmay);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int vmen = 10;
            int vmay = 100;
            radio.Text = medio.valoresr1(vmen, vmay);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int vmen = 100;
            int vmay = 1000;
            radio.Text = medio.valoresr1(vmen, vmay);
        }
        int contmalas = 0, contbuenas = 0, prueba = 0;



        private void calcular_Click(object sender, EventArgs e)
        {
            if ((radio.Text == ""))
            {
                MessageBox.Show("\n Error", " usted no a seleccionado ningun nivel");
                area.Focus();
                return;
            }
            if ((area.Text == "") || (perimetro.Text == ""))
            {
                MessageBox.Show("no a ingresado ningun dato ", "\n por favor ingrese su respuesta.");
                area.Focus();
                return;
            }
            double a, p;
            bool ry = Double.TryParse(area.Text, out a);
            if (ry == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                area.Text = "";
                area.Focus();
                return;

            }
            bool ra = Double.TryParse(perimetro.Text, out p);
            if (ra == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                perimetro.Text = "";
                return;
            }

            calculo();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
            MessageBox.Show(" Nueva partida, Seleccione su nivel para comenzar.");
            ri.Text = "";
            rc.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            datos_jug mijugador = new datos_jug(nombre, apellidoz, puntos);
            misjugadores.modjugador(mijugador, posAct);
            Close();
        }

        //void para caluclo
        private void calculo()
        {
          
            double rad = Convert.ToDouble(radio.Text);
            double rarea = Convert.ToDouble(area.Text);
            double rperimetro = Convert.ToDouble(perimetro.Text);


            if ((medio.revisioncirca(rad,rarea)) || (medio.revisioncircp(rad, rperimetro)))
            {
                contbuenas++;
                MessageBox.Show("Su respuesta es Correcta!\n ", "lleva un total de " + contbuenas + " respuestas correctas");
                rc.Text = Convert.ToString(contbuenas);
                puntos++;
                datos_jug dj = new datos_jug(nombre, apellidoz, puntos);
                point.Text = puntos.ToString();
                clear();
                area.Focus();

            }
            // si es incorrecta
            else
            {
                prueba++;
                MessageBox.Show("por favor vuelva a intentar");
            }
            if (prueba >=3)
            {
                contmalas++;
                MessageBox.Show("la respuesta es incorrecta ," + "\n el area es de :" + medio.area(rad) + "\n el perimetro es de :" + medio.perimetro(rad) + "\n,lleva :" + contmalas + " respuestas equivocadas");
                ri.Text = Convert.ToString(contmalas);
                clear();
                area.Focus();
                prueba = 0;
            }
            if (contmalas >= 4)
            {
                datos_jug mijugador = new datos_jug(nombre, apellidoz, puntos);
                misjugadores.modjugador(mijugador, posAct);
                MessageBox.Show("a tenido 4 respuestas erroneas, ¡perdio!");
                this.Close();
                punteo punteo = new punteo();
                punteo.Show();
            }
        }
        help.h_circulo circ = new help.h_circulo();

        // void de AYUDA
        private void help_Click(object sender, EventArgs e)
        {
            circ.ShowDialog();
        }

        //void para limpiar casillas reutilizables
        private void clear()
        {
            radio.Text = "";
            area.Text = "";
            perimetro.Text = "";
            area.Focus();

            var radiolist = groupBox2.Controls.OfType<RadioButton>().ToList();
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
