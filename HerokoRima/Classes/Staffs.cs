using System.Collections.Generic;

using HerokoRima.Wrapper;

namespace HerokoRima.Classes
{
    public class Staffs
    {
        static readonly MakeMakeWrapper wrapper = new MakeMakeWrapper();
        public void SaveStaff()
        {
            wrapper.SaveStaff();
        }

        public List<tStaff> GetStaffsByArea(int areaId)
        {
            return wrapper.GetStaffByArea(areaId);
        }

        public static List<tStaff> GetStaffList()
        {
            return wrapper.getStaffsList();
        }

        public static tStaff GetStaff(int staffId)
        {
          return  wrapper.GetStaff(staffId);
        }
        public void SaveStaff(tStaff staff)
        {
            wrapper.SaveStaff(staff);
        }
        public void SaveStaffArea(tStaffArea staffArea)
        {
            wrapper.SaveStaffArea(staffArea);
        }

        public void DeleteStaffArea(tStaffArea tStaffArea)
        {
            wrapper.DeleteStaffArea(tStaffArea);
        }
    }
}
