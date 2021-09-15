using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now;

            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());


            if (userAge < 0)
            {
                throw new Exception();
            }

            while (userAge > 0)
            {
                try
                {
                    int yearBorn = current.Year - userAge;
                    Console.WriteLine("You were born in {0}", yearBorn);
                   
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("An error occured. Enter your age as whole number (and not a negative).");
                    
                    
                }
                finally
                {
                    Console.ReadLine();
                }
            }

            
           
        }
    }
}
