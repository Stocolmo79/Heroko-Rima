namespace HerokoRima.Forms
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.nuevoProfesorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miembrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaTarjetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarTarjetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaClaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entranceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CashierMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.clasesToolStripMenuItem,
            this.entranceMenuItem,
            this.CashierMenuItem});
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
            this.nuevoProfesorMenuItem});
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.personalToolStripMenuItem.Text = "Profesores";
            this.personalToolStripMenuItem.Visible = false;
            // 
            // profesoresMenuItem
            // 
            this.profesoresMenuItem.Name = "profesoresMenuItem";
            this.profesoresMenuItem.Size = new System.Drawing.Size(153, 26);
            this.profesoresMenuItem.Text = "Profesores";
            this.profesoresMenuItem.Click += new System.EventHandler(this.profesoresMenuItem_Click);
            // 
            // nuevoProfesorMenuItem
            // 
            this.nuevoProfesorMenuItem.Name = "nuevoProfesorMenuItem";
            this.nuevoProfesorMenuItem.Size = new System.Drawing.Size(153, 26);
            this.nuevoProfesorMenuItem.Text = "Nuevo";
            this.nuevoProfesorMenuItem.Click += new System.EventHandler(this.nuevoProfesorMenuItem_Click);
            // 
            // miembrosToolStripMenuItem
            // 
            this.miembrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberToolStripMenuItem,
            this.newMemberToolStripMenuItem});
            this.miembrosToolStripMenuItem.Name = "miembrosToolStripMenuItem";
            this.miembrosToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.miembrosToolStripMenuItem.Text = "Miembros";
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.memberToolStripMenuItem.Text = "Miembros";
            this.memberToolStripMenuItem.Click += new System.EventHandler(this.memberToolStripMenuItem_Click);
            // 
            // newMemberToolStripMenuItem
            // 
            this.newMemberToolStripMenuItem.Name = "newMemberToolStripMenuItem";
            this.newMemberToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newMemberToolStripMenuItem.Text = "Nuevo";
            this.newMemberToolStripMenuItem.Click += new System.EventHandler(this.newMemberToolStripMenuItem_Click);
            // 
            // tarjetasToolStripMenuItem
            // 
            this.tarjetasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaTarjetaToolStripMenuItem,
            this.buscarTarjetaToolStripMenuItem});
            this.tarjetasToolStripMenuItem.Name = "tarjetasToolStripMenuItem";
            this.tarjetasToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.tarjetasToolStripMenuItem.Text = "Tarjetas";
            this.tarjetasToolStripMenuItem.Visible = false;
            // 
            // nuevaTarjetaToolStripMenuItem
            // 
            this.nuevaTarjetaToolStripMenuItem.Name = "nuevaTarjetaToolStripMenuItem";
            this.nuevaTarjetaToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.nuevaTarjetaToolStripMenuItem.Text = "Nueva tarjeta";
            // 
            // buscarTarjetaToolStripMenuItem
            // 
            this.buscarTarjetaToolStripMenuItem.Name = "buscarTarjetaToolStripMenuItem";
            this.buscarTarjetaToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
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
            this.clasesToolStripMenuItem.Visible = false;
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.buscarToolStripMenuItem.Text = "Buscar clase";
            // 
            // nuevaClaseToolStripMenuItem
            // 
            this.nuevaClaseToolStripMenuItem.Name = "nuevaClaseToolStripMenuItem";
            this.nuevaClaseToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.nuevaClaseToolStripMenuItem.Text = "Nueva clase";
            this.nuevaClaseToolStripMenuItem.Click += new System.EventHandler(this.nuevaClaseToolStripMenuItem_Click);
            // 
            // entranceMenuItem
            // 
            this.entranceMenuItem.Name = "entranceMenuItem";
            this.entranceMenuItem.Size = new System.Drawing.Size(78, 24);
            this.entranceMenuItem.Text = "Entradas";
            this.entranceMenuItem.Visible = false;
            this.entranceMenuItem.Click += new System.EventHandler(this.entranceMenuItem_Click);
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
            // CashierMenuItem
            // 
            this.CashierMenuItem.Name = "CashierMenuItem";
            this.CashierMenuItem.Size = new System.Drawing.Size(50, 24);
            this.CashierMenuItem.Text = "Caja";
            this.CashierMenuItem.Click += new System.EventHandler(this.CashierMenuItem_Click);
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
            this.Text = "Empresa - Administración";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem nuevoProfesorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarTarjetaToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem entranceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CashierMenuItem;
    }
}

