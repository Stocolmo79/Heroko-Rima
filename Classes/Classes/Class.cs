using Classes.Wrapper;
using System.Data.Entity;

namespace Classes.Classes
{

    public class Class
    {

        private static readonly MakeMakeWrapper Wrapper = new MakeMakeWrapper();

        public static void SaveClass(tClass tClass, tStaffClass tStaffClass)
        {
            tStaffClass.ClassId = Wrapper.SaveClass(tClass);
            Wrapper.SaveStaffClass(tStaffClass);

        }

        public static DbSet<tClass> GetClasses()
        {
            return Wrapper.GetClasses();
        }

        public static DbSet<tStaffClass> GetStaffClasses()
        {
            return  Wrapper.GetStaffClasses();
        }

    }
}
