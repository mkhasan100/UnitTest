using LearnTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class MSTest
    {
        [TestMethod]
        public void Test1()
        {
            SimpleMaths simpleMaths = new SimpleMaths();
            double result = simpleMaths.Add(5, 5);
            Assert.AreEqual(result, 10);
        }


        [TestMethod]
        public void Test2()
        {
            SimpleMaths simpleMaths = new SimpleMaths();
            double result = simpleMaths.Substract(20, 20);
            Assert.AreEqual(0, result);
        }


        [TestMethod]
        public void Test3()
        {
            SimpleMaths simpleMaths = new SimpleMaths();
            double result = simpleMaths.divide(18, 3);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Test4()
        {
            SimpleMaths simpleMaths = new SimpleMaths();
            double result = simpleMaths.Multiply(10, 10);
            Assert.AreEqual(100, result);
        }


    }
}

