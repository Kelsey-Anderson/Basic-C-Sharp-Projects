using System;
using System.Collections.Generic;
using System.Text;

namespace MethodClass
{
    public class MyClass
    {
        public int num1 { get; set; }


        public void  MultiMath(int num1, int num2) //void method that takes 2 int parameters ... 
        {
            int result = num1 + 10;// math on the first int parameter ... 
            Console.WriteLine(result); 
            Console.WriteLine(num2); // display the second int parameter

    }
}
}
