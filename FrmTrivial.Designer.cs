
namespace Trivial
{
    partial class FrmTrivial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuPartida = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPartidaNueva = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuPartidaSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOpcionesCapitales = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOpcionesPaises = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuOpcionesMultiplesOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOpcionesEscribirRespuesta = new System.Windows.Forms.ToolStripMenuItem();
            this.LblPais = new System.Windows.Forms.Label();
            this.LblCapital = new System.Windows.Forms.Label();
            this.LblPorcentaje = new System.Windows.Forms.Label();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TxtPais = new System.Windows.Forms.TextBox();
            this.TxtRespuestaCero = new System.Windows.Forms.TextBox();
            this.TxtRespuestaUno = new System.Windows.Forms.TextBox();
            this.TxtRespuestaDos = new System.Windows.Forms.TextBox();
            this.TxtRespuestaTres = new System.Windows.Forms.TextBox();
            this.TxtPorcentaje = new System.Windows.Forms.TextBox();
            this.TxtRespuestaEscrita = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuPartida,
            this.MnuOpciones});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(262, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuPartida
            // 
            this.MnuPartida.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuPartidaNueva,
            this.toolStripSeparator1,
            this.MnuPartidaSalir});
            this.MnuPartida.Name = "MnuPartida";
            this.MnuPartida.Size = new System.Drawing.Size(56, 20);
            this.MnuPartida.Text = "Partida";
            // 
            // MnuPartidaNueva
            // 
            this.MnuPartidaNueva.Name = "MnuPartidaNueva";
            this.MnuPartidaNueva.Size = new System.Drawing.Size(108, 22);
            this.MnuPartidaNueva.Text = "Nueva";
            this.MnuPartidaNueva.Click += new System.EventHandler(this.MnuPartidaNueva_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(105, 6);
            // 
            // MnuPartidaSalir
            // 
            this.MnuPartidaSalir.Name = "MnuPartidaSalir";
            this.MnuPartidaSalir.Size = new System.Drawing.Size(108, 22);
            this.MnuPartidaSalir.Text = "Salir";
            this.MnuPartidaSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // MnuOpciones
            // 
            this.MnuOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuOpcionesCapitales,
            this.MnuOpcionesPaises,
            this.toolStripSeparator2,
            this.MnuOpcionesMultiplesOpciones,
            this.MnuOpcionesEscribirRespuesta});
            this.MnuOpciones.Name = "MnuOpciones";
            this.MnuOpciones.Size = new System.Drawing.Size(69, 20);
            this.MnuOpciones.Text = "Opciones";
            // 
            // MnuOpcionesCapitales
            // 
            this.MnuOpcionesCapitales.Checked = true;
            this.MnuOpcionesCapitales.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MnuOpcionesCapitales.Name = "MnuOpcionesCapitales";
            this.MnuOpcionesCapitales.Size = new System.Drawing.Size(180, 22);
            this.MnuOpcionesCapitales.Text = "Nombre capitales";
            this.MnuOpcionesCapitales.Click += new System.EventHandler(this.MnuOpcionesCapitales_Click);
            // 
            // MnuOpcionesPaises
            // 
            this.MnuOpcionesPaises.Name = "MnuOpcionesPaises";
            this.MnuOpcionesPaises.Size = new System.Drawing.Size(180, 22);
            this.MnuOpcionesPaises.Text = "Nombre países";
            this.MnuOpcionesPaises.Click += new System.EventHandler(this.MnuOpcionesPaises_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // MnuOpcionesMultiplesOpciones
            // 
            this.MnuOpcionesMultiplesOpciones.Checked = true;
            this.MnuOpcionesMultiplesOpciones.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MnuOpcionesMultiplesOpciones.Name = "MnuOpcionesMultiplesOpciones";
            this.MnuOpcionesMultiplesOpciones.Size = new System.Drawing.Size(180, 22);
            this.MnuOpcionesMultiplesOpciones.Text = "Múltiples opciones";
            this.MnuOpcionesMultiplesOpciones.Click += new System.EventHandler(this.MnuOpcionesMultiplesOpciones_Click);
            // 
            // MnuOpcionesEscribirRespuesta
            // 
            this.MnuOpcionesEscribirRespuesta.Name = "MnuOpcionesEscribirRespuesta";
            this.MnuOpcionesEscribirRespuesta.Size = new System.Drawing.Size(180, 22);
            this.MnuOpcionesEscribirRespuesta.Text = "Escribir respuesta";
            this.MnuOpcionesEscribirRespuesta.Click += new System.EventHandler(this.MnuOpcionesEscribirRespuesta_Click);
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.Location = new System.Drawing.Point(13, 28);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(30, 13);
            this.LblPais.TabIndex = 1;
            this.LblPais.Text = "Pais:";
            // 
            // LblCapital
            // 
            this.LblCapital.AutoSize = true;
            this.LblCapital.Location = new System.Drawing.Point(13, 98);
            this.LblCapital.Name = "LblCapital";
            this.LblCapital.Size = new System.Drawing.Size(42, 13);
            this.LblCapital.TabIndex = 2;
            this.LblCapital.Text = "Capital:";
            // 
            // LblPorcentaje
            // 
            this.LblPorcentaje.AutoSize = true;
            this.LblPorcentaje.Location = new System.Drawing.Point(197, 311);
            this.LblPorcentaje.Name = "LblPorcentaje";
            this.LblPorcentaje.Size = new System.Drawing.Size(53, 13);
            this.LblPorcentaje.TabIndex = 3;
            this.LblPorcentaje.Text = "%Aciertos";
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.Location = new System.Drawing.Point(16, 311);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(107, 23);
            this.BtnSiguiente.TabIndex = 4;
            this.BtnSiguiente.Text = "Siguiente";
            this.BtnSiguiente.UseVisualStyleBackColor = true;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(16, 340);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(107, 23);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtPais
            // 
            this.TxtPais.Location = new System.Drawing.Point(16, 45);
            this.TxtPais.Multiline = true;
            this.TxtPais.Name = "TxtPais";
            this.TxtPais.Size = new System.Drawing.Size(234, 32);
            this.TxtPais.TabIndex = 6;
            // 
            // TxtRespuestaCero
            // 
            this.TxtRespuestaCero.Location = new System.Drawing.Point(16, 147);
            this.TxtRespuestaCero.Multiline = true;
            this.TxtRespuestaCero.Name = "TxtRespuestaCero";
            this.TxtRespuestaCero.Size = new System.Drawing.Size(234, 32);
            this.TxtRespuestaCero.TabIndex = 7;
            this.TxtRespuestaCero.Click += new System.EventHandler(this.clickRespuesta);
            // 
            // TxtRespuestaUno
            // 
            this.TxtRespuestaUno.Location = new System.Drawing.Point(16, 185);
            this.TxtRespuestaUno.Multiline = true;
            this.TxtRespuestaUno.Name = "TxtRespuestaUno";
            this.TxtRespuestaUno.Size = new System.Drawing.Size(234, 32);
            this.TxtRespuestaUno.TabIndex = 8;
            this.TxtRespuestaUno.Click += new System.EventHandler(this.clickRespuesta);
            // 
            // TxtRespuestaDos
            // 
            this.TxtRespuestaDos.Location = new System.Drawing.Point(16, 223);
            this.TxtRespuestaDos.Multiline = true;
            this.TxtRespuestaDos.Name = "TxtRespuestaDos";
            this.TxtRespuestaDos.Size = new System.Drawing.Size(234, 32);
            this.TxtRespuestaDos.TabIndex = 9;
            this.TxtRespuestaDos.Click += new System.EventHandler(this.clickRespuesta);
            // 
            // TxtRespuestaTres
            // 
            this.TxtRespuestaTres.Location = new System.Drawing.Point(16, 261);
            this.TxtRespuestaTres.Multiline = true;
            this.TxtRespuestaTres.Name = "TxtRespuestaTres";
            this.TxtRespuestaTres.Size = new System.Drawing.Size(234, 32);
            this.TxtRespuestaTres.TabIndex = 10;
            this.TxtRespuestaTres.Click += new System.EventHandler(this.clickRespuesta);
            // 
            // TxtPorcentaje
            // 
            this.TxtPorcentaje.BackColor = System.Drawing.Color.Khaki;
            this.TxtPorcentaje.Location = new System.Drawing.Point(200, 328);
            this.TxtPorcentaje.Multiline = true;
            this.TxtPorcentaje.Name = "TxtPorcentaje";
            this.TxtPorcentaje.Size = new System.Drawing.Size(50, 35);
            this.TxtPorcentaje.TabIndex = 11;
            // 
            // TxtRespuestaEscrita
            // 
            this.TxtRespuestaEscrita.BackColor = System.Drawing.SystemColors.Window;
            this.TxtRespuestaEscrita.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtRespuestaEscrita.Location = new System.Drawing.Point(64, 98);
            this.TxtRespuestaEscrita.Multiline = true;
            this.TxtRespuestaEscrita.Name = "TxtRespuestaEscrita";
            this.TxtRespuestaEscrita.Size = new System.Drawing.Size(186, 32);
            this.TxtRespuestaEscrita.TabIndex = 12;
            this.TxtRespuestaEscrita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRespuestaEscrita_KeyPress);
            // 
            // FrmTrivial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 377);
            this.Controls.Add(this.TxtRespuestaEscrita);
            this.Controls.Add(this.TxtPorcentaje);
            this.Controls.Add(this.TxtRespuestaTres);
            this.Controls.Add(this.TxtRespuestaDos);
            this.Controls.Add(this.TxtRespuestaUno);
            this.Controls.Add(this.TxtRespuestaCero);
            this.Controls.Add(this.TxtPais);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnSiguiente);
            this.Controls.Add(this.LblPorcentaje);
            this.Controls.Add(this.LblCapital);
            this.Controls.Add(this.LblPais);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmTrivial";
            this.Text = "Trivial";
            this.Load += new System.EventHandler(this.FrmTrivial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuPartida;
        private System.Windows.Forms.ToolStripMenuItem MnuPartidaNueva;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MnuPartidaSalir;
        private System.Windows.Forms.ToolStripMenuItem MnuOpciones;
        private System.Windows.Forms.ToolStripMenuItem MnuOpcionesCapitales;
        private System.Windows.Forms.ToolStripMenuItem MnuOpcionesPaises;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MnuOpcionesMultiplesOpciones;
        private System.Windows.Forms.ToolStripMenuItem MnuOpcionesEscribirRespuesta;
        private System.Windows.Forms.Label LblPais;
        private System.Windows.Forms.Label LblCapital;
        private System.Windows.Forms.Label LblPorcentaje;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtPais;
        private System.Windows.Forms.TextBox TxtRespuestaCero;
        private System.Windows.Forms.TextBox TxtRespuestaUno;
        private System.Windows.Forms.TextBox TxtRespuestaDos;
        private System.Windows.Forms.TextBox TxtRespuestaTres;
        private System.Windows.Forms.TextBox TxtPorcentaje;
        private System.Windows.Forms.TextBox TxtRespuestaEscrita;
    }
}

