using System;
using System.Linq;
using System.Windows.Forms;
using HerokoRima.Classes;
using HerokoRima.Wrapper;

namespace HerokoRima.Forms
{
    public partial class FrmStaff : Form
    {
        public bool newStaff;

      
        public tStaff staff;
     

        public Staffs staffs;
        public FrmStaff()
        {
            this.InitializeComponent();
  
        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {
            this.LoadProfesors();
            //this.mvClases = MonthViews.LoadMonthView(m);
        }

        private void LoadProfesors()
        {
            this.ResetInputFields();
            if (this.newStaff)
            {
                this.cmbProfesores.Enabled = false;
                return;
            }
            cmbProfesores.DataSource = Combobox.LoadComboBoxStaff(0);
            cmbProfesores.DisplayMember = "Firstname";
            cmbProfesores.ValueMember = "Id";

        }

        private void ResetInputFields()
        {
            this.txtFirstName.Text = "";
            this.txtLastName.Text = "";
            this.txtRUT.Text = "";
            this.txtCity.Text = "";
            this.txtAdress.Text = "";
            this.txtPhone.Text = "";
            this.chkBouldering.Checked = false;
            this.chkAcroYoga.Checked = false;
            this.chkYoga.Checked = false;
        }

        

    
        private void cmbProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ResetInputFields();
            if (this.cmbProfesores.SelectedIndex == 0)
            {
                this.grEditStaff.Enabled = false;
                return;
            }
            this.grEditStaff.Enabled = true;

            this.staff = (tStaff)this.cmbProfesores.SelectedItem;

            this.txtFirstName.Text = this.staff.Firstname;
            this.txtLastName.Text = this.staff.Lastname;
            this.txtRUT.Text = this.staff.RUT;
            this.txtCity.Text = this.staff.City;
            this.txtAdress.Text = this.staff.Adress;
            this.txtPhone.Text = this.staff.Phone;

            if (this.staff.tStaffAreas.Count > 0)
            {
                var areas = this.staff.tStaffAreas;
                foreach (var staffArea in areas)
                {
                    switch (staffArea.AreaId)
                    {
                        case 1:
                            this.chkBouldering.Checked = true;
                            break;
                        case 2:
                            this.chkAcroYoga.Checked = true;
                            break;
                        case 3:
                            this.chkYoga.Checked = true;
                            break;
                    }
                }
            }
            if (this.staff.Active != null) this.chkActive.Checked = (bool)this.staff.Active;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.newStaff)
            {
                this.staff = new tStaff();
                if (this.txtFirstName.Text != "" && this.txtRUT.Text != "")
                   staffs.SaveStaff(PopulateStaff());
            }
            this.PopulateStaff();
            staffs.SaveStaff();
            this.newStaff = false;
            this.LoadProfesors();
        }

        private tStaff PopulateStaff()
        {
            staff.Firstname = this.txtFirstName.Text;
            staff.Lastname = this.txtLastName.Text;
            staff.RUT = this.txtRUT.Text;
            staff.City = this.txtCity.Text;
            staff.Adress = this.txtAdress.Text;
            staff.Phone = this.txtPhone.Text;
            staff.Active = this.chkActive.Checked;
            tStaffArea staffArea;
            DeleteStaffArea();
            if (chkBouldering.Checked)
            {
                staffArea = new tStaffArea { AreaId = 1, StaffId = staff.Id };
                staffs.SaveStaffArea(staffArea);
            }

            if (chkAcroYoga.Checked)
            {
                staffArea = new tStaffArea { AreaId = 2, StaffId = staff.Id };
                staffs.SaveStaffArea(staffArea);
            }
            if (!chkYoga.Checked) return staff;

            staffArea = new tStaffArea { AreaId = 3, StaffId = staff.Id };
            staffs.SaveStaffArea(staffArea);
            return staff;
        }

        private void DeleteStaffArea()
        {
            foreach (var tStaffArea in staff.tStaffAreas.ToList())
            {
               staffs.DeleteStaffArea(tStaffArea);
            }
        }
    }
}
