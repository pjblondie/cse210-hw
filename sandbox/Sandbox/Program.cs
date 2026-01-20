using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");
        // Console.WriteLine("Today!");
        // string x;
        // x = "you";
        // Console.WriteLine(x + 5);
        // {
        //     Console.Write("Provide an noun: ");

        //     string noun = Console.ReadLine();

        //     Console.Write("Provide an Adjective: ");

        //     string adjective = Console.ReadLine();

        //     Console.Write("Provide an Verb: ");

        //     string verb = Console.ReadLine();

        //     Console.Write("Provide an place: ");

        //     string place = Console.ReadLine();

        //     Console.Write("Provide an pronoun: ");

        //     string pronoun = Console.ReadLine();

        //     Console.Write("Provide a 2nd adjective: ");

        //     string adjTwo = Console.ReadLine();

        //     Console.Write($"{noun} went to the {place} and {verb} back home, {pronoun} 
        //     thought to themselves 
        //     that it became a big deal to go back to {place}, for without it they felt {adjTwo}");

        int number = 8;
        number = 20;
        number = 0;
        if (number < 10 && number > -10)
        {
            Console.WriteLine($"Your number, {number} is single diget");
        }
        else
        {
            Console.WriteLine("Multi-diget");
        }
        if (number >= 10 || number <= -10)
        {
            Console.WriteLine("Your number is multi-diget");
        }
        else
        {
            Console.WriteLine("Single-Diget");
        }

        //While Loops

        string response = "yes";
        while (response == "yes")
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine()!;
        }
        Console.WriteLine("Done!");

        int final = 11;
        while (final != 0)
        {
            final = final - 1;
            Console.WriteLine($"{final}");
        }
    }





        

        
    
}

// Notes Start here!

