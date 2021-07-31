using System;

namespace Car_insurance_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval Program");
            Console.ReadLine();

            Console.WriteLine("What is your age?");
            int Age = Convert.ToInt32(Console.ReadLine()); //user iput age as string and convert to int

            Console.WriteLine("Have you ever had a DUI? Please answer either true or false.");
            bool DUI = Convert.ToBoolean(Console.ReadLine()); //user input true or false and convert to bool

            Console.WriteLine("How many speeding tickets have you had?");
            int Tickets = Convert.ToInt32(Console.ReadLine()); //user input string and convert to int

            Console.WriteLine("Qualified?");
            bool isQualified = (Age > 15 && DUI == false && Tickets < 3); // user must be over 15 years, no DUIs, and less than 3 tickets.
            Console.WriteLine(isQualified);
            Console.ReadLine();
        }
    }
}
