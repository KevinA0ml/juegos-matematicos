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
    public partial class frm_pitagoras : Form
    {
        public frm_pitagoras()
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
        //llamamos la clase donde estan los metodos
        Metod_med medio = new Metod_med();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            casillas_establecidas();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            int opcion = comboBox1.SelectedIndex;
            if (opcion == 0)
            {
                MessageBox.Show("porfavor elija el valor con el que desea trabajar ");
                return;
            }
            if (opcion == 1)
            {
                int vmen = 1;  int vmay = 10;
                b.Text = medio.valoresr1(vmen, vmay) ;
                c.Text = medio.valoresr2(vmen, vmay);
            }
            else if (opcion == 2)
            {
                int vmen = 1; int vmay = 10;
                a.Text = medio.valoresr1(vmen, vmay) ;
                c.Text = medio.valoresr2(vmen, vmay);

            }
            else
            {
                int vmen = 1; int vmay = 10;
                b.Text = medio.valoresr1(vmen, vmay) ;
                a.Text = medio.valoresr2(vmen, vmay);
            }
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int opcion = comboBox1.SelectedIndex;
            if (opcion == 0)
            {
                MessageBox.Show("porfavor elija el valor con el que desea trabajar ");
                return;
            }
            if (opcion == 1)
            {
                int vmen = 10; int vmay = 100;
                b.Text = medio.valoresr1(vmen, vmay);
                c.Text = medio.valoresr2(vmen, vmay);
            }
            else if (opcion == 2)
            {
                int vmen = 10; int vmay = 100;
                a.Text = medio.valoresr1(vmen, vmay) ;
                c.Text = medio.valoresr2(vmen, vmay);

            }
            else
            {
                int vmen = 10; int vmay = 100;
                a.Text = medio.valoresr1(vmen, vmay) ;
                b.Text = medio.valoresr2(vmen, vmay);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int opcion = comboBox1.SelectedIndex;
            if (opcion == 0)
            {
                MessageBox.Show("porfavor elija el valor con el que desea trabajar ");
                return;
            }
            if (opcion == 1)
            {
                int vmen = 100; int vmay = 1000;
                b.Text = medio.valoresr1(vmen, vmay);
                c.Text = medio.valoresr2(vmen, vmay);
            }
            else if (opcion == 2)
            {
                int vmen = 100; int vmay = 1000;
                a.Text = medio.valoresr1(vmen, vmay) ;
                c.Text = medio.valoresr2(vmen, vmay);

            }
            else
            {
                int vmen = 100; int vmay = 1000;
                a.Text = medio.valoresr1(vmen, vmay) ;
                b.Text = medio.valoresr2(vmen, vmay);
            }
        
        }
        int contbuenas = 0, contmalas = 0;
        // BOTON DE CALCULAR 
        private void calcular_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("porfavor elija el valor con el que desea trabajar ");
                return;
            }
            //cuidando que se seleccione un radiobutton
            if ((a.Text == "") || (b.Text == "") || (c.Text == ""))
            {
                MessageBox.Show("\n Error", " usted no a seleccionado ningun nivel");
                
                return;
            }         
            //declaracion de variables 
            double a1, b1, c1;
            // conteo del punteo
    

            // instancia de combobox


            int opcion =  comboBox1.SelectedIndex;

            //utiliza un switch para que el programa siga el camino segun el usuario
            switch (opcion)
            {
                case 1:
                    bool ry = Double.TryParse(a.Text, out a1);
                    if (ry == false)
                    {
                        // verificar que solo ingrese valores numericos
                        MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                        a.Text = "";
                        a.Focus();
                        return;
                    }
                        // Otorgamos valores
                        b1 = Convert.ToDouble(b.Text);
                        c1 = Convert.ToDouble(c.Text);
                        a1 = Convert.ToDouble(a.Text); // respuesta

                    // verifica la respuesta
                         if (medio.revisionPitagoras1(a1,b1,c1))
                         {
                            contbuenas++;
                            MessageBox.Show("Su respuesta es Correcta!\n ", "lleva un total de " + contbuenas + " respuestas correctas");
                            rc.Text = Convert.ToString(contbuenas);
                        puntos++;
                        datos_jug dj = new datos_jug(nombre, apellidoz, puntos) ;
                        point.Text = puntos.ToString();
                        limpiar();
                          a.Focus();

                         }
                    // si es incorrecta
                         else
                        {
                            contmalas++;
                            MessageBox.Show("la respuesta es incorrecta ," + "\n la respuesta correcta es :" + medio.rspitagoras1(b1,c1) + "\n,lleva :" + contmalas + " respuestas equivocadas");
                            ri.Text = Convert.ToString(contmalas);
                            limpiar();
                            a.Focus();
                            
                        }
                    
                    break;


                case 2:
                    // verificar que solo ingrese valores numericos
                    bool ra = Double.TryParse(b.Text, out b1);
                    if (ra == false)
                    {
                        MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                        b.Text = "";
                        b.Focus();
                        return;
                    }
                    //otorgamos valores
                    a1 = Convert.ToDouble(a.Text);
                    c1 = Convert.ToDouble(c.Text);
                    b1 = Convert.ToDouble(b.Text);// respuesta
          

                    //verifica si la respuesta es correcta
                    if (medio.revisionPitagoras2(a1,b1,c1))
                    {
                        contbuenas++;
                        MessageBox.Show("Su respuesta es Correcta!\n ", "lleva un total de " + contbuenas + " respuestas correctas");
                        rc.Text = Convert.ToString(contbuenas);
                        puntos ++;
                        datos_jug dj = new datos_jug(nombre, apellidoz, puntos);
                        point.Text = puntos.ToString();
                        limpiar();
                        a.Focus();

                    }
                    // si es incorrecta
                    else
                    { 
                        contmalas++;
                        MessageBox.Show("la respuesta es incorrecta ," + "\n la respuesta correcta es :" + medio.rspitagoras2(a1,c1) + "\n,lleva :" + contmalas + " respuestas equivocadas");
                        ri.Text = Convert.ToString(contmalas);
                        limpiar();
                        a.Focus();
                        
                    }



                    break;
                case 3:
                    // verificar que solo ingrese valores numericos
                    bool re = Double.TryParse(c.Text, out c1);
                    if (re == false)
                    {
                        MessageBox.Show("el valor que a ingresado no es numerico", "\n por favor ingrese un dato valido");
                        c.Text = "";
                        c.Focus();
                        return;
                    }
                    //operar
                    a1 = Convert.ToDouble(a.Text);
                    b1 = Convert.ToDouble(b.Text);
                    c1 = Convert.ToDouble(c.Text); // respuesta
                     //verifica si la respuesta es correcta
                    if (medio.revisionPitagoras3(a1,b1,c1))
                    {
                        contbuenas++;
                        MessageBox.Show("Su respuesta es Correcta!\n ", "lleva un total de " + contbuenas + " respuestas correctas");
                        rc.Text = Convert.ToString(contbuenas);
                        puntos++;
                        datos_jug dj = new datos_jug(nombre, apellidoz, puntos);
                        point.Text = puntos.ToString();
                        limpiar();
                        a.Focus();

                    }
                    // si es incorrecta
                    else
                    {
                        contmalas++;
                        MessageBox.Show("la respuesta es incorrecta ," + "\n la respuesta correcta es :" + medio.rspitagoras3(a1,b1)+ "\n,lleva :" + contmalas + " respuestas equivocadas");
                        ri.Text = Convert.ToString(contmalas);
                        limpiar();
                        a.Focus();
                        
                    }
                    break;
            }
            
            //pierde si tiene 4 malas, no deja pasar de 3
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
//Boton de NUEVO
        private void button2_Click(object sender, EventArgs e)
        {
            rc.Text = "";
            ri.Text = "";
            limpiar();
        }
//cierra el programa
        private void button1_Click(object sender, EventArgs e)
        {
            datos_jug mijugador = new datos_jug(nombre, apellidoz, puntos);
            misjugadores.modjugador(mijugador, posAct);
            Close();
        }
        // metodos agregados
        // bloquea casillas
        private void casillas_establecidas()
        {
            int opcion = comboBox1.SelectedIndex;

            if (opcion == 1)
            {
                a.Enabled = true;
                b.Enabled = false;
                c.Enabled = false;
            }
            else if
             (opcion == 2)
            {
                a.Enabled = false;
                b.Enabled = true;
                c.Enabled = false;
            }
            else
            {
                a.Enabled = false;
                b.Enabled = false;
                c.Enabled = true;
            }
        }
        // void para LIMPIAR
        private void limpiar()
        {
            a.Text = "";
            b.Text = "";
            c.Text = "";
            var radiolist = groupBox2.Controls.OfType<RadioButton>().ToList();
            foreach (var radio in radiolist)
            {
                radio.Checked = false;
            }
        }
        // boton de AYUDA
        help.h_pitagoras pita = new help.h_pitagoras();
        private void help_Click(object sender, EventArgs e)
        {
            pita.ShowDialog();
        }

        private void frm_pitagoras_Load(object sender, EventArgs e)
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
