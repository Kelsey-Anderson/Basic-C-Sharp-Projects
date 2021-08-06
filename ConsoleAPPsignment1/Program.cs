using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {   
            ///////////////////////////
            //Console App Part One////
            //////////////////////////
            string[] faveFoods = { "Pizza-", "Hamburger-", "Chicken Nugget-", "Pineapple-"}; // array of strings
        
            Console.WriteLine("Write a verb ending in ing"); // ask user to input some text
            string userVerb = Console.ReadLine(); // user input a VERB
        
            for (int v = 0; v < faveFoods.Length; v++) //iterate through
                {
                    Console.WriteLine(faveFoods[v] + userVerb);
                }
                    Console.ReadLine();

            //////////////////////////
            //Console App Part Two //
            /////////////////////////
        

            //infinite loop
            //int i = 0;
            //while (i < 5)
            //{
            //    Console.Write("This is an infinite loop!");
            //}

            //Here it is fixed:

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("This will print a few times.");
                i++; // after each iteration, increase the variable by 1

                if (i >5)
                {
                    break;
                }
            }
                Console.ReadLine();

            ///////////////////////////
            //Console App Part Three///
            ///////////////////////////

            int m = 0;
        
            while (m < 10)
            {
                Console.WriteLine(m);
                m++;

                if (m > 3)
                    {
                        break;
                    }
               }
                Console.ReadLine();

            int x = 4;

            while (x <=10)
                {
                    Console.WriteLine(x); 
                    x++;
                }
                Console.ReadLine();

            /////////////////////////
            //Console App Part Four//
            /////////////////////////

            List<string> animals = new List<string>() { "dog", "cat", "bird", "chicken" };

            Console.WriteLine("Type a name of an animal to search the list.");
            string userInput = Console.ReadLine();
            int z = animals.IndexOf(userInput);

            foreach (string name in animals)
            {
                if (animals[0] == userInput)
                {
                    Console.WriteLine(z);
                    break;
                }
                if (animals[1] == userInput)
                {
                    Console.WriteLine(z);
                    break;

                }

                if (animals[2] == userInput)
                {
                    Console.WriteLine(z);
                    break;

                }
                if (animals[3] == userInput)
                {
                    Console.WriteLine(z);
                    break;

                }

                else
                {
                    Console.WriteLine("That isn't on the list.");
                    break;
                }
            }
                    Console.ReadLine();


            //////////////////////////
            //Console App Part Five //
            ////////////////////////

            List<string> studentNames = new List<string>() { "Billy", "Billy", "Susie", "Charlie" };
            Console.WriteLine("Type a student's name.");
            string userSearch = Console.ReadLine();
            int nameIndex = studentNames.IndexOf(userSearch);
          
          
                foreach (string student in studentNames)
                    {
                        if (studentNames[0] == userSearch)
                        {
                            Console.WriteLine(nameIndex);
                            continue;
                        }
                        if (studentNames[1] == userSearch)
                        {
                            Console.WriteLine(nameIndex);
                            continue;
                        }
                        if (studentNames[2] == userSearch)
                        {
                            Console.WriteLine(nameIndex);
                            continue;
                         }
                        if (studentNames[3] == userSearch)
                        {
                            Console.WriteLine(nameIndex);
                            continue;
                        }

                        else
                        {
                            Console.WriteLine("You selected a name that isn't on the list.");
                            break;
                        }       
                    }
                    Console.ReadLine();


             ////////////////////////
            //Console App Part Six//
            ///////////////////////
        
            ////now that I read the requirements of this part of the assignment, 
            ///I am very sure the previous part four and five I have approached wrong! 
            ///I need some guidance/direction on where iI'm going wrong  :( 
                




    }
}

  














