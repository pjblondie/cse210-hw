using System.ComponentModel.DataAnnotations;

class Listing : Activity
{
    private List<string> lPrompt = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    private string RandomPrompt(List<string> lPrompt)
    {
        Random randomList = new Random();
        int prompt = randomList.Next(lPrompt.Count);
        return lPrompt[prompt];
    }
    public void LRun()
    {
        List<string> thoughts = new List<string>();
        Console.WriteLine("");
        string insertPrompt = RandomPrompt(lPrompt);
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($"--- {insertPrompt} ---");
        Console.Write($"Get ready! Starting listing in...");
        NumberCount();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("");
            Console.Write(">   ");
            string thought = Console.ReadLine();
            if (DateTime.Now >= endTime)
            {
                break;
            }
            thoughts.Add(thought);
        }

        int thoughtsLen = thoughts.Count();
        Console.WriteLine($"You listed {thoughtsLen}!");

    }

}