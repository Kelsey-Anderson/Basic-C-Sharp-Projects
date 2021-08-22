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

        }
    }
}
