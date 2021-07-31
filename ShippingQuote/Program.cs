using System;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");

            Console.WriteLine("Package weight?");
            int pkgWeight = Convert.ToInt32(Console.ReadLine()); //user input string converts to int
            if (pkgWeight > 50) //pkg must be less than 50 or program will end.
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return; // ends the program if "true" 
            }

            //if weight is less than 50, program will continue:

            Console.WriteLine("Package width?");
            int pkgWidth = Convert.ToInt32(Console.ReadLine());//user input string converts to int

            Console.WriteLine("Package height?");
            int pkgHeight = Convert.ToInt32(Console.ReadLine());//user input string converts to int

            Console.WriteLine("Package length?");
            int pkgLength = Convert.ToInt32(Console.ReadLine());//user input string converts to int

            int totalDims = pkgWidth + pkgHeight + pkgLength; 

            if (totalDims > 50) //pkg dims must be less than 50 or program will end.
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return; // ends the program if "true"
            }
            else //pkg dims are less than 50
            {

                int productDims = (pkgWidth * pkgHeight * pkgLength) * pkgWeight; //does the math
                int quote = productDims / 100; //estimates quote amount

                Console.WriteLine("Your estimated total for shipping this package is: $" + quote + " \n Thank You!");
                Console.ReadLine();
            }




        }
    }
}
