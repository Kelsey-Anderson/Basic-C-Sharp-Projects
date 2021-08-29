using System;

namespace StructAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Number number = new Number() { Amount = 108 }; // create object of data type Number, assign it an amount.

          
            Console.WriteLine(number.Amount);
            Console.ReadLine();

        }
    }
}
