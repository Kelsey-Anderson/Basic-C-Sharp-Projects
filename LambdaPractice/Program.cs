using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Employees> employeeList = new List<Employees>() ; //instantiate a list
            Employees emp1 = new Employees{ firstName = "Joe", lastName = "Jones", ID = 1 }; 
            Employees emp2 = new Employees { firstName = "Joe", lastName = "Anderson", ID = 2 };
            Employees emp3 = new Employees { firstName = "Sally", lastName = "Sand", ID = 3 };
            Employees emp4 = new Employees { firstName = "Matt", lastName = "Matthews", ID = 4 };
            Employees emp5 = new Employees { firstName = "Duke", lastName = "Fluke", ID = 5 };
            Employees emp6 = new Employees { firstName = "Jan", lastName = "Pink", ID = 6 };
            Employees emp7 = new Employees { firstName = "Billy", lastName = "Harris", ID = 7 };
            Employees emp8 = new Employees { firstName = "Hank", lastName = "Hill", ID = 8 };
            Employees emp9 = new Employees { firstName = "Anne", lastName = "Johnson", ID = 9 };
            Employees emp10 = new Employees { firstName = "Sue", lastName = "Adams", ID = 10 };

            employeeList.Add(emp1); // add to list
            employeeList.Add(emp2);
            employeeList.Add(emp3);
            employeeList.Add(emp4);
            employeeList.Add(emp5);
            employeeList.Add(emp6);
            employeeList.Add(emp7);
            employeeList.Add(emp8);
            employeeList.Add(emp9);
            employeeList.Add(emp10);

            
            foreach (Employees joe in employeeList) //foreach loop
            {
                if (joe.firstName == "Joe")
                {
                    List<Employees> joeList = new List<Employees>(); //create a new list of all employees with the first name “Joe”
                    joeList.Add(joe);
                    Console.WriteLine(joe.firstName);
                }
            }
            Console.ReadLine();


            //********************************************
            // using Lambda expressions
            //********************************************

            List<Employees> newLambdaList = employeeList.Where(x => x.firstName == "Joe").ToList(); //create a new list of all employees with the first name “Joe”
            foreach (Employees lambdaJoe in newLambdaList)
            {
                Console.WriteLine(lambdaJoe.firstName);
            }
            Console.ReadLine();


            List<Employees> idOver5 = employeeList.Where(y => y.ID > 5).ToList(); //list of all employees with an Id number greater than 5
            foreach (Employees id5 in idOver5)
            {
                Console.WriteLine(id5.firstName);
            }
            Console.ReadLine();

        }
    }
}
