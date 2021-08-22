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
         }   
        
        }
   
    }

