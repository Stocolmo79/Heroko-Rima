using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using Calendar.NET;

using HerokoRima.Classes;



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
         
        }

        private void GetCalendarItems()
        {
            calCalendar.CalendarDate = DateTime.Today;
            calCalendar.CalendarView = CalendarViews.Month;
            calCalendar.AllowEditingEvents = true;
            var classes = Class.GetClasses();
            var cls = Class.GetStaffClasses();
            PlaceItems(cls);
        }

        private void PlaceItems(IEnumerable<tStaffClass> classes)
        {

            foreach (var exerciseEvent in classes.Select(clss => new CustomEvent
                                                                       {
                                                                           Date = clss.tClass.ClassDate,
                                                                           TooltipEnabled = true,

                                                                           EventLengthInHours = Int32.Parse(clss.tClass.EndTime.Substring(0, 2)) - Int32.Parse(clss.tClass.StartTime.Substring(0, 2)),
                                                                           EventText = clss.tStaff.tStaffAreas.FirstOrDefault().tArea.AreaDescription +" " +clss.tStaff.Firstname,
                                                                           EventColor = clss.tStaff.tStaffAreas.FirstOrDefault().tArea.AreaId == 1 ? Color.Gray: Color.OrangeRed
                                                                       }))
            {
                calCalendar.AddEvent(exerciseEvent);
            }
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
                                    ClassDate = new DateTime(dtpClassDate.Value.Year, dtpClassDate.Value.Month, dtpClassDate.Value.Day, Convert.ToInt32(cmbStart.Text.Substring(0,2)),0,0),
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

    }
}
