using System;

namespace doWhileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine()); //user inpurt string, converts to int
            bool isGuessed = number == 12; // this is the secret number 

            do
            {
                switch (number) // swtich statement
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number"); // if user guessed this case, they will get another chance to guess again.
                        number = Convert.ToInt32(Console.ReadLine());
                        break; 
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number");// if user guessed this case, they will get another chance to guess again.
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number");// if user guessed this case, they will get another chance to guess again.
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed the number 12. That is correct!");
                        isGuessed = true; // changed the bool to true
                        break;
                    default: // use if user input something that wasn't used in a case 
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number");// user will get another chance to guess again.
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed); // run while the bool is false
            Console.ReadLine();
        }
    }
}
