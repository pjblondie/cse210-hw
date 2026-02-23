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
        while (UserInput != "quit")
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Scripture Memorization programm! \n");
            Console.WriteLine(TestScripture.DisplayScripture());
            Console.Write("\nPlease press enter to hide text and 'quit' if you would like to end early: \n");
            UserInput = Console.ReadLine();
            if (TestScripture.FullyHidden() == true)
            {
                break; 
            }
            if (UserInput == "")
            {
                TestScripture.HideWords();
            }
        }
        
    
    
    }
}