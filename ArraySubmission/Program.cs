using System;
using System.Collections.Generic;

class Program
    {
        static void Main()
        {

       
        string[] studentNames = { "Bobby", "Susie", "Jimmy", "Sally" }; //string array
        Console.WriteLine("Choose a number between 0 - 3");
        int index = int.Parse(Console.ReadLine()); //user input

        if (index > 4) 
            {
                Console.WriteLine("Sorry, that is not valid. Select between 0-3.");
                Console.ReadLine();
            }
        else 
        {  
            Console.WriteLine("You selected " + studentNames[index]);
            Console.ReadLine();
        }

        
        int[] numArray = { 5, 10, 15, 20 }; //integer array
        Console.WriteLine("Choose another number between 0 - 3");
        int index2 = Convert.ToInt32(Console.ReadLine()); //user input

        if (index2 > 4)
        {
            Console.WriteLine("Sorry, that is not valid. Select between 0-3.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("You selected " + numArray[index2]);
            Console.ReadLine();
        }


        List<string> strPets = new List<string>(); //string list

        strPets.Add("Dog");//0
        strPets.Add("Cat");//1
        strPets.Add("Rabbit");//2
        strPets.Add("Parkeet");//3
        Console.WriteLine("Choose another number between 0 - 3");
        int index3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You selected " + strPets[index3]); //user input
        Console.ReadLine();


    }
    }
