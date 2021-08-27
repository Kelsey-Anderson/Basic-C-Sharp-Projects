using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Employee<T> : Person, IQuittable // employee inherits from person class // <T> is generic type parameter
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

        //generic list property
        public List<T> Things { get; set; }


        //adding overloaded operator...

        public static bool operator == (Employee emp1, Employee emp2)
        {
            
            return emp1.ID == emp2.ID; 
            
        }
        public static bool operator != (Employee emp1, Employee emp2)
        {
            return emp1.ID != emp2.ID;
            
        }
        
    }
}
