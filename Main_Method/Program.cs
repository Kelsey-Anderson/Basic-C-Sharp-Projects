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
            math.num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(math.Addition(math.num1));
            Console.ReadLine();

            
            NewClass DecMath = new NewClass();
            Console.WriteLine("Enter another number.");
            DecMath.num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DecMath.Addition(DecMath.num2));
            Console.ReadLine();

            
            NewClass strMath = new NewClass();
            Console.WriteLine("Now, enter a third number.");
            strMath.num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(strMath.Addition(Convert.ToInt32(strMath.num3)));
            Console.ReadLine();
        }
    }
}
