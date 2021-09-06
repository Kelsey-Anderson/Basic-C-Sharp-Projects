using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string constName = "Kelsey"; //create const variable
            const int constID = 100;

            var newPerson = new Person(200, "Bob"); //create variable with keyword var

            Person mePerson = new Person(constID, constName);


            Console.WriteLine("The new person's name is {0}, and their ID is {1}", newPerson.Name, newPerson.id);
            Console.WriteLine("My name is {0}, and my ID is {1}", constName, constID);

            Console.ReadLine();

        }
    }
}
