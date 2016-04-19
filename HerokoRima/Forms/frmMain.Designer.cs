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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStaffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.CashierMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.closeCashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.miembrosToolStripMenuItem,
            this.tarjetasToolStripMenuItem,
            this.clasesToolStripMenuItem,
            this.entranceMenuItem,
            this.CashierMenuItem,
            this.closeCashToolStripMenuItem});
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
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffMenuItem,
            this.newStaffMenuItem,
            this.loginToolStripMenuItem});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.staffToolStripMenuItem.Text = "Monitores";
            // 
            // staffMenuItem
            // 
            this.staffMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.weekToolStripMenuItem,
            this.monthToolStripMenuItem,
            this.chooseToolStripMenuItem});
            this.staffMenuItem.Name = "staffMenuItem";
            this.staffMenuItem.Size = new System.Drawing.Size(151, 26);
            this.staffMenuItem.Text = "Monitores";
            this.staffMenuItem.Click += new System.EventHandler(this.staffMenuItem_Click);
            // 
            // weekToolStripMenuItem
            // 
            this.weekToolStripMenuItem.Name = "weekToolStripMenuItem";
            this.weekToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.weekToolStripMenuItem.Text = "Semana";
            this.weekToolStripMenuItem.Click += new System.EventHandler(this.weekToolStripMenuItem_Click);
            // 
            // monthToolStripMenuItem
            // 
            this.monthToolStripMenuItem.Name = "monthToolStripMenuItem";
            this.monthToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.monthToolStripMenuItem.Text = "Mes";
            this.monthToolStripMenuItem.Click += new System.EventHandler(this.monthToolStripMenuItem_Click);
            // 
            // chooseToolStripMenuItem
            // 
            this.chooseToolStripMenuItem.Name = "chooseToolStripMenuItem";
            this.chooseToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.chooseToolStripMenuItem.Text = "Elige";
            this.chooseToolStripMenuItem.Click += new System.EventHandler(this.chooseToolStripMenuItem_Click);
            // 
            // newStaffMenuItem
            // 
            this.newStaffMenuItem.Name = "newStaffMenuItem";
            this.newStaffMenuItem.Size = new System.Drawing.Size(151, 26);
            this.newStaffMenuItem.Text = "Nuevo";
            this.newStaffMenuItem.Click += new System.EventHandler(this.newStaffMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
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
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.memberToolStripMenuItem.Text = "Miembros";
            this.memberToolStripMenuItem.Click += new System.EventHandler(this.memberToolStripMenuItem_Click);
            // 
            // newMemberToolStripMenuItem
            // 
            this.newMemberToolStripMenuItem.Name = "newMemberToolStripMenuItem";
            this.newMemberToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
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
            // CashierMenuItem
            // 
            this.CashierMenuItem.Name = "CashierMenuItem";
            this.CashierMenuItem.Size = new System.Drawing.Size(64, 24);
            this.CashierMenuItem.Text = "Ventas";
            this.CashierMenuItem.Click += new System.EventHandler(this.CashierMenuItem_Click);
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
            // closeCashToolStripMenuItem
            // 
            this.closeCashToolStripMenuItem.Name = "closeCashToolStripMenuItem";
            this.closeCashToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.closeCashToolStripMenuItem.Text = "Cerrar caja";
            this.closeCashToolStripMenuItem.Click += new System.EventHandler(this.closeCashToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa - Administración";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
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
        private ToolStripMenuItem closeCashToolStripMenuItem;
    }
}

