using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass math = new MyClass(); // instantiate the class
          

            Console.WriteLine("Enter your first number."); // user input 
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number.");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The method will multiply the first number by itself \nand displays the second number.");


            Console.WriteLine(math.num1); //call method
            Console.WriteLine(math.num2);

            Console.ReadLine();


        }
    }
}
