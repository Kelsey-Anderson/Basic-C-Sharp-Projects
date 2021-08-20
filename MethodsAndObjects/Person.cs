using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsAndObjects
{
    public class Person
    {
        public string FirstName { get; set; }//properties
        public string LastName { get; set; }

        public void SayName()//void method
        {

            Console.WriteLine("Name: " + FirstName + LastName);
        }

    }
}
