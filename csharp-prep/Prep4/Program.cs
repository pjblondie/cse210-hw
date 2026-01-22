using System;

class Program
{
    static void Main(string[] args)
    {



        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers type 0 when finished");

        List<int> numbersList;
        numbersList = new List<int>();

        int userNum = -1;
        while (userNum != 0)
        {

            Console.Write("Enter Number: ");
            userNum = int.Parse(Console.ReadLine());
            numbersList.Add(userNum);
        }
        int sumTotal = 0;
        foreach (int num in numbersList)
        {
            sumTotal += num;

        }
        int avrTotal = sumTotal / numbersList.Count;
        int maxNum = numbersList.Max();
        Console.WriteLine($"Your sum total of your numbers is {sumTotal}.");
        Console.WriteLine($"Your average of your numbers is {avrTotal}.");
        Console.WriteLine($"Your highest of your numbers is {maxNum}.");

        
    }
}