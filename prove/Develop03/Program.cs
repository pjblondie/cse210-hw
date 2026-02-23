using System;

class Program
{
    static void Main(string[] args)
    {

        // TESTS // 
        // Word TestWord = new Word("Lehi");
        // Console.WriteLine($"{TestWord.SwapText()}");
        // TestWord.Hide();
        // Console.WriteLine($"{TestWord.SwapText()}");

        // Reference TestReference = new Reference("Nephi", 4, 10);


        // Console.WriteLine($"{TestReference.GetDisplayText()}");
        // Console.WriteLine($"{TestReference2.GetDisplayText()}");

        // Scripture TestScripture = new Scripture(TestReference, "And it came to pass that I was constrained by the Spirit that I should kill Laban; but I said in my heart: Never at any time have I shed the blood of man. And I shrunk and would that I might not slay him.");
        // Console.WriteLine($"{TestScripture.DisplayScripture()}");


        // TestScripture.HideWords();
        // Console.WriteLine("--- AFTER HIDING 3 WORDS ---");
        // Console.WriteLine(TestScripture.DisplayScripture());
        // TestScripture.HideWords();
        // Console.WriteLine("--- AFTER HIDING 6 WORDS ---");
        // Console.WriteLine(TestScripture.DisplayScripture());
        // TESTS // 

        Reference TestReference = new Reference("Nephi", 4, 10);
        Scripture TestScripture = new Scripture(TestReference, "And it came to pass that I was constrained by the Spirit that I should kill Laban; but I said in my heart: Never at any time have I shed the blood of man. And I shrunk and would that I might not slay him.");
        string UserInput = ("");
        while (UserInput != "quit" && TestScripture.FullyHidden() == false)
        {
            Console.Clear();
            Console.WriteLine(TestScripture.DisplayScripture());
            UserInput = Console.ReadLine();
            if (UserInput == "")
            {
                TestScripture.HideWords();
            }
        }
        Console.Clear();
        Console.WriteLine(TestScripture.DisplayScripture());
    
    
    }
}