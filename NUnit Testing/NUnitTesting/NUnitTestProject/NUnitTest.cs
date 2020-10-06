using NUnit.Framework;
using NUnitTest;
using System.Collections.Generic;

namespace NUnitTestProject
{
    public class NUnitTest
    {
        List<EmployeeDetails> li;

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Checkdetails()
        {
            Program pobj = new Program();
            li = pobj.AllUsers();
            foreach (var x in li)
            {
                Assert.IsNotNull(x.id);
                Assert.IsNotNull(x.Name);
                Assert.IsNotNull(x.Salary);
                Assert.IsNotNull(x.Gender);
            }
        }
        [Test]
        public void TestLogin()
        {
            Program pobj = new Program();
            string x = pobj.Login("Hasan", "1234");
            string y = pobj.Login("", "");
            string z = pobj.Login("Admin", "Admin");
            Assert.AreEqual("Userid or password could not be Empty.", y);
            Assert.AreEqual("Incorrect UserId or Password.", x);
            Assert.AreEqual("Welcome Admin.", z);
        }
        [Test]
        public void getuserdetails()
        {
            Program pobj = new Program();
            var p = pobj.getDetails(100);
            foreach (var x in p)
            {
                Assert.AreEqual(x.id, 100);
                Assert.AreEqual(x.Name, "Hasan");
            }
        }
    }
}