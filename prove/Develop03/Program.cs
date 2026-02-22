using System;

class Program
{
    static void Main(string[] args)
    {
        Word TestWord = new Word("Lehi");
        Console.WriteLine($"{TestWord.SwapText()}");
        TestWord.Hide();
        Console.WriteLine($"{TestWord.SwapText()}");
    }
}