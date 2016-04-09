using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Classes;
using Classes.Wrapper;



namespace HerokoRima.Classes
{
public    class CardTypes
    {
        static readonly MakeMakeWrapper Wrapper = new MakeMakeWrapper();
        public void SaveCardType(tType type)
        {
            Wrapper.SaveType(type);
        }

        public static DbSet<tType> GetCardTypes()
        {
            return Wrapper.GetCardTypes();
        }
        public tType GetCardType(int typeId)
        {
            return Wrapper.GetCardType(typeId);
        }
    }
}
