using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juego_educativo
{
    public partial class punteo : Form
    {
        // variable que lleva el punteo
        public int puntos = 0;
        // variable para llevar el control del estado de los usuarios
        private Boolean nuevo = false;
        //declarar variable de tipo objeto
        private Opejugadores misjugadores;
        public void setDatos(Opejugadores misjugadores)
        {
            this.misjugadores = misjugadores;
        }
        public punteo()
        {
            InitializeComponent();

        }

        private void NEW_Click(object sender, EventArgs e)
        {
            nuevo = true;
            // variables
            string nombre;
            string apellidoz;
            int estado = 1;
            nombre = textBox1.Text;
            apellidoz = textBox3.Text;
            // generamos instancia para enviar datos por medio del constructor 
            datos_jug mijugador = new datos_jug(nombre, apellidoz, puntos);
            // condicion para evaluar registro de usuario
            string msg;
            if (nuevo)
            {
                msg = misjugadores.addjugador(mijugador);
                MessageBox.Show("" + msg);
            }
            limpiar();
            llenartabla();
            int pos = misjugadores.posicionjugador(nombre);
            datos_jug dj1 = new datos_jug(estado, pos);

            this.Close();
        }

        private void busc_Click(object sender, EventArgs e)
        {
            datos_jug dj = new datos_jug();
            textBox1.Text = dj.Nombre;
            textBox3.Text = dj.Apellidos;
            textBox2.Text = Convert.ToString(dj.Puntos);
        }
        //
        //metodos

        // metodo para llenar el datagrid 
        public void llenartabla()
        {
            datos.DataSource = null;
            for (int i = 0; i < misjugadores.numjug(); i++)
            {
                // datos.DataSource = misjugadores.Get_Jugs();
                int n = datos.Rows.Add();
                // agregamos a la columna de los nombres
                datos.Rows[n].Cells[0].Value = misjugadores.Get_Jugs()[i].Nombre;
                // agregamos a la columna de los apellidos 
                datos.Rows[n].Cells[1].Value = misjugadores.Get_Jugs()[i].Apellidos;
                // agregamos a la columna de los nombres
                datos.Rows[n].Cells[2].Value = misjugadores.Get_Jugs()[i].Puntos;
            }
        }
        // metodo para limpiar el datagrid
        public void limpiar()
        {
            datos.Rows.Clear();
            datos.Refresh();
        }

        private void punteo_Load(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(puntos);
            llenartabla();
            label6.Text = Convert.ToString(misjugadores.contusuario());
        }

        // ingresar datos


    }
}
