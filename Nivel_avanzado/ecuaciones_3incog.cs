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
    public partial class ecuaciones_3incog : Form
    {
        public ecuaciones_3incog()
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
        private void ecuaciones_3incog_Load(object sender, EventArgs e)
        {
            disable();
            datosJugador();
            
        }
        // RADIO BOTONES
        // nivel basico 
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int a = 1;
            int b = 10;
            // generar valores
            a1.Text = Convert.ToString(randoma(a, b));
            a2.Text = Convert.ToString(randoma(a, b) - 2);
            a3.Text = Convert.ToString(randoma(a, b) + 1);
            b1.Text = Convert.ToString(randomb(a, b));
            b2.Text = Convert.ToString(randomb(a, b) - 2);
            b3.Text = Convert.ToString(randoma(a, b) + 1);
            c1.Text = Convert.ToString(randomc(a, b));
            c2.Text = Convert.ToString(randomc(a, b) - 2);
            c3.Text = Convert.ToString(randomc(a, b) + 1);
            r1.Text = Convert.ToString(randomr(a, b));
            r2.Text = Convert.ToString(randomr(a, b) - 2);
            r3.Text = Convert.ToString(randomr(a, b) + 1);
        }
        //nivel medio
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int a = 10;
            int b = 100;
            // generar valores
            a1.Text = Convert.ToString(randoma(a, b));
            a2.Text = Convert.ToString(randoma(a, b) - 2);
            a3.Text = Convert.ToString(randoma(a, b) + 1);
            b1.Text = Convert.ToString(randomb(a, b));
            b2.Text = Convert.ToString(randomb(a, b) - 2);
            b3.Text = Convert.ToString(randoma(a, b) + 1);
            c1.Text = Convert.ToString(randomc(a, b));
            c2.Text = Convert.ToString(randomc(a, b)-2);
            c3.Text = Convert.ToString(randomc(a, b)+1);
            r1.Text = Convert.ToString(randomr(a, b));
            r2.Text = Convert.ToString(randomr(a, b) - 2);
            r3.Text = Convert.ToString(randomr(a, b)+1);
        }
        //nivel avanzado
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int a = 100;
            int b = 1000;
            // generar valores
            a1.Text = Convert.ToString(randoma(a, b));
            a2.Text = Convert.ToString(randoma(a, b) - 2);
            a3.Text = Convert.ToString(randoma(a, b) + 1);
            b1.Text = Convert.ToString(randomb(a, b));
            b2.Text = Convert.ToString(randomb(a, b) - 2);
            b3.Text = Convert.ToString(randoma(a, b) + 1);
            c1.Text = Convert.ToString(randomc(a, b));
            c2.Text = Convert.ToString(randomc(a, b) - 2);
            c3.Text = Convert.ToString(randomc(a, b) + 1);
            r1.Text = Convert.ToString(randomr(a, b));
            r2.Text = Convert.ToString(randomr(a, b) - 2);
            r3.Text = Convert.ToString(randomr(a, b) + 1);
        }
        //boton de salida
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            datos_jug mijugador = new datos_jug(nombre, apellidoz, puntos);
            misjugadores.modjugador(mijugador, posAct);
        }
        //boton de nuevo
        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
            rc.Text = "";
            ri.Text = "";
            contmalas = 0;
            contbuenas = 0;
        }
        // variables para conteo del punteo
        int contmalas = 0, contbuenas = 0, prueba = 0;
        // llamamos a la clase
        Metod_avan avanzado = new Metod_avan();

        //      BOTON DE CALCULAR //
        private void calcular_Click(object sender, EventArgs e)
        {
          
            //  VALIDACIONES /  
                //espacio vacio
            if (((respa.Text == "") || (respb.Text == "")||(respc.Text == "")))
            {
                MessageBox.Show("\n Error", " usted no a ingresado su respuesta");
                respa.Focus();
                return;
            }
                //validacion de datos numericos
            double contro;
            bool usrx = Double.TryParse(respa.Text, out contro);
            if (usrx == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                respa.Text = "";
                respa.Focus();
                return;

            }
            double control;
            bool usry = Double.TryParse(respb.Text, out control);
            if (usry == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                respb.Text = "";
                respb.Focus();
                return;
            }
            double control3;
            bool usrc = Double.TryParse(respb.Text, out control3);
            if (usrc == false)
            {
                MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                respc.Text = "";
                respc.Focus();
                return;
            }
            //  VARIABLES
            int a11, a22,a33, b11, b22,b33, c11, c22,c33, r11, r22,r33 ;
            double  ra, rb, rc,det;
            // asignamos valores 
            a11 = Convert.ToInt32(a1.Text);
            a22 = Convert.ToInt32(a2.Text);
            a33 = Convert.ToInt32(a3.Text);
            b11 = Convert.ToInt32(b1.Text);
            b22 = Convert.ToInt32(b2.Text);
            b33 = Convert.ToInt32(b3.Text);
            c11 = Convert.ToInt32(c1.Text);
            c22 = Convert.ToInt32(c2.Text);
            c33 = Convert.ToInt32(c3.Text);
            r11 = Convert.ToInt32(r1.Text);
            r22 = Convert.ToInt32(r2.Text);
            r33 = Convert.ToInt32(r3.Text);
            // leemos respuesta de usuario 
            ra = Convert.ToDouble(respa.Text);
            rb = Convert.ToDouble(respb.Text);
            rc = Convert.ToDouble(respc.Text);

            //proceso del calculo de las respuestas
           det = avanzado.determinante (a11, a22, a33, b11, b22, b33, c11, c22, c33);
            //revelacion de A
            double at = avanzado.ecuacionac(r11, r22, r33, b11, b22, b33, c11, c22, c33);
            double raa = Math.Round((at / det),2);
            double ct = avanzado.ecuacionac(a11, a22, a33, b11, b22, b33, r11, r22, r33);
            double rcc = Math.Round((ct / det),2);
            double bt = avanzado.ecuacioneb(a11, a22, a33, r11, r22, r33, c11, c22, c33);
            double rbb =Math.Round( (bt / det),2);

            if (avanzado.revisionecua3( ra,  raa, rb, rbb, rc, rcc))
            {
                contbuenas++;
                MessageBox.Show("Sus respuestas son Correctas!\n ", "lleva un total de " + contbuenas + " respuestas correctas");
                this.rc.Text = Convert.ToString(contbuenas);
                puntos++;
                datos_jug dj = new datos_jug(nombre, apellidoz, puntos) ;
                point.Text = puntos.ToString();
                limpiar();
            }
            else
            {
                prueba++;
                MessageBox.Show("por favor vuelva a intentar");
            }
            if (prueba>3)
            {
                contmalas++;
                MessageBox.Show("la respuesta es incorrecta ," + "\n las respuestas correctas son :" + " "+raa+" " +" "+ rbb+" " + " " + rcc+ " " + "\n,lleva :" + contmalas + " respuestas equivocadas");
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

        // metodos para los valores random
        private int randoma(int a, int b)
        {
            Random r = new Random();
            return r.Next(a, b);
        }
        private int randomb(int a, int b)
        {
            Random r = new Random(DateTime.Now.Second);
            return r.Next(a, b);
        }
        private int randomc(int a, int b)
        {
            Random r = new Random(DateTime.Now.Second);
            return r.Next(a, b);

        }
        private int randomr(int a, int b)
        {
            Random r = new Random(DateTime.Now.Second);
            return r.Next(a, b);

        }
        // deshabilitar espacios 
        public void disable()
        {
            a1.Enabled = false;
            a2.Enabled = false;
            a3.Enabled = false;
            b1.Enabled = false;
            b2.Enabled = false;
            b3.Enabled = false; 
            c1.Enabled = false;
            c2.Enabled = false;
            c3.Enabled = false;
            r1.Enabled = false;
            r2.Enabled = false;
            r3.Enabled = false;    
        }
        // BOTON DE AYUDA
        help.h_ecua3 ecua3 = new help.h_ecua3();
        private void button3_Click(object sender, EventArgs e)
        {
            ecua3.ShowDialog();
        }
        // VOID PARA LIMPIAR
        public void limpiar()
        {
            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            c1.Text = "";
            c2.Text = "";
            c3.Text = "";
            r1.Text = "";
            r2.Text = "";
            r3.Text = "";
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
