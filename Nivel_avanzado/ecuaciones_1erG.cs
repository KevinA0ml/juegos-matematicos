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
    public partial class ecuaciones_1erG : Form
    {
        public ecuaciones_1erG()
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
        private void ecuaciones_1erG_Load(object sender, EventArgs e)
        {
            disable();
            datosJugador();
        }
        // RADIO BOTONES
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int a = 1;
            int b = 10;
            // generar valores
            x1.Text = Convert.ToString(randomx(a, b));
            x2.Text = Convert.ToString(randomx(a, b) + 2);
            y1.Text = Convert.ToString(randomy(a, b));
            y2.Text = Convert.ToString(randomy(a, b) + 2);
            r1.Text = Convert.ToString(randomc(a, b));
            r2.Text = Convert.ToString(randomc(a, b) + 2);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int a = 10;
            int b = 100;
            // generar valores
            x1.Text = Convert.ToString(randomx(a, b));
            x2.Text = Convert.ToString(randomx(a, b) + 2);
            y1.Text = Convert.ToString(randomy(a, b));
            y2.Text = Convert.ToString(randomy(a, b) + 2);
            r1.Text = Convert.ToString(randomc(a, b));
            r2.Text = Convert.ToString(randomc(a, b) + 2);
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int a = 100;
            int b = 1000;
            // generar valores
            x1.Text = Convert.ToString(randomx(a, b));
            x2.Text = Convert.ToString(randomx(a, b) + 2);
            y1.Text = Convert.ToString(randomy(a, b));
            y2.Text = Convert.ToString(randomy(a, b) + 2);
            r1.Text = Convert.ToString(randomc(a, b));
            r2.Text = Convert.ToString(randomc(a, b) + 2);
        }
        // boton de salida //
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            datos_jug mijugador = new datos_jug(nombre, apellidoz, puntos);
            misjugadores.modjugador(mijugador, posAct);
        }
        // boton de NUEVO //
        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
            rc.Text = "";
            ri.Text = "";
            contmalas = 0;
            contbuenas = 0;

        }
        // llamamos a la clase
        Metod_avan avanzado = new Metod_avan();
        //  boton de CALCULAR //
        // variables para conteo de respuestas
        int contbuenas = 0, contmalas = 0, prueba = 0;
        private void calcular_Click(object sender, EventArgs e)
        {

            // VALIDACIONES

            // validar de que no hayan espacios vacios
            if ((respy.Text == "") || (respx.Text == ""))
            {
                MessageBox.Show("\n Error", " usted no a ingresado su respuesta");
                respx.Focus();
                return;
            }
            double contro;
            bool usrx = Double.TryParse(respx.Text, out contro);
            if (usrx == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                respx.Text = "";
                respx.Focus();
                return;

            }
            double control;
            bool usry = Double.TryParse(respy.Text, out control);
            if (usry == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                respy.Text = "";
                respy.Focus();
                return;
            }
            //  VARIABLES
            int x11, x22, y11, y22, r11, r22;
            double de, rx, ry;
            // asignamos valores 
            x11 = Convert.ToInt32(x1.Text);
            x22 = Convert.ToInt32(x2.Text);
            y11 = Convert.ToInt32(y1.Text);
            y22 = Convert.ToInt32(y2.Text);
            r11 = Convert.ToInt32(r1.Text);
            r22 = Convert.ToInt32(r2.Text);
            // leemos respuesta de usuario 
            rx = Convert.ToDouble(respx.Text);
            ry = Convert.ToDouble(respy.Text);
            // PROCESO DE OBTENCION DE RESPUESTAS 
            // calculo de la determinante
            de = avanzado.ecuacion(x11, x22, y11, y22);
            //calculo de los valores de x y
            double rsx = 0, rsy = 0;
            rsx = Math.Round((avanzado.ecuacion(r11, r22, y11, y22) / de), 2);

            rsy = Math.Round((avanzado.ecuacion(x11, x22, r11, r22) / de), 2);
            // cuenta de las respuestas
            if (de == rx)
            {
                contbuenas++;
                MessageBox.Show("Su respuesta es Correcta!\n ", "lleva un total de " + contbuenas + " respuestas correctas");
                rc.Text = Convert.ToString(contbuenas);
                puntos++;
                datos_jug dj = new datos_jug(nombre, apellidoz, puntos);
                point.Text = puntos.ToString();
                limpiar();
            }
            // si es incorrecta
            else if (avanzado.revisionecua1(rx,ry,rsx,rsy))
            {
                MessageBox.Show("Su respuesta es Correcta!\n ", "lleva un total de " + contbuenas + " respuestas correctas");
                rc.Text = Convert.ToString(contbuenas);
                puntos = contbuenas;
                datos_jug dj = new datos_jug(nombre, apellidoz, puntos);
                point.Text = puntos.ToString();
                limpiar();
            }
            else
            {
                prueba++;
                MessageBox.Show("por favor vuelva a intentar");
            }
            if( prueba >=3)
            {
                contmalas++;
                MessageBox.Show("la respuesta es incorrecta ," + "\n las respuestas correctas son :" + rsx+" - "+rsy+ "\n,lleva :" + contmalas + " respuestas equivocadas");
                ri.Text = Convert.ToString(contmalas);
                limpiar();
                prueba = 0;
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
        //
        //
        // voids para desarrollo de procesos 
        
        // void para limpiar
        private void limpiar()
        {
            x1.Text = "";
            x2.Text = "";
            y1.Text = "";
            y2.Text = "";
            r1.Text = "";
            r2.Text = "";
            respx.Text = "";
            respy.Text = "";
            var radiolist = groupBox2.Controls.OfType<RadioButton>().ToList();
            foreach (var radio in radiolist)
            {
                radio.Checked = false;
            }
        }
        // deshabilitar espacios
        public void disable()
        {
            x1.Enabled = false;
            x2.Enabled = false;
            y1.Enabled = false;
            y2.Enabled = false;
            r1.Enabled = false;
            r2.Enabled = false;
        }

        // metodos para generar valores random
        private int randomx(int a, int b)
        {
            Random r = new Random();
            return r.Next(a, b);
        }
        private int randomy(int a, int b)
        {
            Random r = new Random(DateTime.Now.Second);
            return r.Next(a, b);
        }
        private int randomc(int a, int b)
        {
            Random r = new Random(DateTime.Now.Second);
            return r.Next(a, b);
        }
        // BOTON DE AYUDA
        help.h_ecua1 ecuacion1 = new help.h_ecua1();
        private void help_Click(object sender, EventArgs e)
        {
            ecuacion1.ShowDialog();
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
