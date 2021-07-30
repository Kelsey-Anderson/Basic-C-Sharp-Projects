using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type any number, and this program will multiply it by 50!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = 50;
            int product = num1 * num2;
            Console.WriteLine("Your number times 50 is: " + product);
            Console.ReadLine();

            Console.WriteLine("Type any number and this program will add 25 to it!");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = 25;
            int total = num3 + num4;
            Console.WriteLine("Your number plus 25 is: " + total);
            Console.ReadLine();

            Console.WriteLine("Type any number and this program will divide it by 12.5!");
            int num5 = Convert.ToInt32(Console.ReadLine());
            float num6 = 12.5f;
            float quotient = (float)num5 / num6;
            Console.WriteLine("Your number divided by 12.5 is: " + quotient);
            Console.ReadLine();

            Console.WriteLine("Type a number, and this program will tell you if it's greater than 50!");
            int num7 = Convert.ToInt32(Console.ReadLine());
            bool trueOrFalse = num7 > 50;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

            Console.WriteLine("Type a number, and this program will divide it by 7 and display the remainder!");
            int num8 = Convert.ToInt32(Console.ReadLine());
            int remainder = num8 % 7;
            Console.Write(remainder);
            Console.ReadLine();



        }
    }
}
