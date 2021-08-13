using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Method
{
    public class NewClass
    {
       


        public int Addition(int num1)
        {
            return num1 + 10;
        }
        public int Addition(decimal num2)
        {
            int sum = Convert.ToInt32(num2);
            return sum + 8;
        }
        public int Addition(string num3)
        {
            int result = Convert.ToInt32(num3);
            return result + 2;
        }
    }
}
