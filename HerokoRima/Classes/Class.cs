using System.Collections.Generic;
using System.Data.Entity;

using HerokoRima.Wrapper;



namespace HerokoRima.Classes
{

    public class Class
    {

        private static readonly MakeMakeWrapper wrapper = new MakeMakeWrapper();

        public static void SaveClass(tClass tClass, tStaffClass tStaffClass)
        {
            tStaffClass.ClassId = wrapper.SaveClass(tClass);
            wrapper.SaveStaffClass(tStaffClass);

        }

        public static DbSet<tClass> GetClasses()
        {
            return wrapper.GetClasses();
        }

        public static DbSet<tStaffClass> GetStaffClasses()
        {
            return  wrapper.GetStaffClasses();
        }

    }
}
