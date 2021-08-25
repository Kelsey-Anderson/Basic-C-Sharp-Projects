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

    //creating employee property ID
        public int ID { get; set; } 



        //adding overloaded operator...

        public static Employee operator == (Employee emp1, Employee emp2)
        {
            
            return emp1.ID == emp2.ID; 
            
        }
        public static Employee operator != (Employee emp1, Employee emp2)
        {
            return emp1.ID != emp2.ID;
            
        }
        
    }
}