using System;
using System.Linq;
using System.Windows.Forms;

using Classes;
using Classes.Classes;

using HerokoRima.Classes;


namespace HerokoRima.Forms
{
    public partial class FrmStaff : Form
    {
        public bool newStaff;


        public tStaff tStaff;


        public Staff staff;
        public FrmStaff()
        {
            this.InitializeComponent();

        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {
            staff = new Staff();
            this.LoadStaff();
           
            //this.mvClases = MonthViews.LoadMonthView(m);
        }

        private void LoadStaff()
        {
            this.ResetInputFields();
          
                this.cmbMonitores.Enabled = !newStaff;
           
            cmbMonitores.DataSource = Combobox.LoadComboBoxStaff(0);
            cmbMonitores.DisplayMember = "Firstname";
            cmbMonitores.ValueMember = "StaffId";

        }

        private void ResetInputFields()
        {
            this.txtFirstName.Text = "";
            this.txtLastName.Text = "";

            this.txtPhone.Text = "";
        }

        private void cmbProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ResetInputFields();
            if (this.cmbMonitores.SelectedIndex == 0)
            {
                this.grEditStaff.Enabled = false;
                return;
            }
            this.grEditStaff.Enabled = true;

            this.tStaff = (tStaff)this.cmbMonitores.SelectedItem;

            this.txtFirstName.Text = this.tStaff.Firstname;
            this.txtLastName.Text = this.tStaff.Lastname;

            this.txtPhone.Text = this.tStaff.Cellphone;

            //if (this.staff.tStaffAreas.Count > 0)
            //{
            //    var areas = this.staff.tStaffAreas;
            //    foreach (var staffArea in areas)
            //    {
            //        switch (staffArea.AreaId)
            //        {
            //            case 1:
            //                this.chkBouldering.Checked = true;
            //                break;
            //            case 2:
            //                this.chkAcroYoga.Checked = true;
            //                break;
            //            case 3:
            //                this.chkYoga.Checked = true;
            //                break;
            //        }
            //    }
            //}
            if (this.tStaff.Active != null) this.chkActive.Checked = (bool)this.tStaff.Active;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.newStaff)
            {
                this.tStaff = new tStaff();
                if (this.txtFirstName.Text != "" )
                    staff.SaveStaff(PopulateStaff());
            }
            //this.PopulateStaff();
            //staff.SaveStaff();
            this.newStaff = false;
            this.LoadStaff();
        }

        private tStaff PopulateStaff()
        {
            tStaff.Firstname = this.txtFirstName.Text;
            tStaff.Lastname = this.txtLastName.Text;

            tStaff.Cellphone = this.txtPhone.Text;
            tStaff.Active = this.chkActive.Checked;


            return tStaff;
        }

        //private void DeleteStaffArea()
        //{
        //    foreach (var tStaffArea in staff.tStaffAreas.ToList())
        //    {
        //       staffs.DeleteStaffArea(tStaffArea);
        //    }
        //}
    }
}
