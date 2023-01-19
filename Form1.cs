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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        // validar boton ingresar
        private void ingresar_Click(object sender, EventArgs e)
        {
            string usuario, clave;
            usuario = textBox1.Text;
            clave = textBox2.Text;
            // condicionar espacios vacios

            if (usuario == "")
            {
                MessageBox.Show("por favor ingrese un usuario");
                textBox1.Focus();
                return;

            }
            if (clave == "")
            {
                MessageBox.Show("por favor ingrese la clave");
                textBox2.Focus();
                return;
            }
            Login login = new Login();
            
            // condicionar el usuario y contraseña para ingresar al otro formulario
            if (login.acceso(usuario, clave))
            {
                Form2 juegos = new Form2();
                this.Hide();
                juegos.ShowDialog();
                this.Show();
                // vaciar datos ingresados
                textBox1.Text = ("");
                textBox2.Text = ("");
                textBox1.Focus();


            }
            else
            {
                MessageBox.Show("el usuario o contraseña son invalidos,"," por favor vuelva a intentar");
                textBox1.Text=("");
                textBox2.Text = ("");
                textBox1.Focus();
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
