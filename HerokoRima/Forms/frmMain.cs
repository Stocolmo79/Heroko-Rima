using System;
using System.Windows.Forms;

using HerokoRimaEntrada;

using Members;

namespace HerokoRima.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            this.InitializeComponent();
            LoadCashier();
        }

       
        

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadMembers(false);
        }
        
        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadMembers(true);
        }
       
        private void entranceMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            var entranceForm  = new frmEntrance{ TopLevel = false, AutoScroll = true, Dock = DockStyle.Fill };
            pnlMain.Controls.Add(entranceForm);
            entranceForm.Show();
        }

        private void CashierMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
         var cashierForm = new frmCashier{ TopLevel = false, AutoScroll = true, Dock = DockStyle.Fill }; 
            pnlMain.Controls.Add(cashierForm);
            cashierForm.Show();
            
        }

        private void nuevoProfesorMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadProfesores(true);
        }

        private void nuevaClaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadClasses();
        }


        private void profesoresMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadProfesores(false);
        }

        private void LoadCashier()
        {
            this.pnlMain.Controls.Clear();
            var cashierForm = new frmCashier() { TopLevel = false, AutoScroll = true, Dock = DockStyle.Fill };
            this.pnlMain.Controls.Add(cashierForm);
            cashierForm.Show();
        }  
        private void LoadMembers(bool newMember)
        {
            this.pnlMain.Controls.Clear();
            var memberForm = new frmMembers { TopLevel = false, AutoScroll = true, Dock = DockStyle.Fill, newMember = newMember };
            pnlMain.Controls.Add(memberForm);
            memberForm.Show();
        }

        private void LoadProfesores(bool newStaff)
        {
            this.pnlMain.Controls.Clear();
            var profeForm = new FrmStaff { TopLevel = false, AutoScroll = true, Dock = DockStyle.Fill, newStaff = newStaff };
            this.pnlMain.Controls.Add(profeForm);
            profeForm.Show();
        }

        private void LoadClasses()
        {
            pnlMain.Controls.Clear();
            var classForm = new FrmClasses() { TopLevel = false, AutoScroll = true, Dock = DockStyle.Fill };
            pnlMain.Controls.Add(classForm);
            classForm.Show();
        }

     
    }



}

