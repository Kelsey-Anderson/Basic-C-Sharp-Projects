using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass add = new MyClass();
          

            Console.WriteLine("Enter your first number.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            
            try
            {
                Console.WriteLine("Optional: Enter a second number (or, just press ENTER to use the default.)");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Adding together...");
                Console.WriteLine(add.AddingNums(num1, num2));
            }
            catch 
            { 
                Console.WriteLine("The default number is 10 \n Adding ....");
                Console.WriteLine(add.AddingNums(num1));
            }

            Console.ReadLine();

        }
        
    }
}
