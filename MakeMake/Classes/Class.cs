using System.Collections.Generic;
using MakeMake.Wrapper;

namespace MakeMake.Classes
{

    public class Class
    {

        private static readonly MakeMakeWrapper wrapper = new MakeMakeWrapper();

        public static void SaveClass(tClass tClass, tStaffClass tStaffClass)
        {
            tStaffClass.ClassId = wrapper.SaveClass(tClass);
            wrapper.SaveStaffClass(tStaffClass);

        }

        public List<tClass> GetClasses()
        {
            return wrapper.GetClasses();
        }

    }
}
