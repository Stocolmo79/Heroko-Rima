using System;
using System.Linq;
using System.Windows.Forms;

using Cashier;

using Classes;
using Classes.Classes;

using HerokoRimaEntrada;

using Members;

namespace HerokoRima.Forms
{
    public partial class FrmMain : Form
    {
        public tStaff staff;

        public enum SearchBy
        {
            Week = 1,
            Month = 2,
            Choose = 3
        }

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
            var entranceForm = new frmEntrance { TopLevel = false, AutoScroll = true, Dock = DockStyle.Fill };
            pnlMain.Controls.Add(entranceForm);
            entranceForm.Show();
        }

        private void CashierMenuItem_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            var cashierForm = new frmCashier { TopLevel = false, AutoScroll = true, Dock = DockStyle.Fill };
            pnlMain.Controls.Add(cashierForm);
            cashierForm.Show();

        }



        private void nuevaClaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadClasses();
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

        private void LoadStaff(bool newStaff)
        {
            this.pnlMain.Controls.Clear();
            var staffForm = new FrmStaff { TopLevel = false, AutoScroll = true, Dock = DockStyle.Fill, newStaff = newStaff };
            this.pnlMain.Controls.Add(staffForm);
            staffForm.Show();
        }

        private void LoadClasses()
        {
            pnlMain.Controls.Clear();
            var classForm = new FrmClasses() { TopLevel = false, AutoScroll = true, Dock = DockStyle.Fill };
            pnlMain.Controls.Add(classForm);
            classForm.Show();
        }

        private void newStaffMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadStaff(true);
        }

        private void staffMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadStaff(false);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (staff != null)
            {
                return;
            }
            using (var loginForm = new frmLogin { TopLevel =     true, AutoScroll = true, Dock = DockStyle.Fill })
            {
                loginForm.ShowDialog();

                staff = loginForm.tStaff;
                if (staff != null)
                {
                     this.Text = "Empresa - Administración - Monitor " + (GetTime() > 0 ? "Tarde: " : "Dia: ")  +staff.Firstname; 
                }
              
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var loginForm = new frmLogin { TopLevel = true, AutoScroll = true, Dock = DockStyle.Fill })
            {
                loginForm.ShowDialog();
                staff = loginForm.tStaff;
                this.Text = "Empresa - Administración - Monitor " + (GetTime() > 0 ? "Tarde: " : "Dia: ") + staff.Firstname;
            }
        }
        private static int GetTime()
        {
            var dt = DateTime.Now;
            var t2 = Convert.ToDateTime("16:00:00");
            var i = DateTime.Compare(dt, t2);
            return i;
        }

        private void weekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStaffForm((int)SearchBy.Week);
        }

        private void ShowStaffForm(int param)
        {
            this.pnlMain.Controls.Clear();
            var staffForm = new FrmStaff
                                {
                                    TopLevel = false,
                                    AutoScroll = true,
                                    Dock = DockStyle.Fill,
                                    searchBy = param 
                                };
            this.pnlMain.Controls.Add(staffForm);
            staffForm.Show();
        }

        private void monthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStaffForm((int)SearchBy.Month);
        }

        private void chooseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStaffForm((int)SearchBy.Choose);
        }

        private void closeCashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Esta seguro que quiere cerrar la caja?", "Cerrar caja", MessageBoxButtons.YesNo);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    this.pnlMain.Controls.Clear();
                   var endDayForm = new frmEndDay
                                {
                                    TopLevel = false,
                                    AutoScroll = true,
                                    Dock = DockStyle.Fill
                                  
                                };
                   this.pnlMain.Controls.Add(endDayForm);
                   endDayForm.Show();
                    break;
                case DialogResult.No:
                    //do something else
                    break;
            }
        }
    }



}

