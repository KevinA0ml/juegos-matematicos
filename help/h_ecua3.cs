using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juego_educativo.help
{
    public partial class h_ecua3 : Form
    {
        public h_ecua3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La regla de Sarrus dice que para calcular un determinate de" +
                " orden 3 tenemos que sumar el producto de los elementos de la diagonal principal y el producto de sus diagonales paralelas con sus correspondientes" +
                " vértices opuestos, y luego restar el producto de los elementos de la diagonal secundaria y el producto de sus diagonales paralelas con " +
                "sus correspondientes vértices opuestos. ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
