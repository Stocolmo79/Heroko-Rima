using System.Collections.Generic;

using HerokoRima.Wrapper;

namespace HerokoRima.Classes
{
    public class Staffs
    {
        readonly MakeMakeWrapper wrapper = new MakeMakeWrapper();
        public void SaveStaff()
        {
            wrapper.SaveStaff();
        }

        public List<tStaff> GetStaffByArea(int areaId)
        {
            return wrapper.GetStaffByArea(areaId);
        }

        public List<tStaff> GetStaff()
        {
            return wrapper.GetStaff();
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
