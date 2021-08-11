using System;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] args)
        {

        try
        {
            List<int> IntList = new List<int>() { 20, 17, 109 };

            Console.WriteLine("Type a number");
            int num1 = Convert.ToInt32(Console.ReadLine()); // user input as string - convert to int

            for (int x = 0; x < IntList.Count; x++) // for loop to iterate through list
            {
                var result = IntList[x] / num1; // math equation for each element of the list
                Console.WriteLine(IntList[x] + " divided by " + num1 + " equals " + result);
            }
            Console.ReadLine();
        }
        catch (DivideByZeroException ex)
        {
            
            Console.WriteLine(ex.Message); // system generated error message
            Console.WriteLine("Please don't divide by zero"); // customer error message
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);// system generated error message
            Console.WriteLine("Please only type a whole number.");// customer error message
        }
        finally
        {
            Console.ReadLine(); // this will run whether there was an exception or not.
        }

        }
    }

