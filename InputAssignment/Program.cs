using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number."); //prompts user 

            string text = Console.ReadLine();//user inputs
            File.WriteAllText(@"C:\Users\15419\Documents\GitHub\Basic-C-Sharp-Projects\inputLog.txt", text);// writes the text to a log

            string text2 = File.ReadAllText(@"C:\Users\15419\Documents\GitHub\Basic-C-Sharp-Projects\inputLog.txt");// writes the text to a log
            Console.WriteLine(text2);
            Console.ReadLine();




        }
    }
}
