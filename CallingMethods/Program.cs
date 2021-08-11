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
            Console.WriteLine("Input number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adding those two numbers together ..."); 
            SimpleMath.AddNumbers();
            Console.ReadLine();

            Console.WriteLine("Multiplying those two numbers together ...");
            SimpleMath.MultNumbers();
            Console.ReadLine();

            Console.WriteLine("Dividing those two numbers ...");
            SimpleMath.DivideNumbers();
            Console.ReadLine();



        }
    }
}
