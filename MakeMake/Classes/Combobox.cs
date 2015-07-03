using System;
using System.Collections.Generic;

using HerokoRima.Classes;


namespace MakeMake.Classes
{
  public  class Combobox
    {
      public static List<tStaff> staffList;
      public static List<tArea> areaList;
      public static Staffs staffs = new Staffs();
      public static Areas areas = new Areas();
      public static List<tStaff> LoadComboBoxStaff(int areaId)
      {
          staffList = areaId == 0 ? new List<tStaff>(staffs.GetStaff()) : new List<tStaff>(staffs.GetStaffByArea(areaId));
        
          //add new item to the comboBox (on index 0; on top):
          AddItemsStaff(staffList, typeof(tStaff), "Id", "Firstname", "<Porfavor seleccione un profesor>");

          //bind the generic list:
          return staffList;
      }

      public static void AddItemsStaff(IList<tStaff> list, Type type, string valueMember, string displayMember, string displayText)
        {
            var obj = Activator.CreateInstance(type);
            var displayProperty = type.GetProperty(displayMember);
            displayProperty.SetValue(obj, displayText, null);
            var valueProperty = type.GetProperty(valueMember);
            valueProperty.SetValue(obj, -1, null);
            list.Insert(0, obj as tStaff);
        }

        public static List<tArea> LoadComboBoxAreas()
      {
          areaList = new List<tArea>(areas.GetAreas());
          //add new item to the comboBox (on index 0; on top):
          AddItemsAreas(areaList, typeof(tArea), "AreaId", "AreaDescription", "<Porfavor seleccione un area>");

          //bind the generic list:
          return areaList;
      }

      public static void AddItemsAreas(IList<tArea> list, Type type, string valueMember, string displayMember, string displayText)
        {
            var obj = Activator.CreateInstance(type);
            var displayProperty = type.GetProperty(displayMember);
            displayProperty.SetValue(obj, displayText, null);
            var valueProperty = type.GetProperty(valueMember);
            valueProperty.SetValue(obj, -1, null);
            list.Insert(0, obj as tArea);
        }
    }
    }


