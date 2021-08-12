using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethods
{
    public class SimpleMath
    {
        public int num1 { get; set; }
        
        

        public int AddNumbers() 
        {
            return num1 + 10;
        }
        public int MultNumbers()
        {
            return num1 * 10;
        }
       public int DivideNumbers()
        {
            return num1 / 10;
        }
    }
}
