using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass math = new MyClass(); // instantiate the class

            Console.WriteLine("Enter a number."); // user input 
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number divided by 2 equals: ");
            math.DivMath(num1); // call method

            Console.ReadLine();

            MyClass add = new MyClass(); // instantiate another class


            Console.WriteLine("5 plus 5 equals: ");
            add.Addition(out int result2); // call method with out parameter
            Console.ReadLine();

            Console.WriteLine("Now enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            math.DivMath(num2); // is this overloading the method? using it again with different parameter?
            Console.ReadLine();



        }


    }
}
