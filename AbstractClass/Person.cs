using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
   public abstract class Person //abstract class
    {
        public string firstName { get; set; } // properties
        public string lastName { get; set; }

        public abstract void SayName(); //abstract method
       

    }
}
