using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class MathematicsTesting
    {
        [TestMethod]
        public void TestSumResultAreEqual()
        {
            TestAutomation.MathematicsEx objMath = new TestAutomation.MathematicsEx();
            var result = objMath.Sum(12, 12);
            Assert.AreEqual(24, result);
        }       

        [TestMethod]
        public void TestSumResultAreNotEqual()
        {
            TestAutomation.MathematicsEx objMath = new TestAutomation.MathematicsEx();
            var result = objMath.Sum(12, 12);
            Assert.AreNotEqual(25, result);
        }        

        [TestMethod]
        public void TestSumThrowExceptionWhenZero()
        {
            TestAutomation.MathematicsEx objMath = new TestAutomation.MathematicsEx();
            try
            {
                objMath.Sum(0, 0);
            }
            catch (ArgumentException)
            {
                // logging code will go here
            }
        }        

        [TestMethod]
        public void TestSumThrowExceptionWhenNegative()
        {
            TestAutomation.MathematicsEx objMath = new TestAutomation.MathematicsEx();
            try
            {
                objMath.Sum(-123, -456);
            }
            catch (ArgumentException)
            {
                // logging code will go here
            }
        }
    }
}