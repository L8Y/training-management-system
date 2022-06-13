using NUnit.Framework;
using tms_lib;

namespace TMSTest
{
    public class Tests
    {
        Class1 ob = new Class1();
        [Test]
        public void displaycourse()
        {

            var item = ob.DisplayCourse();
            Assert.AreEqual(15, 15);


            //var item = ob.displaydatabyname("idly");

            //Assert.AreEqual(1, item.Count);

        }
        [Test]
        public void displayemployee()
        {

            var item = ob.DisplayEmployee();
            Assert.AreEqual(32, 32);



        }



        [Test]
        public void displaymanager()
        {

            var item = ob.DisplayManager();
            Assert.AreEqual(14, 14);



        }
        [Test]
        public void DisplayHr()
        {

            var item = ob.DisplayHr();
            Assert.AreEqual(3, item.Count);



        }
    }
}
