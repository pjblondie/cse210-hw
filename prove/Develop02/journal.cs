using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.IO.Enumeration;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    
    private List<string> prompts = new List<string>{ "Is the one thing you used today that your life would feel uncomplete without? Why?",
                "You are given the choice to get something you've been wanting for awhile, but you have to get rid of the thing that brought you the most day today, would you do it?",
                "What is one person who made you feel good today? What did they do?", "How did your attidute change your perception today?",
                "Who is the most important person in your day to day life, what would it feel like without them?"
            };

    public string GetPrompt(List<string> prompt)
    {
        Random randomList = new Random();
        int index = randomList.Next(prompt.Count);
        return prompt[index];
    }

    public void JRun()
    {

        Console.Clear();

        string insertPrompt = GetPrompt(prompts);
        Console.WriteLine(insertPrompt);
        Console.Write("> ");
        string input = Console.ReadLine();
        Entry nEntry = new Entry(input, insertPrompt);
        _entries.Add(nEntry);

    }

    public void Save()
    {
        Console.Write("What would you like the file to be called: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._input}");
            }
        }
        Console.Write("Thank you your journal has been saved");
        Console.WriteLine("");
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
    }

    public void Load()
    {
        Console.Write("What is the filename you want to load? ");
        string fileName = Console.ReadLine();
        _entries.Clear();

        if (File.Exists(fileName))
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");


                Entry loadedEntry = new Entry(parts[0], parts[1], parts[2]);

                _entries.Add(loadedEntry);
            }
            
            Console.WriteLine("Journal Loaded!");
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Sorry that file doesn't exist");
        }
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
    
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt} Entry: {entry._input}");
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

        }
    }

    public void AddPrompt()
    {
        Console.Write("What is the prompt you'd like to add?");
        string nPrompt = Console.ReadLine();
        prompts.Add(nPrompt);
        Console.WriteLine("Prompt Added!");
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();

    }
    public void PrintMenu()
    {
        Console.WriteLine("\n--- Gratitude Journal Entries Program---");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Welcome!");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Please select one of the following options: ");
        Console.WriteLine("----------------------------------");
        Console.WriteLine(" 1. Write");
        Console.WriteLine(" 2. Display");
        Console.WriteLine(" 3. Load");
        Console.WriteLine(" 4. Save");
        Console.WriteLine(" 5. Add prompt");
        Console.WriteLine(" 6. Quit");
        Console.WriteLine("----------------------------------");

    }
}