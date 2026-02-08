using System;
using System.Collections.Specialized;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        static void DisplayMessage(string userName)
        {

            Console.WriteLine("Hello_world...");
            Console.WriteLine($"Hello {userName}");

        }
        DisplayMessage("parker");


        static int AddNumbers(int first, int second)
        {
            int sum = first + second;
            Console.WriteLine($"{sum}");
            return sum;
        }
        AddNumbers(2, 3);
    }
}