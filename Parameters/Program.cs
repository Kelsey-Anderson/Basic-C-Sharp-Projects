using System;
using System.Collections.Generic;


namespace Parameters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //instantiate generic list with string type:
            Employee<string> objList = new Employee<string>();
            objList.Things = new List<string> { "stuff", "items", "crap", "miscellaneous" };

            //instantiate generic list with int type:
            Employee<int> objList2 = new Employee<int>();
            objList2.Things = new List<int> { 5, 10, 15, 20 };

            foreach (string item in objList.Things)
            {
                Console.WriteLine(item);
            }
           
            foreach (int item2 in objList2.Things)
            {
                Console.WriteLine(item2);
            }
            
            Console.ReadLine();


        }
    }
}
