using System.Security.Cryptography.X509Certificates;

class Activity
{
    private string _name;
    protected int _duration;
    private string _description;

    // Set constructor as public right now for testing purposes switch to private later
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartUp()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void Spinner()
    {
        List<string> spinlist = new List<string> { "/", "-", "\\", "|", "/", };
        int spinTime = 0;
        while (spinTime < 15)
        {
            foreach (string spin in spinlist)
            {
                Console.Write($"{spin}");
                Thread.Sleep(400);
                Console.Write("\b \b");
                spinTime += 1;
            }
        }
        Console.WriteLine("");
    }
    public void ActivityStart()
    {
        Console.Clear();
        Console.Write("Get Ready");
        DotSleep();
        Spinner();
        Console.WriteLine("");
    }
    public void ActivityEnd()
    {
        Console.WriteLine("");
        Console.WriteLine("Well Done!");
        Spinner();

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
        Spinner();
    }
    public void DotSleep()
    {
        Console.Write(".");
        Thread.Sleep(50);
        Console.Write(".");
        Thread.Sleep(50);
        Console.Write(".");
        Thread.Sleep(50);
    }
        public void NumberCount()
    {
        List<string> numbers = new List<string> { "6", "5", "4", "3", "2", "1" };
        foreach (string number in numbers)
        {
            Console.Write($"{number}");
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
        
    }

}
