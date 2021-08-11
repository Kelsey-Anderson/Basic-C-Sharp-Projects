using System;

    class Program
    {
        static void Main(string[] args)
        {
        try
        {
            Console.WriteLine("Pick a number");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another number");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two ....");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            Console.ReadLine();
        }
        catch (FormatException ex) //catches format exceptsion only ... "ex" is the variable datatype = exception
        {
            Console.WriteLine("Please type a whole number"); //writes error to the screen
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero");
           // return; 
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);//general exception .. prints whatever system exception is.
        }
        finally // will run no matter what, exception or not
        {
            Console.ReadLine();
        }
           
    }
        
    }

