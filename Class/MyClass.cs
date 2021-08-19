using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    public class MyClass
    {

        public void DivMath(int num1) // void method that outputs an integer ... divides data passed to it by 2...
        {
            int result = num1 / 2;
            Console.WriteLine(result);

        }

       
        public void Addition(out int result2) 
        {
            int i = 5;
            result2 = i + i;
            Console.WriteLine( result2);
            Console.ReadLine();

        }

    }
}
