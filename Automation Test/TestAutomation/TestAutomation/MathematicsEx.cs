using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomation
{
    public class MathematicsEx
    {
        public int Sum(int num1, int num2)
        {
            if (num1 <= 0 && num2 <= 0)
            {
                throw new ArgumentException("No Zero or Negative are allowed");
            }
            else
            {
                return num1 + num2;
            }
        }
    }
}
