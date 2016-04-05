using System.Collections.Generic;

using Classes;
using Classes.Wrapper;



namespace HerokoRima.Classes
{
    public class Staffs
    {
        static readonly MakeMakeWrapper Wrapper = new MakeMakeWrapper();
        public void SaveStaff()
        {
            Wrapper.SaveStaff();
        }

        public List<tStaff> GetStaffsByArea(int areaId)
        {
            return Wrapper.GetStaffByArea(areaId);
        }

        public static List<tStaff> GetStaffList()
        {
            return Wrapper.GetStaffsList();
        }

        public void SaveStaff(tStaff staff)
        {
            Wrapper.SaveStaff(staff);
        }
        public void SaveStaffArea(tStaffArea staffArea)
        {
            Wrapper.SaveStaffArea(staffArea);
        }

        public void DeleteStaffArea(tStaffArea tStaffArea)
        {
            Wrapper.DeleteStaffArea(tStaffArea);
        }
    }
}
