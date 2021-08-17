using System;
using System.Collections.Generic;
using System.Text;

namespace MethodClass
{
    public class MyClass
    {
        public static void  MultMath(int num1, int num2) //void method that takes 2 int parameters ... 
        {
            //return num1 + num1;  <--it doesn't let me use this?

           int result = num1 * num1; // math function on the first int parameter ... I don't think this is right... ?
            Console.WriteLine(num2); // display the second int parameter
            Console.ReadLine();
        }
    }
}
