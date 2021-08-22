using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Employee : Person // employee inherits from person class
    {
        public override void SayName() // implement method using override keyword
        {
            Console.WriteLine(firstName + " " + lastName);
            
        }
       

    }
}
