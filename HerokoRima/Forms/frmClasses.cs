using System;
using System.Windows.Forms;

using HerokoRima.Classes;

namespace HerokoRima.Forms
{
    public partial class FrmClasses : Form
    {
        public tClass tClass;
        public tArea area;
        public FrmClasses()
        {
            InitializeComponent();
            LoadAreas();
            MonthViews.LoadMonthView(mvClasses);
        }

        private void LoadAreas()
        {
            cmbArea.DataSource = Combobox.LoadComboBoxAreas();
            cmbArea.DisplayMember = "AreaDescription";
            cmbArea.ValueMember = "AreaId";
        }

        private void btnSaveClass_Click(object sender, EventArgs e)
        {
            if (cmbArea.SelectedIndex > 0 || cmbProfessor.SelectedIndex > 0 || cmbStart.SelectedIndex > 0 || cmbEnd.SelectedIndex > 0)
            {
                tClass = new tClass
                                {
                                    MaxAttendance = Int32.Parse(cmbMaxAttendance.Text),
                                    TypeId = area.AreaId,
                                    ClassDate = dtpClassDate.Value,
                                    EndTime = cmbEnd.Text,
                                    StartTime = cmbStart.Text

                                };
                var staff = (tStaff)cmbProfessor.SelectedItem;
                var tStaff = new tStaffClass { StaffId = staff.Id };

                Class.SaveClass(tClass, tStaff);
            }
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArea.SelectedIndex == 0)
            {
                ResetInputs();
            }
            else
            {
                LoadProfessors();
            }
        }

        private void LoadProfessors()
        {
            area = (tArea)cmbArea.SelectedItem;
            cmbProfessor.DataSource = Combobox.LoadComboBoxStaff(area.AreaId);
            cmbProfessor.DisplayMember = "Firstname";
            cmbProfessor.ValueMember = "Id";
        }

        private void ResetInputs()
        {
            //cmbProfessor.SelectedIndex = 0;
            //cmbStart.SelectedIndex = 0;
            //cmbEnd.SelectedIndex = 0;

        }

        private void calClasses_LoadItems(object sender, System.Windows.Forms.Calendar.CalendarLoadEventArgs e)
        {

        }
    }
}
