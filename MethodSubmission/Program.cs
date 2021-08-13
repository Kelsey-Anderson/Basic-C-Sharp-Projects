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
            add.num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Optional: Enter a second number (or, just press ENTER to use the default.)");
            add.num2 = Convert.ToInt32(Console.ReadLine());

            int defaultNUM = 0;

             MyClass optional(MyClass add, out int defaultNUM, int opt = 1)
            {

            }
        




        }
    }
}
