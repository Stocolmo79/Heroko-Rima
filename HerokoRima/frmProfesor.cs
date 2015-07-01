
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using WindowsFormsCalendar;
using HerokoRima.Classes;

namespace HerokoRima
{
    public partial class FrmProfesor : Form
    {
        public List<tStaff> list;
        public FrmProfesor()
        {
            InitializeComponent();
        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {
            this.LoadComboBox();
        }

        public void LoadComboBox()
        {

            list = new List<tStaff>();
            using (var ctx = new MakeMakeEntities())
            {
                list = ctx.tStaffs.Select(m => m).ToList();
            }
      
            //add new item to the comboBox (on index 0; on top):
            AddItem(list, typeof(tStaff), "Id", "Firstname", "<Porfavor seleccione un profesor>");

            //bind the generic list:
            cmbProfesores.DataSource = list;
            cmbProfesores.DisplayMember = "Firstname";
            cmbProfesores.ValueMember = "Id";

        }

        private void calClases_LoadItems(object sender, CalendarLoadEventArgs e)
        {

        }

        private void mwClases_SelectionChanged(object sender, EventArgs e)
        {

        }

        private static void AddItem(IList<tStaff> list, Type type, string valueMember, string displayMember, string displayText)
        {
            var obj = Activator.CreateInstance(type);
            var displayProperty = type.GetProperty(displayMember);
            displayProperty.SetValue(obj, displayText, null);
            var valueProperty = type.GetProperty(valueMember);
            valueProperty.SetValue(obj, -1, null);
            list.Insert(0, obj as tStaff);
        }


    }
}
