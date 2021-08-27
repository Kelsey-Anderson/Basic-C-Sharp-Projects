using System;

namespace DaysOfTheWeek
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the current day of the week \n(Please capitalize first letter)");//prompt user

                Days.Weekday today = (Days.Weekday)Enum.Parse(typeof(Days.Weekday), Console.ReadLine()); //assign value to variable of enum data type

                Console.WriteLine("Today is " + today);
                Console.ReadLine();
        }
            catch (System.ArgumentException ex) 
            {
                Console.WriteLine(ex.Message);//system generated error message
                Console.WriteLine("Please enter an actual day of the week. Remember to capitalize first letter.");
            }
            finally
            {
                Console.ReadLine();
            }






    }
    }
}
