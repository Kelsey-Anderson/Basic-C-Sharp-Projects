using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethods
{
    public class SimpleMath
    {
        public int num1 { get; set; }
        
        

        public int AddNumbers(int x) 
        {
            return num1 + x;
        }
        public int MultNumbers(int x)
        {
            return num1 * x;
        }
       public int DivideNumbers(int x)
        {
            return num1 / x;
        }
    }
}
