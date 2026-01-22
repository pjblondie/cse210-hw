using System;
using System.Diagnostics;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");


        Random randomGen = new Random();
        int magicNum = randomGen.Next(1, 101);

        Console.WriteLine("Welcome to the random number guessing game! It is from 0-100 best of luck guessing!");
    
        while (magicNum != 1)
        {

            Console.Write("What is your guess? ");
            string numberGuess = Console.ReadLine();
            int numGuess = int.Parse(numberGuess);
            if (numGuess == magicNum)
            {
                Console.WriteLine("You guessed it!");
                magicNum = 1;

            }
            else if (numGuess > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }

        }
    }
}