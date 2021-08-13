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
            return num1 + 10;
        }
        public decimal Addition(decimal num2)
        {
            return num2 + 8;
        }
        public int Addition(string num3)
        {
            int result = Convert.ToInt32(num3);
            return result + 2;
        }
    }
}
