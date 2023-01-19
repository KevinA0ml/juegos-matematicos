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
    public partial class ecuaciones_racionales : Form
    {
        public ecuaciones_racionales()
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
        int vmen, vmay;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            vmen = 1;
            vmay = 10;
            valoresr(vmen, vmay);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            vmen = 1;
            vmay = 100;
            valoresr(vmen, vmay);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            vmen = -10;
            vmay = 1000;
            valoresr(vmen, vmay);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            datos_jug mijugador = new datos_jug(nombre,apellidoz, puntos);
            misjugadores.modjugador(mijugador, posAct);
        }
        int contbuenas = 0, contmalas = 0, prueba = 0;
        // llamamos la clase
        Metod_avan avanzado = new Metod_avan();
        // boton de CALCULO
        private void calcular_Click(object sender, EventArgs e)
        {
            if (respy.Text == "")
            {
                MessageBox.Show("no a ingresado ningun dato ", "\n por favor ingrese su respuesta.");
                respy.Focus();
                return;
            }
            // validacion de datos
            // confirmacion de que los datos que ingresa el usuario son numericos
            double contro;
            bool ry = Double.TryParse(respy.Text, out contro);
            if (ry == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                respy.Text = "";
                respy.Focus();
                return;
            }
            int a, b, c;
            a = Convert.ToInt32(x1.Text);
            b = Convert.ToInt32(x2.Text);
            c = Convert.ToInt32(x3.Text);
            double totm;
            totm = avanzado.calculoderiv(a, b, c);
            revresp(totm);
        }


        // metodos para el calculo, radiobotones, limpiar

        // revision de respuesta 
        private void revresp(double totm)
        {
            //obtengo la respuesta del usuario
            double ru = Convert.ToDouble(respy.Text);
            //calificar respuesta correcto/incorrecto
            if (avanzado.revisionderiv(totm, ru))
            {
                contbuenas++;
                MessageBox.Show("su respuesta es Correcta", "\n lleva un punteo de:  " + contbuenas);
                rc.Text = Convert.ToString(contbuenas);
                puntos++;
                datos_jug dj = new datos_jug(nombre,apellidoz, puntos);
                point.Text = puntos.ToString();
                limpiar();
                groupBox2.Focus();
            }
            else
            {
                prueba++;
                MessageBox.Show("por favor vuelva a intentar");
            }
            if (prueba > 3)
            {
                contmalas++;
                MessageBox.Show("la respuesta es incorrecta ," + "\n la respuesta correcta es :" + totm + "\n,lleva :" + contmalas + " respuestas equivocadas");
                ri.Text = Convert.ToString(contmalas);
                limpiar();
                groupBox2.Focus();
                prueba = 0;
            }
            // limitar el juego a solamente 3 respuestas malas
            if (contmalas >= 3)
            {
                MessageBox.Show("a tenido 3 respuestas erroneas, ¡perdio!");
                this.Close();
                datos_jug mijugador = new datos_jug(nombre, apellidoz, puntos) ;
                misjugadores.modjugador(mijugador, posAct);
                punteo punteo = new punteo() ;
                punteo.Show();
            }
        } 
        // BOTON DE AYUDA
        help.h_derivada derivada = new help.h_derivada();
        private void help_Click(object sender, EventArgs e)
        {
            derivada.ShowDialog();
        }

        private void ecuaciones_racionales_Load(object sender, EventArgs e)
        {
            datosJugador();
        }

        //metodo de limpieza
        private void limpiar()
        {
            var radiolist = groupBox2.Controls.OfType<RadioButton>().ToList();
            foreach (var radio in radiolist)
            {
                radio.Checked = false;
            }
            x1.Text = "";
            x2.Text = "";
            x3.Text = "";
            respy.Text = "";
        }
        //metodo para valores random *radiobotones*
        private void valoresr(int vmen, int vmay)
        {
            Random rb = new Random();
            x1.Text = Convert.ToString(rb.Next(vmen, vmay)-1);
            x2.Text = Convert.ToString(rb.Next(vmen, vmay));
            x3.Text = Convert.ToString(rb.Next(vmen, vmay)+2);
            
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
