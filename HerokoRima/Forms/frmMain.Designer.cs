using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HerokoRima.Forms
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.menuStrip1 = new MenuStrip();
            this.archivoToolStripMenuItem = new ToolStripMenuItem();
            this.staffToolStripMenuItem = new ToolStripMenuItem();
            this.staffMenuItem = new ToolStripMenuItem();
            this.newStaffMenuItem = new ToolStripMenuItem();
            this.loginToolStripMenuItem = new ToolStripMenuItem();
            this.miembrosToolStripMenuItem = new ToolStripMenuItem();
            this.memberToolStripMenuItem = new ToolStripMenuItem();
            this.newMemberToolStripMenuItem = new ToolStripMenuItem();
            this.tarjetasToolStripMenuItem = new ToolStripMenuItem();
            this.nuevaTarjetaToolStripMenuItem = new ToolStripMenuItem();
            this.buscarTarjetaToolStripMenuItem = new ToolStripMenuItem();
            this.clasesToolStripMenuItem = new ToolStripMenuItem();
            this.buscarToolStripMenuItem = new ToolStripMenuItem();
            this.nuevaClaseToolStripMenuItem = new ToolStripMenuItem();
            this.entranceMenuItem = new ToolStripMenuItem();
            this.CashierMenuItem = new ToolStripMenuItem();
            this.pnlMain = new Panel();
            this.backgroundWorker1 = new BackgroundWorker();
            this.weekToolStripMenuItem = new ToolStripMenuItem();
            this.monthToolStripMenuItem = new ToolStripMenuItem();
            this.chooseToolStripMenuItem = new ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new Size(20, 20);
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.miembrosToolStripMenuItem,
            this.tarjetasToolStripMenuItem,
            this.clasesToolStripMenuItem,
            this.entranceMenuItem,
            this.CashierMenuItem});
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(1902, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.staffMenuItem,
            this.newStaffMenuItem,
            this.loginToolStripMenuItem});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new Size(88, 24);
            this.staffToolStripMenuItem.Text = "Monitores";
            // 
            // staffMenuItem
            // 
            this.staffMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.weekToolStripMenuItem,
            this.monthToolStripMenuItem,
            this.chooseToolStripMenuItem});
            this.staffMenuItem.Name = "staffMenuItem";
            this.staffMenuItem.Size = new Size(181, 26);
            this.staffMenuItem.Text = "Monitores";
            this.staffMenuItem.Click += new EventHandler(this.staffMenuItem_Click);
            // 
            // newStaffMenuItem
            // 
            this.newStaffMenuItem.Name = "newStaffMenuItem";
            this.newStaffMenuItem.Size = new Size(181, 26);
            this.newStaffMenuItem.Text = "Nuevo";
            this.newStaffMenuItem.Click += new EventHandler(this.newStaffMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new Size(181, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // miembrosToolStripMenuItem
            // 
            this.miembrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.memberToolStripMenuItem,
            this.newMemberToolStripMenuItem});
            this.miembrosToolStripMenuItem.Name = "miembrosToolStripMenuItem";
            this.miembrosToolStripMenuItem.Size = new Size(88, 24);
            this.miembrosToolStripMenuItem.Text = "Miembros";
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new Size(151, 26);
            this.memberToolStripMenuItem.Text = "Miembros";
            this.memberToolStripMenuItem.Click += new EventHandler(this.memberToolStripMenuItem_Click);
            // 
            // newMemberToolStripMenuItem
            // 
            this.newMemberToolStripMenuItem.Name = "newMemberToolStripMenuItem";
            this.newMemberToolStripMenuItem.Size = new Size(151, 26);
            this.newMemberToolStripMenuItem.Text = "Nuevo";
            this.newMemberToolStripMenuItem.Click += new EventHandler(this.newMemberToolStripMenuItem_Click);
            // 
            // tarjetasToolStripMenuItem
            // 
            this.tarjetasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.nuevaTarjetaToolStripMenuItem,
            this.buscarTarjetaToolStripMenuItem});
            this.tarjetasToolStripMenuItem.Name = "tarjetasToolStripMenuItem";
            this.tarjetasToolStripMenuItem.Size = new Size(71, 24);
            this.tarjetasToolStripMenuItem.Text = "Tarjetas";
            this.tarjetasToolStripMenuItem.Visible = false;
            // 
            // nuevaTarjetaToolStripMenuItem
            // 
            this.nuevaTarjetaToolStripMenuItem.Name = "nuevaTarjetaToolStripMenuItem";
            this.nuevaTarjetaToolStripMenuItem.Size = new Size(174, 26);
            this.nuevaTarjetaToolStripMenuItem.Text = "Nueva tarjeta";
            // 
            // buscarTarjetaToolStripMenuItem
            // 
            this.buscarTarjetaToolStripMenuItem.Name = "buscarTarjetaToolStripMenuItem";
            this.buscarTarjetaToolStripMenuItem.Size = new Size(174, 26);
            this.buscarTarjetaToolStripMenuItem.Text = "Buscar tarjeta";
            // 
            // clasesToolStripMenuItem
            // 
            this.clasesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.buscarToolStripMenuItem,
            this.nuevaClaseToolStripMenuItem});
            this.clasesToolStripMenuItem.Name = "clasesToolStripMenuItem";
            this.clasesToolStripMenuItem.Size = new Size(62, 24);
            this.clasesToolStripMenuItem.Text = "Clases";
            this.clasesToolStripMenuItem.Visible = false;
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new Size(164, 26);
            this.buscarToolStripMenuItem.Text = "Buscar clase";
            // 
            // nuevaClaseToolStripMenuItem
            // 
            this.nuevaClaseToolStripMenuItem.Name = "nuevaClaseToolStripMenuItem";
            this.nuevaClaseToolStripMenuItem.Size = new Size(164, 26);
            this.nuevaClaseToolStripMenuItem.Text = "Nueva clase";
            this.nuevaClaseToolStripMenuItem.Click += new EventHandler(this.nuevaClaseToolStripMenuItem_Click);
            // 
            // entranceMenuItem
            // 
            this.entranceMenuItem.Name = "entranceMenuItem";
            this.entranceMenuItem.Size = new Size(78, 24);
            this.entranceMenuItem.Text = "Entradas";
            this.entranceMenuItem.Visible = false;
            this.entranceMenuItem.Click += new EventHandler(this.entranceMenuItem_Click);
            // 
            // CashierMenuItem
            // 
            this.CashierMenuItem.Name = "CashierMenuItem";
            this.CashierMenuItem.Size = new Size(50, 24);
            this.CashierMenuItem.Text = "Caja";
            this.CashierMenuItem.Click += new EventHandler(this.CashierMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.pnlMain.Location = new Point(0, 31);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new Size(1902, 1004);
            this.pnlMain.TabIndex = 2;
            // 
            // weekToolStripMenuItem
            // 
            this.weekToolStripMenuItem.Name = "weekToolStripMenuItem";
            this.weekToolStripMenuItem.Size = new Size(181, 26);
            this.weekToolStripMenuItem.Text = "Semana";
            this.weekToolStripMenuItem.Click += new EventHandler(this.weekToolStripMenuItem_Click);
            // 
            // monthToolStripMenuItem
            // 
            this.monthToolStripMenuItem.Name = "monthToolStripMenuItem";
            this.monthToolStripMenuItem.Size = new Size(181, 26);
            this.monthToolStripMenuItem.Text = "Mes";
            this.monthToolStripMenuItem.Click += new EventHandler(this.monthToolStripMenuItem_Click);
            // 
            // chooseToolStripMenuItem
            // 
            this.chooseToolStripMenuItem.Name = "chooseToolStripMenuItem";
            this.chooseToolStripMenuItem.Size = new Size(181, 26);
            this.chooseToolStripMenuItem.Text = "Elige";
            this.chooseToolStripMenuItem.Click += new EventHandler(this.chooseToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new SizeF(8F, 16F);
    
            this.ClientSize = new Size(1902, 1033);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Empresa - Administración";
            this.WindowState = FormWindowState.Maximized;
            this.Load += new EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem staffToolStripMenuItem;
        private ToolStripMenuItem miembrosToolStripMenuItem;
        private ToolStripMenuItem tarjetasToolStripMenuItem;
        private ToolStripMenuItem nuevaTarjetaToolStripMenuItem;
        private ToolStripMenuItem clasesToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem nuevaClaseToolStripMenuItem;
        private ToolStripMenuItem staffMenuItem;
        private ToolStripMenuItem newStaffMenuItem;
        private ToolStripMenuItem memberToolStripMenuItem;
        private ToolStripMenuItem newMemberToolStripMenuItem;
        private ToolStripMenuItem buscarTarjetaToolStripMenuItem;
        private Panel pnlMain;
        private BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem entranceMenuItem;
        private ToolStripMenuItem CashierMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem weekToolStripMenuItem;
        private ToolStripMenuItem monthToolStripMenuItem;
        private ToolStripMenuItem chooseToolStripMenuItem;
    }
}

