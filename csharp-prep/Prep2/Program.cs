using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        {
            Console.WriteLine("What is your grade percentage?");
            string gradePercent = Console.ReadLine();
            int gradeNum = int.Parse(gradePercent);
            Console.WriteLine($"{gradeNum}");
            gradeNum = gradeNum + 3;
            Console.WriteLine($"{gradeNum}");
        }
       
    }
}