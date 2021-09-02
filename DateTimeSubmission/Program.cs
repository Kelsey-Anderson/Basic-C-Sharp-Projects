using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime current = DateTime.Now; //current time.
            Console.WriteLine(current);//print to console.
            Console.ReadLine();

            Console.WriteLine("Please enter a number");//prompt user
            int x = Convert.ToInt32(Console.ReadLine()); //user input convert to int

            TimeSpan later = DateTime.Parse(current) + x;

            Console.WriteLine("In {0} hours, it will be {1}", x, later);
            Console.ReadLine();


        }
    }
}
