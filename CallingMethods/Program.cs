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

            Console.WriteLine("Input number 1: ");
            math.num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input number 2: ");
            math.num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adding those two numbers together ...");
            Console.WriteLine(math.AddNumbers());
            Console.ReadLine();

            Console.WriteLine("Multiplying those two numbers together ...");
            Console.WriteLine(math.MultNumbers());
            Console.ReadLine();

            Console.WriteLine("Dividing those two numbers ...");
            Console.WriteLine(math.DivideNumbers());
            Console.ReadLine();



        }
    }
}
