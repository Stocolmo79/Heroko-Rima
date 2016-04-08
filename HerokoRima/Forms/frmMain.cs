using System;
using System.Windows.Forms;
using  HerokoRimaEntrada;
using Cashier;
namespace HerokoRima.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            this.InitializeComponent();
            LoadMembers(false);
        }

        private void profesoresMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadProfesores(false);
        }

        private void LoadProfesores(bool newStaff)
        {
            this.pnlMain.Controls.Clear();
            var profeForm = new FrmStaff { TopLevel = false, AutoScroll = true, Dock = DockStyle.Fill, newStaff = newStaff };
            this.pnlMain.Controls.Add(profeForm);
            profeForm.Show();
        }

        private void nuevoProfesorMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadProfesores(true);
        }

        private void nuevaClaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadClasses();
        }

        private void LoadClasses()
        {
            pnlMain.Controls.Clear();
            var classForm = new FrmClasses() { TopLevel = false, AutoScroll = true, Dock = DockStyle.Fill };
            pnlMain.Controls.Add(classForm);
            classForm.Show();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadMembers(false);
        }

        

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadMembers(true);
        }
        private void LoadMembers(bool newMember)
        {
            this.pnlMain.Controls.Clear();
            var memberForm = new frmMembers { TopLevel = false, AutoScroll = true, Dock = DockStyle.Fill, newMember = newMember };
            pnlMain.Controls.Add(memberForm);
            memberForm.Show();
        }

        private void entranceMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            var entranceForm  = new frmMain{ TopLevel = false, AutoScroll = true, Dock = DockStyle.Fill };
            pnlMain.Controls.Add(entranceForm);
            entranceForm.Show();
        }

        private void CashierMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
         
            //new HerokoRima.Cashier.frmCashier { TopLevel = false, AutoScroll = true, Dock = DockStyle.Fill };
            //pnlMain.Controls.Add(entranceForm);
            //entranceForm.Show();
        }
    }



}

