using System;

class Program
{
    static void Main(string[] args)
    {

        FinanceManager Finance1 = new FinanceManager();
        Console.Clear();
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Welcome to your personalized Finace Application!");
        Console.WriteLine("---------------------------------------------------");
        Console.Write("     Please press enter to continue: ");
        Console.ReadLine();
        Console.Clear();
        Console.Write("Preparing your finances, please wait...");
        Finance1.Spinner();
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("To begin please select one of the following options: ");
        Console.WriteLine("-------------------------------------------------------");

        Finance1.DisplayMenu();
    }
}