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

            Console.WriteLine("Fifty plus fifty equals: ");
            Console.WriteLine(StaticClass.number = 100); // this is from a static class
            Console.ReadLine();

            MyClass number = new MyClass();
            number.Addition(25,5);// overloaded method ... ?
            Console.ReadLine();
          


        }


    }
}
