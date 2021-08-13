using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            NewClass math = new NewClass();
            Console.WriteLine("Enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Your number " + num1 + " plus ten equals: " );
            Console.WriteLine(math.Addition(num1));
            Console.ReadLine();

            
            NewClass DecMath = new NewClass();
            Console.WriteLine("Enter another number.");

           decimal num2 = Convert.ToDecimal(Console.ReadLine());
          
            Console.WriteLine("Your number " + num2 + " plus eight equals: "  );
            Console.WriteLine(DecMath.Addition(num2));
            Console.ReadLine();

            
            NewClass strMath = new NewClass();
            Console.WriteLine("Now, enter a third number.");
            string num3 = Console.ReadLine();
            
            Console.WriteLine("Your number " + num3 + " plus two equals: ");
            Console.WriteLine(strMath.Addition(num3));
            Console.ReadLine();
        }
    }
}
