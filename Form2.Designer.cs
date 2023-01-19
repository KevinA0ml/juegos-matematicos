namespace juego_educativo
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.punteoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_primario = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_medio = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoDeUnaPendienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoDeUnaPendientePorDosPuntosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teoremaDePitagorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geometriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_avanzado = new System.Windows.Forms.ToolStripMenuItem();
            this.ecuacionesDePrimerGradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulaGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecuacionesConTresIncognitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecuacionesDeTercerGradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.mnu_primario,
            this.mnu_medio,
            this.mnu_avanzado});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MenuActivate += new System.EventHandler(this.Form2_Load);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.punteoToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // punteoToolStripMenuItem
            // 
            this.punteoToolStripMenuItem.Name = "punteoToolStripMenuItem";
            this.punteoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.punteoToolStripMenuItem.Text = "Archivo";
            this.punteoToolStripMenuItem.Click += new System.EventHandler(this.punteoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // mnu_primario
            // 
            this.mnu_primario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaToolStripMenuItem,
            this.restaToolStripMenuItem,
            this.multiplicacionToolStripMenuItem,
            this.divisionToolStripMenuItem});
            this.mnu_primario.Name = "mnu_primario";
            this.mnu_primario.Size = new System.Drawing.Size(94, 20);
            this.mnu_primario.Text = "Nivel primario";
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sumaToolStripMenuItem.Text = "suma";
            this.sumaToolStripMenuItem.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // restaToolStripMenuItem
            // 
            this.restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            this.restaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restaToolStripMenuItem.Text = "resta";
            this.restaToolStripMenuItem.Click += new System.EventHandler(this.restaToolStripMenuItem_Click);
            // 
            // multiplicacionToolStripMenuItem
            // 
            this.multiplicacionToolStripMenuItem.Name = "multiplicacionToolStripMenuItem";
            this.multiplicacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.multiplicacionToolStripMenuItem.Text = "multiplicacion";
            this.multiplicacionToolStripMenuItem.Click += new System.EventHandler(this.multiplicacionToolStripMenuItem_Click);
            // 
            // divisionToolStripMenuItem
            // 
            this.divisionToolStripMenuItem.Name = "divisionToolStripMenuItem";
            this.divisionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.divisionToolStripMenuItem.Text = "division";
            this.divisionToolStripMenuItem.Click += new System.EventHandler(this.divisionToolStripMenuItem_Click);
            // 
            // mnu_medio
            // 
            this.mnu_medio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculoDeUnaPendienteToolStripMenuItem,
            this.calculoDeUnaPendientePorDosPuntosToolStripMenuItem,
            this.teoremaDePitagorasToolStripMenuItem,
            this.geometriaToolStripMenuItem});
            this.mnu_medio.Name = "mnu_medio";
            this.mnu_medio.Size = new System.Drawing.Size(83, 20);
            this.mnu_medio.Text = "Nivel medio";
            // 
            // calculoDeUnaPendienteToolStripMenuItem
            // 
            this.calculoDeUnaPendienteToolStripMenuItem.Name = "calculoDeUnaPendienteToolStripMenuItem";
            this.calculoDeUnaPendienteToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.calculoDeUnaPendienteToolStripMenuItem.Text = "Calculo de una pendiente";
            this.calculoDeUnaPendienteToolStripMenuItem.Click += new System.EventHandler(this.calculoDeUnaPendienteToolStripMenuItem_Click);
            // 
            // calculoDeUnaPendientePorDosPuntosToolStripMenuItem
            // 
            this.calculoDeUnaPendientePorDosPuntosToolStripMenuItem.Name = "calculoDeUnaPendientePorDosPuntosToolStripMenuItem";
            this.calculoDeUnaPendientePorDosPuntosToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.calculoDeUnaPendientePorDosPuntosToolStripMenuItem.Text = "Calculo de una pendiente por dos puntos";
            this.calculoDeUnaPendientePorDosPuntosToolStripMenuItem.Click += new System.EventHandler(this.calculoDeUnaPendientePorDosPuntosToolStripMenuItem_Click);
            // 
            // teoremaDePitagorasToolStripMenuItem
            // 
            this.teoremaDePitagorasToolStripMenuItem.Name = "teoremaDePitagorasToolStripMenuItem";
            this.teoremaDePitagorasToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.teoremaDePitagorasToolStripMenuItem.Text = "Teorema de pitagoras";
            this.teoremaDePitagorasToolStripMenuItem.Click += new System.EventHandler(this.teoremaDePitagorasToolStripMenuItem_Click);
            // 
            // geometriaToolStripMenuItem
            // 
            this.geometriaToolStripMenuItem.Name = "geometriaToolStripMenuItem";
            this.geometriaToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.geometriaToolStripMenuItem.Text = "Circulo Geometrico";
            this.geometriaToolStripMenuItem.Click += new System.EventHandler(this.geometriaToolStripMenuItem_Click);
            // 
            // mnu_avanzado
            // 
            this.mnu_avanzado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ecuacionesDePrimerGradoToolStripMenuItem,
            this.formulaGeneralToolStripMenuItem,
            this.ecuacionesConTresIncognitasToolStripMenuItem,
            this.ecuacionesDeTercerGradoToolStripMenuItem});
            this.mnu_avanzado.Name = "mnu_avanzado";
            this.mnu_avanzado.Size = new System.Drawing.Size(99, 20);
            this.mnu_avanzado.Text = "Nivel avanzado";
            // 
            // ecuacionesDePrimerGradoToolStripMenuItem
            // 
            this.ecuacionesDePrimerGradoToolStripMenuItem.Name = "ecuacionesDePrimerGradoToolStripMenuItem";
            this.ecuacionesDePrimerGradoToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.ecuacionesDePrimerGradoToolStripMenuItem.Text = "Ecuaciones de primer grado";
            this.ecuacionesDePrimerGradoToolStripMenuItem.Click += new System.EventHandler(this.ecuacionesDePrimerGradoToolStripMenuItem_Click);
            // 
            // formulaGeneralToolStripMenuItem
            // 
            this.formulaGeneralToolStripMenuItem.Name = "formulaGeneralToolStripMenuItem";
            this.formulaGeneralToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.formulaGeneralToolStripMenuItem.Text = "Formula General, cuadratica";
            this.formulaGeneralToolStripMenuItem.Click += new System.EventHandler(this.formulaGeneralToolStripMenuItem_Click);
            // 
            // ecuacionesConTresIncognitasToolStripMenuItem
            // 
            this.ecuacionesConTresIncognitasToolStripMenuItem.Name = "ecuacionesConTresIncognitasToolStripMenuItem";
            this.ecuacionesConTresIncognitasToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.ecuacionesConTresIncognitasToolStripMenuItem.Text = "Ecuaciones con tres incognitas";
            this.ecuacionesConTresIncognitasToolStripMenuItem.Click += new System.EventHandler(this.ecuacionesConTresIncognitasToolStripMenuItem_Click);
            // 
            // ecuacionesDeTercerGradoToolStripMenuItem
            // 
            this.ecuacionesDeTercerGradoToolStripMenuItem.Name = "ecuacionesDeTercerGradoToolStripMenuItem";
            this.ecuacionesDeTercerGradoToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.ecuacionesDeTercerGradoToolStripMenuItem.Text = "derivada de una ecuacion";
            this.ecuacionesDeTercerGradoToolStripMenuItem.Click += new System.EventHandler(this.ecuacionesDeTercerGradoToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2";
            this.Text = "Juegos";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_primario;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_medio;
        private System.Windows.Forms.ToolStripMenuItem calculoDeUnaPendienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teoremaDePitagorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geometriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoDeUnaPendientePorDosPuntosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_avanzado;
        private System.Windows.Forms.ToolStripMenuItem ecuacionesDePrimerGradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecuacionesConTresIncognitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulaGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecuacionesDeTercerGradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem punteoToolStripMenuItem;
    }
}