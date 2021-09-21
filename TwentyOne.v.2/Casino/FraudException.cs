using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
   public class FraudException : Exception 
    {
        public FraudException()
            : base() { }
        //overloading constructor method
        public FraudException(string Message)
            : base(Message) { }
                         

        
    }
}
