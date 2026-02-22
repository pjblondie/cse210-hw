using System;

class Program
{
    static void Main(string[] args)
    {
        Word TestWord = new Word("Lehi");
        Console.WriteLine($"{TestWord.SwapText()}");
        TestWord.Hide();
        Console.WriteLine($"{TestWord.SwapText()}");
        Reference TestReference = new Reference("Nephi", 4, 10);
        Reference TestReference2 = new Reference("Nephi", 4, 10, 12);
        Console.WriteLine($"{TestReference.GetDisplayText()}");
        Console.WriteLine($"{TestReference2.GetDisplayText()}");
    }
}