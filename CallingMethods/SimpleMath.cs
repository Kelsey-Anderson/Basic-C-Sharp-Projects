using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethods
{
    public class SimpleMath
    {
        public int num1 { get; set; }
        
        public int AddNumbers(int num1) 
        {
            return num1 + 10;
        }
        public int MultNumbers(int num1)
        {
            return num1 * 10;
        }
       public int DivideNumbers(int num1)
        {
            return num1 / 10;
        }
    }
}
