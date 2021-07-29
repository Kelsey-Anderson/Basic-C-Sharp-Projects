using System;

class Program
{

    static void Main()
    {
        Console.WriteLine(" The Tech Academy \n Student Daily Report");
        // the /n makes the second part of the string go to the new line.


        Console.WriteLine("What is your name?  ");
        string yourName = Console.ReadLine(); //whatever user writes is assigned to the string variable "yourName"
        Console.WriteLine("Your name is: " + yourName);
        Console.ReadLine();

        Console.WriteLine("What course are you on?  ");
        string yourCourse = Console.ReadLine(); //whatever use writes is assigned to string variable "yourCourse"
        Console.WriteLine("You are on the " + yourCourse + " course.");
        Console.ReadLine();



        Console.WriteLine("What page number are you currently on? ");
        int currentPage = Convert.ToInt32(Console.ReadLine()); //assigning variable with datatype integer and convert the user input string entry to integer
        Console.WriteLine("You are on page number " + currentPage);
        Console.ReadLine();


        Console.WriteLine("Do you need help with anything? Please answer with true or false");
        bool HelpMe = Convert.ToBoolean(Console.ReadLine());//assigning datatype Boolean and converting user input string to boolean
        Console.WriteLine("You answered: " + HelpMe);
        Console.ReadLine();


        Console.WriteLine("Were there any positive experiences you would like to share? Please give specifics. ");
        string posExp = Console.ReadLine();
        Console.WriteLine("Your Answer: " + posExp);
        Console.ReadLine();


        Console.WriteLine("Is there any other feedback you would like to provide? Please be specific. ");
        string yourFeedback = Console.ReadLine();
        Console.WriteLine("Your Feedback is: " + yourFeedback);
        Console.ReadLine();


        Console.WriteLine("How many hours did you study today? ");
        int hoursStudy = Convert.ToInt32(Console.ReadLine()); // if user enters anything other than a number this would throw an error
        Console.WriteLine("You studied " + hoursStudy + " hours today!");
        Console.ReadLine();

        //end of program message
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.ReadLine();
    }
}