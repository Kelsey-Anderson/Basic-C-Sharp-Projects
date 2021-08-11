using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethods
{
    public class SimpleMath
    {
        public SimpleMath() 
        {
            AddNumbers(num1 + num2);
            MultNumbers(num1 * num2);
            DivideNumbers(num1 / num2);
        }
        public int AddNumbers { get; set; }
        public int MultNumbers { get; set; }
        public int DivideNumbers { get; set; }
       
    }
}
