using System.Net;

class Reflection : Activity
{
    private List<string> rPrompt = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
    private List<string> rQuestions = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };
    public Reflection() : base("Reflection",
    "This activity will help you reflect on times in your life when you have shown strength and resilience. \n This will help you recognize the power you have and how you can use it in other aspects of your life.")
    { }

    private string RandomPrompt(List<string> rPrompt)
    {
        Random randomList = new Random();
        int prompt = randomList.Next(rPrompt.Count);
        return rPrompt[prompt];
    }
    private string RandomQ(List<string> rQuestions)
    {
        if (rQuestions.Count == 0)
        {
            return "No more questions avaliable for this setting";
        }
        Random randomList = new Random();
        int index = randomList.Next(rQuestions.Count);
        string question = rQuestions[index];
        rQuestions.RemoveAt(index);
        return question;
    }
    
   public void RRun()
    {
        
        string insertPrompt = RandomPrompt(rPrompt);
        List<string> tempQuestions = new List<string>(rQuestions);
        Console.WriteLine("Consider the following Prompt: ");
        Console.WriteLine($"--- {insertPrompt} ---");
        Console.Write("Press Enter to Continue: ");
        Console.ReadLine();
        
        int durationTwo = _duration;
        while (durationTwo > 0)
        {
            string insertQ = RandomQ(tempQuestions);
            if (insertQ == "No more questions avaliable for this setting")
            {
                Console.Write(insertQ);
                break;
            }
            else
            {
                Console.WriteLine("");
                Console.Write(insertQ);
                Console.Write(" ");
                Spinner();
                durationTwo -= 6;
            }
            Console.WriteLine("");
        }
    }
}