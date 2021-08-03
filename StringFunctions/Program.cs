using System;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Kelsey";
            //string quote = "the man said \"Hello, Kelsey.\" \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = @"C:\Users\Kelsey"; //the escape characters aren't needed because the @ is at beginning

            //bool trueOrFalse = name.Contains("s");

            //int Length = name.Length;

            //name = name.ToUpper(); // makes uppercase

            //name = name.ToLower(); //lowercase


            //Console.WriteLine(quote);
            //Console.WriteLine(fileName);
            //Console.WriteLine(trueOrFalse);
            //Console.WriteLine(Length);
            //Console.ReadLine();

            //string name = "Jesse";
            //name = "Joe";

            //Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");

            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
