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

            Console.WriteLine("Optional: Enter a second number (or, just press ENTER to use the default.)");
            int num2 = Convert.ToInt32(Console.ReadLine());

            add = AddingNums(add, 10); 

            Console.WriteLine("Adding together...");


            public static MyClass AddingNums(MyClass num2, int d = 10);

                  
                if (num2 > 0)
                {
                    
                    Console.WriteLine(add.AddingNums(num1, num2));
                }
                if (num2 < 1)
                {
                
                Console.WriteLine(AddingNums(add));
                }


            Console.ReadLine();

        }
        
    }
}
