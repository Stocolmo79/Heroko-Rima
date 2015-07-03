using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;

using HerokoRima.Classes;

using CalendarItem = System.Windows.Forms.Calendar.CalendarItem;

namespace HerokoRima.Forms
{
    public partial class FrmClasses : Form
    {
        List<CalendarItem> calendarItems = new List<CalendarItem>();
        public tClass tClass;
        public tArea area;
        public FrmClasses()
        {
            InitializeComponent();
            LoadAreas();
            GetCalendarItems();
            MonthViews.LoadMonthView(mvClasses);
        }

        private void GetCalendarItems()
        {
                
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
