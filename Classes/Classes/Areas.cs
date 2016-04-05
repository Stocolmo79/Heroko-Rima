using System.Collections.Generic;

using Classes;
using Classes.Wrapper;



namespace HerokoRima.Classes
{ 
   public class Areas
   {
       private readonly MakeMakeWrapper wrapper = new MakeMakeWrapper();
       public List<tArea> GetAreas()
       {
           return wrapper.GetAreas();
       }

      
   }
}
