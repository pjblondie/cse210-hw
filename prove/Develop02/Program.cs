using System;

class Program
{
    static void Main(string[] args)
    {

        int running = 1;
        List<string> randomPrompts = new List<string>{ "Is the one thing you used today that your life would feel uncomplete without? Why?",
                "You are given the choice to get something you've been wanting for awhile, but you have to get rid of the thing that brought you the most day today, would you do it?",
                "What is one person who made you feel good today? What did they do?", "How did your attidute change your perception today?",
                "Who is the most important person in your day to day life, what would it feel like without them?"
            };
        while (running == 1)
        {
            //Display Options
            PrintMenu();
            //Take Input
            Console.Write("What would you like to do? ");
            string menu = Console.ReadLine();
            int menuNum = int.Parse(menu);
            try
            {
                menuNum = int.Parse(menu);
            }
            catch (FormatException)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine(" ERROR: Invalid format, please enter a valid number");
                Console.WriteLine("----------------------------------");
            }


            if (menuNum == 1)
            {
                //Provide User with Prompt
                foreach (string prompt in randomPrompts)
                {
                    Console.WriteLine(prompt);
                }
            }
            else if (menuNum == 2)
            {

            }
            else if (menuNum == 3)
            {

            }
            else if (menuNum == 4)
            {

            }
            else if (menuNum == 5)
            {

            }
            else if (menuNum == 6)
            {
                running = 2;
            }
            else
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("ERROR: Invalid format, please enter a valid number");
                Console.WriteLine("----------------------------------");
            }

        }

    }

    static void PrintMenu()
    {
        Console.WriteLine("\n--- Gratitude Journal Entries Program---");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Welcome!");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Please select one of the following options: ");
        Console.WriteLine("----------------------------------");
        Console.WriteLine(" 1. Write");
        Console.WriteLine(" 2. Display");
        Console.WriteLine(" 3. Load");
        Console.WriteLine(" 4. Save");
        Console.WriteLine(" 5. Add prompt");
        Console.WriteLine(" 6. Quit");
        Console.WriteLine("----------------------------------");

    }
}