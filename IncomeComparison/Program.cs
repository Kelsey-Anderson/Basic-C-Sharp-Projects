using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            string Person1;
            Console.WriteLine("Person 1 \n Hourly Rate?");
            int HrRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int totalHours1 = Convert.ToInt32(Console.ReadLine());



            string Person2;
            Console.WriteLine("Person 2 \n  Hourly Rate?");
            int HrRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int totalHours2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual salary of Person 1:");
            int perWeek1 = HrRate1 * totalHours1;
            int annualSal1 = 52 * perWeek1;
            Console.WriteLine(annualSal1);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 2:");
            int perWeek2 = HrRate2 * totalHours2;
            int annualSal2 = 52 * perWeek2;
            Console.WriteLine(annualSal2);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueORfalse = annualSal1 > annualSal2;
            Console.WriteLine(trueORfalse.ToString());
            Console.ReadLine();







        }
    }
}
