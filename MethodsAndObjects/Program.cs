using System;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee = new Employee() { FirstName = "Sample ", LastName = "Student" };// instantiate & initialize object

            Employee.SayName(); //superclass SayName called on the object Employee
            Console.ReadLine();

        }
    }
}
