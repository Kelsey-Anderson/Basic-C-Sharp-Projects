﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Employee : Person, IQuittable // employee inherits from person class
    {
        public override void SayName() // implement method using override keyword
        {
            Console.WriteLine(firstName + " " + lastName);
            
        }
        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + " just quit!!!");
           
        }

    }
}
