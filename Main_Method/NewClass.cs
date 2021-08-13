using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Method
{
    public class NewClass
    {
        public int num1 { get; set; }
        public decimal num2 { get; set; }
        public string num3 { get; set; }


        public int Addition(int num1)
        {
            return num1 + x;
        }
        public int Addition(decimal num2)
        {
            int sum = Convert.ToInt32(num2);
            return sum + y;
        }
        public int Addition(string num3)
        {
            int result = Convert.ToInt32(num3);
            return result + z;
        }
    }
}
