using System;
using Xunit;
using XunitTesting;
using XUnitTestProject;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange  
            Maths m = new Maths();

            // Act  
            double result = m.Add(2.9, 3.1);

            //Assert  
            Assert.Equal(6, result);
        }

        [Fact]
        public void Test2()
        {
            // Arrange  
            Maths m = new Maths();

            // Act  
            double result = m.Subtract(100, 50);

            //Assert  
            Assert.Equal(50, result);
        }

        [Fact]
        public void Test3()
        {
            // Arrange  
            Maths m = new Maths();

            // Act  
            double result = m.Multiply(10, 10);

            //Assert  
            Assert.Equal(100, result);
        }

        [Fact]
        public void Task_Divide_TwoNumber()
        {
            // Arrange  
            Maths m = new Maths();

            // Act  
            double result = m.Divide(30, 5);

            //Assert  
            Assert.Equal(6, result);
        }
    }
}