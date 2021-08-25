using System;

namespace AbstractClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee() {firstName = "Sample",  lastName = "Student"}; //instantiate employee object 

            employee.SayName(); //calling the method on the object.
            Console.ReadLine();


            IQuittable obj = new Employee() { firstName = "Sample", lastName = "Student" }; //polymorphism - create obj of type IQuittable
            obj.Quit(); // call the Quit method
            Console.ReadLine();



            Employee emp1 = new Employee() { ID = 1 };//instantiate Employee objects
            Employee emp2 = new Employee() { ID = 2 };
 

            if (emp1.ID == emp2.ID)
            {
                Console.WriteLine("These are the same ID");
            }
            else if (emp1.ID != emp2.ID)
            {
                Console.WriteLine("These are two different IDs");
            }
                Console.ReadLine();

            
        }   
        
    }
   
}

