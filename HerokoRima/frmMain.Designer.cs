namespace HerokoRima
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miembrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miembroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaTarjetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarTarjetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaClaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.personalToolStripMenuItem,
            this.miembrosToolStripMenuItem,
            this.tarjetasToolStripMenuItem,
            this.clasesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1902, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesoresMenuItem,
            this.nuevoToolStripMenuItem});
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.personalToolStripMenuItem.Text = "Profesores";
            // 
            // profesoresMenuItem
            // 
            this.profesoresMenuItem.Name = "profesoresMenuItem";
            this.profesoresMenuItem.Size = new System.Drawing.Size(147, 24);
            this.profesoresMenuItem.Text = "Profesores";
            this.profesoresMenuItem.Click += new System.EventHandler(this.profesoresMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // miembrosToolStripMenuItem
            // 
            this.miembrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miembroToolStripMenuItem,
            this.nuevoToolStripMenuItem1});
            this.miembrosToolStripMenuItem.Name = "miembrosToolStripMenuItem";
            this.miembrosToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.miembrosToolStripMenuItem.Text = "Miembros";
            // 
            // miembroToolStripMenuItem
            // 
            this.miembroToolStripMenuItem.Name = "miembroToolStripMenuItem";
            this.miembroToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.miembroToolStripMenuItem.Text = "Miembros";
            // 
            // nuevoToolStripMenuItem1
            // 
            this.nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            this.nuevoToolStripMenuItem1.Size = new System.Drawing.Size(145, 24);
            this.nuevoToolStripMenuItem1.Text = "Nuevo";
            // 
            // tarjetasToolStripMenuItem
            // 
            this.tarjetasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaTarjetaToolStripMenuItem,
            this.buscarTarjetaToolStripMenuItem});
            this.tarjetasToolStripMenuItem.Name = "tarjetasToolStripMenuItem";
            this.tarjetasToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.tarjetasToolStripMenuItem.Text = "Tarjetas";
            // 
            // nuevaTarjetaToolStripMenuItem
            // 
            this.nuevaTarjetaToolStripMenuItem.Name = "nuevaTarjetaToolStripMenuItem";
            this.nuevaTarjetaToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.nuevaTarjetaToolStripMenuItem.Text = "Nueva tarjeta";
            // 
            // buscarTarjetaToolStripMenuItem
            // 
            this.buscarTarjetaToolStripMenuItem.Name = "buscarTarjetaToolStripMenuItem";
            this.buscarTarjetaToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.buscarTarjetaToolStripMenuItem.Text = "Buscar tarjeta";
            // 
            // clasesToolStripMenuItem
            // 
            this.clasesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem,
            this.nuevaClaseToolStripMenuItem});
            this.clasesToolStripMenuItem.Name = "clasesToolStripMenuItem";
            this.clasesToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.clasesToolStripMenuItem.Text = "Clases";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.buscarToolStripMenuItem.Text = "Buscar clase";
            // 
            // nuevaClaseToolStripMenuItem
            // 
            this.nuevaClaseToolStripMenuItem.Name = "nuevaClaseToolStripMenuItem";
            this.nuevaClaseToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.nuevaClaseToolStripMenuItem.Text = "Nueva clase";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Location = new System.Drawing.Point(0, 31);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1902, 1004);
            this.pnlMain.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heroko Rima Boulder e Yoga - Administración";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miembrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarjetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaTarjetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaClaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miembroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarTarjetaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
    }
}

