using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juego_educativo.Nivel_avanzado
{
    public partial class Formula_Gen : Form
    {
        public Formula_Gen()
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

        // VALORES DE LOS RADIOBOTONES
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int vmen = 1;
            int vmay = 10;
            valoresr(vmen, vmay);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int vmen = 10;
            int vmay = 100;
            valoresr(vmen, vmay);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int vmen = 100;
            int vmay = 1000;
            valoresr(vmen, vmay);
        }
        // SALIR //
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            datos_jug mijugador = new datos_jug(nombre, apellidoz, puntos) ;
            misjugadores.modjugador(mijugador, posAct);
        }
        // boton LIMPIAR
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
            ri.Text = "";
            rc.Text = "";
            contmalas = 0;
            contbuenas = 0;
        }
        int contbuenas = 0, contmalas = 0, prueba = 0;
        // llamamos la clase donde estan los metodos
        Metod_avan avanzado = new Metod_avan();
        // boton de CALCULO
        private void calcular_Click(object sender, EventArgs e)
        {
            if ((a.Text == "") || (b.Text == "") || (c.Text == ""))
            {
                MessageBox.Show("\n Error", " usted no a seleccionado ningun nivel");
                x11.Focus();
                return;
            }
            if (x11.Text == "")
            {
                MessageBox.Show("no a ingresado ningun dato ", "\n por favor ingrese su respuesta.");
                x11.Focus();
                return;
            }
            // validacion de datos
            // confirmacion de que los datos que ingresa el usuario son numericos
            double contro;
            bool ry = Double.TryParse(x11.Text, out contro);
            if (ry == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                x11.Text = "";
                x11.Focus();
                return;
            }
            double control;
            bool rx = Double.TryParse(x22.Text, out control);
            if (rx == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                x22.Text = "";
                x22.Focus();
                return;
            }
            // variables 
            double a1, b1, c1, resp;
            double totalneg, totalpos;
            //asignamos
            a1 = Convert.ToDouble(a.Text);
            b1 = Convert.ToDouble(b.Text);
            c1 = Convert.ToDouble(c.Text);
            resp = Convert.ToDouble(r.Text);
            // recibimos 
            double resp1 = Convert.ToDouble(x11.Text);
            double resp2 = Convert.ToDouble(x22.Text);
            // proceso del calculo de la ecuacion

            double totr = avanzado.ecuacion(a1, b1, c1, resp);
            totalneg = avanzado.ecuaneg(totr, b1, c1, a1);
            totalpos = avanzado.ecuamas(totr, b1, c1, a1);
            if ( totr > 0)
            {

                // conteo del punteo 
                // si es incorrecta
                if (avanzado.revisiongen(resp1,totalpos,resp2,totalneg))
                {
                    contbuenas++;
                    MessageBox.Show("Su respuesta es Correcta!\n ", "lleva un total de " + contbuenas + " respuestas correctas");
                    rc.Text = Convert.ToString(contbuenas);
                    puntos ++;
                    datos_jug dj = new datos_jug(nombre, apellidoz, puntos) ;
                    point.Text = puntos.ToString();
                    clear();
                }
                else
                {
                    prueba++;
                    MessageBox.Show("por favor vuelva a intentar");
                }
                if(prueba >3)
                {
                    contmalas++;
                    MessageBox.Show("la respuesta es incorrecta ," + "\n las respuestas correctas son :" + totalpos + " " + totalneg + " " + "\n,lleva :" + contmalas + " respuestas equivocadas");
                    ri.Text = Convert.ToString(contmalas);
                    clear();
                    prueba = 0;
                }
            }else if (totr == 0)
            {
               double totalpositive = -(b1) / 2 * a1;
                if (resp1 == totalpositive)
                {
                    MessageBox.Show("Su respuesta es Correcta!\n ", "lleva un total de " + contbuenas + " respuestas correctas");
                    rc.Text = Convert.ToString(contbuenas);
                    puntos = contbuenas;
                    datos_jug dj = new datos_jug(nombre, apellidoz, puntos);
                    point.Text = puntos.ToString();
                    clear();
                }
            }
            if (contmalas >= 3)
            {
                MessageBox.Show("a tenido 3 respuestas erroneas, ¡perdio!");
                this.Close();
                datos_jug mijugador = new datos_jug(nombre, apellidoz, puntos);
                misjugadores.modjugador(mijugador, posAct);
                punteo punteo = new punteo();
                punteo.Show();

            }
           
        }
        // metodos //
        
        private void clear()
        {
            // eliminar la seleccion de los radiobuttons
            var radiolist = groupBox1.Controls.OfType<RadioButton>().ToList();
            foreach (var radio in radiolist)
            {
                radio.Checked = false;
            }
            a.Text = "";
            b.Text = "";
            c.Text = "";
            r.Text = "";
            x11.Text = "";
            x22.Text = "";
            x11.Focus();

        }
        // BOTON DE AYUDA
        help.h_fgeneral gen = new help.h_fgeneral();
        private void help_Click(object sender, EventArgs e)
        {
            gen.ShowDialog();
        }

        private void Formula_Gen_Load(object sender, EventArgs e)
        {
            datosJugador();
        }

        //GENERACION DE VALORES RANDOM
        private void valoresr(int vmen, int vmay)
        {
            Random rb = new Random();
            a.Text = Convert.ToString(rb.Next(vmen, vmay));
            b.Text = Convert.ToString(rb.Next(vmen, vmay));
            c.Text = Convert.ToString(rb.Next(vmen, vmay));
            r.Text = Convert.ToString(rb.Next(vmen, vmay));
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