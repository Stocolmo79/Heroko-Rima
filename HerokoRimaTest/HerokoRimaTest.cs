
using System.Linq;

using Classes;

using HerokoRima;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HerokoRimaTest
{
    [TestClass]
    public class HerokoRimaTest
    {
        [TestMethod]
        public void GetStaff()
        {
            //Assign
            var context = new MakeMakeEntities();
            //Act
            var staff = context.tStaffs.Select(s => s);
            //Assert
            Assert.AreEqual("Bernardo", staff.First().Firstname);
        }
    }
}
