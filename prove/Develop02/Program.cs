using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        while (true)
        {
            Thread.Sleep(800);
            Console.Clear();
            journal.PrintMenu();
            Console.Write("What would you like to do? ");
            string menu = Console.ReadLine();
            int menuNum;
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
            menuNum = int.Parse(menu);
            if (menuNum == 1)
            {
                journal.JRun();
            }
            else if (menuNum == 2)
            {
                journal.Display();
            }
            else if (menuNum == 3)
            {
                journal.Load();
            }
            else if (menuNum == 4)
            {
                journal.Save();
            }
            else if (menuNum == 5)
            {
                journal.AddPrompt();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Thank you for using the Journal Program we look forward to seeing you next time");
                break;

            }
            

        }
    }
}