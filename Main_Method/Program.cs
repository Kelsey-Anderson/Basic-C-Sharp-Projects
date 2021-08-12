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

            math.num1 = 20;

            Console.WriteLine(math.Addition(math.num1));
            Console.ReadLine();

            NewClass DecMath = new NewClass();

            DecMath.num2 = 40;

            Console.WriteLine(DecMath.Addition(DecMath.num2));
            Console.ReadLine();

            NewClass strMath = new NewClass();

            strMath.num3 = "seven";

            Console.WriteLine(strMath.Addition(Convert.ToInt32(strMath.num3)));
            Console.ReadLine();
        }
    }
}
