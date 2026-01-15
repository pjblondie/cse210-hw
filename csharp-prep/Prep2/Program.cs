using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        {
            Console.WriteLine("What is your grade percentage?");
            string gradePercent = Console.ReadLine();

            float gradeNum = float.Parse(gradePercent);

            if (gradeNum > 90)
            {
                string letterGrade = ("A");
                Console.WriteLine($"Congrats on your grade of {letterGrade}!");
            }
            else if (gradeNum > 80 && gradeNum < 90)
            {
                string letterGrade = ("B");
                Console.WriteLine($"Congrats on your grade of {letterGrade}!");
            }
            else if (gradeNum > 70 && gradeNum < 80)
            {
                string letterGrade = ("C");
                Console.WriteLine($"Congrats on your grade of {letterGrade}!");
            }
            else if (gradeNum > 60 && gradeNum < 70)
            {
                string letterGrade = ("D");
                Console.WriteLine($"Congrats on your grade of {letterGrade}!");
            }
            else
            {
                string letterGrade = ("F");
                Console.WriteLine($"Oh...I'm sorry you got an {letterGrade}...");
            }
            if (gradeNum > 70)
            {
                Console.WriteLine("You Passed");
            }
            else
            {
                Console.WriteLine("Sorry You Failed, Try harder next time");
            }
        }
    }
}