using System;
using System.Collections.Generic;
using System.Text;

namespace MethodSubmission
{
    public class MyClass
    {
        public int AddingNums(int num1, string num2, int d)
        {
            int result1 = num1 + d;
            int result2 = num1 + Convert.ToInt32(num2);

            if (num2 == "")
            {
                return result1;
            }
            else
            {
                return result2;
            }
                
        }


    }
}
