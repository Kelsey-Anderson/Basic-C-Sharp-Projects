﻿using System;
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
            int result; // declaring this variable so the num1 math works?

            Console.WriteLine("Enter your first number."); // user input 
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number.");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The method will multiply the first number by itself \nand displays the second number.");
            Console.WriteLine(math.MultMath(num1, num2)); //call method, passing in the user input numbers but there's an error??

            Console.ReadLine();


        }
    }
}
