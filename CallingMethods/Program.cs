using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)

        {
            SimpleMath math = new SimpleMath();

            Console.WriteLine("Enter a number .. ");
            math.num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Your number is " + math.num1 + "...The second number will be 10... ");
            

            Console.WriteLine("Adding those two numbers together ...");
            Console.WriteLine(math.AddNumbers(math.num1));
            Console.ReadLine();

            Console.WriteLine("Multiplying those two numbers together ...");
            Console.WriteLine(math.MultNumbers(math.num1));
            Console.ReadLine();

            Console.WriteLine("Dividing those two numbers ...");
            Console.WriteLine(math.DivideNumbers(math.num1));
            Console.ReadLine();

        }
    }
}
