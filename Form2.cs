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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // instancia a la clase de jugadores para pasar datos 
        Opejugadores misjugadores = new Opejugadores();

        // finalizar la ejecucion de proyecto 
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        // programacion de activacion y desactivacion del menu 
        private void Form2_Load(object sender, EventArgs e)
        {
            datos_jug dj  = new datos_jug();
            if (dj.Estado != 1)
            {
                mnu_primario.Enabled = false;
                mnu_medio.Enabled = false;
                mnu_avanzado.Enabled = false;
            }
            else
            {
                mnu_primario.Enabled = true;
                mnu_medio.Enabled = true;
                mnu_avanzado.Enabled = true;
            }
        }
        // llamar formulario de suma
        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nivel_primario.frmsuma suma = new nivel_primario.frmsuma();
            suma.setdatos(misjugadores);
            suma.MdiParent = this;
            suma.Show();

        }

       // llamar formulario de resta

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nivel_primario.frmresta resta = new nivel_primario.frmresta();
            resta.setdatos(misjugadores);
            resta.MdiParent = this;
            resta.Show();
        }
        // llamar formulario de multiplicacion
        private void multiplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nivel_primario.frmmultiplicacion multiplicacion = new nivel_primario.frmmultiplicacion();
            multiplicacion.setdatos(misjugadores);
            multiplicacion.MdiParent = this;
            multiplicacion.Show();
        }
        // llamar formulario de division
        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nivel_primario.frmdivision division = new nivel_primario.frmdivision();
            division.setdatos(misjugadores);
            division.MdiParent = this;
            division.Show();
        }

        // llamar calculo de la pendiente
        private void calculoDeUnaPendienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nivelMedio.frmpendiente pend = new nivelMedio.frmpendiente();
            pend.setdatos(misjugadores);
            pend.MdiParent = this;
            pend.Show();
        }

        private void teoremaDePitagorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nivelMedio.frm_pitagoras pitagoras = new nivelMedio.frm_pitagoras();
            pitagoras.setdatos(misjugadores);
            pitagoras.MdiParent = this;
            pitagoras.Show();

        }

        private void geometriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nivelMedio.Geometria geometry = new nivelMedio.Geometria();
            geometry.setdatos(misjugadores);
            geometry.MdiParent = this;
            geometry.Show();

        }

        private void calculoDeUnaPendientePorDosPuntosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nivelMedio.frmpend2 pend2 = new nivelMedio.frmpend2();
            pend2.setdatos(misjugadores);
            pend2.MdiParent = this;
            pend2.Show();

        }



        private void ecuacionesDePrimerGradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nivel_avanzado.ecuaciones_1erG primerg = new Nivel_avanzado.ecuaciones_1erG();
            primerg.setdatos(misjugadores);
            primerg.MdiParent = this;
            primerg.Show();
        }

        private void ecuacionesConTresIncognitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nivel_avanzado.ecuaciones_3incog incog = new Nivel_avanzado.ecuaciones_3incog();
             incog.setdatos(misjugadores);
             incog.MdiParent = this;
             incog.Show();
        }

        private void formulaGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nivel_avanzado.Formula_Gen formg = new Nivel_avanzado.Formula_Gen();
            formg.setdatos(misjugadores);
            formg.MdiParent = this;
            formg.Show();
        }

        private void ecuacionesDeTercerGradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nivel_avanzado.ecuaciones_racionales form3g = new Nivel_avanzado.ecuaciones_racionales();
            form3g.setdatos(misjugadores);
            form3g.MdiParent = this;
            form3g.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" este programa fue creado por"+"\nKevin Alfonso Mo Leal");
        }

        private void punteoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            punteo punteo = new punteo();
            punteo.setDatos(misjugadores);
            punteo.MdiParent = this;
            punteo.Show();
        }
    }

}
