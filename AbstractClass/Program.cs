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


            //instantiating 2 employee objects, using ids ..
            Employee id100 = new Employee() { firstName = "Kelsey", lastName = "Student" };
            Employee id200 = new Employee() { firstName = "Billy", lastName = "Student" };

            if (id100.lastName == id200.lastName) // do they have same last name?
            {
                Console.WriteLine("Kelsey and Billy have the same last name, " + id100.lastName);
                
            }
            Console.ReadLine();


         }   
        
        }
   
    }

