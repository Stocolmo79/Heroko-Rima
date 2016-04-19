using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Classes;
using Classes.Classes;

using HerokoRima.Classes;


namespace HerokoRima.Forms
{
    public partial class FrmStaff : Form
    {
        public bool newStaff;

        public tInCharge tInCharge;

        public InCharge inCharge;
        public tStaff tStaff;

        public int searchBy;

        public Staff staff;
        public FrmStaff()
        {
            this.InitializeComponent();
        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {
            inCharge = new InCharge();
            staff = new Staff();
            this.LoadStaff();

            //this.mvClases = MonthViews.LoadMonthView(m);
            List<tInCharge> days;
            switch (searchBy)
            {
                case 1:
                    days = inCharge.GetdaysByParam(1);
                    ViewDays(days);
                    break;
                case 2:
                      days = inCharge.GetdaysByParam(2);
                      ViewDays(days);
                    break;
                case 3:
                    lblEnd.Visible = true;
                    lblStart.Visible = true;
                    dtpEnd.Visible = true;
                    dtpStart.Visible = true;
                    btnSearchDates.Visible = true;
                    break;
                default:
                    break;
            }
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
            lblEnd.Visible = false;
            lblStart.Visible = false;
            dtpEnd.Visible = false;
            dtpStart.Visible = false;
            btnSearchDates.Visible = false;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.newStaff)
            {
                this.tStaff = new tStaff();
                if (this.txtFirstName.Text != "")
                    staff.SaveStaff(PopulateStaff());
            }
            else
            {
                this.PopulateStaff();
                staff.SaveStaff();

            }
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

        private void cmbMonitores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMonitores.SelectedIndex <= 0)
            {
                return;
            }
            var s = (tStaff)this.cmbMonitores.SelectedItem;
            var staffDays = inCharge.GetStaffDays(s.StaffId);
            ViewStaffDays(staffDays);
            txtFirstName.Text = s.Firstname;
            txtLastName.Text = s.Lastname;
            txtPhone.Text = s.Cellphone;
            if (s.Active != null)
            {
                chkActive.Checked = (bool)s.Active;
            }
        }

        private void ViewStaffDays(List<tInCharge> staffDays)
        {
            lvDays.Clear();
            lvDays.View = View.Details;
            lvDays.Columns.Add("Fecha");
            lvDays.Columns.Add("Fecha");
            if (staffDays.Any())
            {
                foreach (var row in staffDays)
                {
                    var item = new ListViewItem { Text = row.Date.ToShortDateString() };

                    item.SubItems.Add(row.tHourType.HourTypeDescription); // 2nd column text

                    lvDays.Items.Add(item);
                }
            }
            foreach (ColumnHeader column in lvDays.Columns)
            {
                column.Width = -2;
            }
        }

        private void ViewDays(List<tInCharge> staffDays)
        {
            lvDays.Clear();
            lvDays.View = View.Details;
            lvDays.Columns.Add("Fecha");
            lvDays.Columns.Add("Tipo");
            lvDays.Columns.Add("Monitor");
            if (staffDays.Any())
            {
                foreach (var row in staffDays)
                {
                    var item = new ListViewItem { Text = row.Date.ToShortDateString() };

                    item.SubItems.Add(row.tHourType.HourTypeDescription); // 2nd column text
                    item.SubItems.Add(row.tStaff.Firstname + " " + row.tStaff.Lastname); // 2nd column text
                    lvDays.Items.Add(item);
                }
            }
            foreach (ColumnHeader column in lvDays.Columns)
            {
                column.Width = -2;
            }
        }

        private void btnSearchDates_Click(object sender, EventArgs e)
        {
          var  days = inCharge.GetdaysBetweenDates(dtpStart.Value,dtpEnd.Value);
            ViewDays(days);

        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            var pattern = new Regex("^[- +()]?[1-9]{1}[0-9]{3,14}$");
            if (pattern.IsMatch(txtPhone.Text))
            {

            }
            else
            {
                txtPhone.Text = "Numero no valido";
            }
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
