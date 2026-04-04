using System.Security.Cryptography.X509Certificates;

class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayMenu()
    {
        bool quit = false;
        while (quit == false)
        {

            Console.Clear();
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine("");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goal");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Spend Points");
            Console.WriteLine(" 7. Quit");
            Console.Write("Select a choice from the menu: ");

            string menuInput = Console.ReadLine();
            if (menuInput == "1")
            {



                GoalTypes();

                string typeInput = Console.ReadLine();

                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();

                Console.Write("What is the description for your goal? ");
                string description = Console.ReadLine();

                Console.Write("How many points is your goal worth? ");
                int points = int.Parse(Console.ReadLine());

                if (typeInput == "1")
                {
                    _goals.Add(new SimpleGoal(name, description, points));
                }

                else if (typeInput == "2")
                {
                    _goals.Add(new EternalGoal(name, description, points));
                }

                else if (typeInput == "3")
                {
                    Console.Write("How many times...? ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("What is the bonus...? ");
                    int bonus = int.Parse(Console.ReadLine());

                    _goals.Add(new ChecklistGoal(target, bonus, name, description, points));
                }


            }
            else if (menuInput == "2")
            {

                Console.WriteLine("The goals are:");

                for (int i = 0; i < _goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {_goals[i].StringDetails()}");
                }

                Console.Write("\nPress Enter to continue: ");
                Console.ReadLine();

            }
            else if (menuInput == "3")
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {

                    outputFile.WriteLine(_score);

                    foreach (Goal goal in _goals)
                    {
                        outputFile.WriteLine(goal.StringRep());
                    }
                }
            }
            else if (menuInput == "4")
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                string[] lines = File.ReadAllLines(fileName);

                _score = int.Parse(lines[0]);
                _goals.Clear();

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(":");
                    string type = parts[0];
                    string[] data = parts[1].Split(",");

                    if (type == "SimpleGoal")
                    {
                        SimpleGoal goal = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                        goal.SetComplete(bool.Parse(data[3]));
                        _goals.Add(goal);
                    }
                    else if (type == "EternalGoal")
                    {
                        _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                    }
                    else if (type == "ChecklistGoal")
                    {
                        ChecklistGoal goal = new ChecklistGoal(int.Parse(data[4]), int.Parse(data[3]), data[0], data[1], int.Parse(data[2]));
                        goal.SetAmountCompleted(int.Parse(data[5]));
                        _goals.Add(goal);
                    }
                }
            }

            else if (menuInput == "5")
            {
                Console.WriteLine("The goals are:");
                for (int i = 0; i < _goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
                }

                Console.Write("Which goal did you accomplish? ");
                int index = int.Parse(Console.ReadLine()) - 1;

                int pointsEarned = _goals[index].RecordEvent();
                _score += pointsEarned;

                Console.WriteLine($"Congratulations! You earned {pointsEarned} points!");
                Console.WriteLine($"You now have {_score} points.");

                Console.Write("\nPress Enter to continue: ");
                Console.ReadLine();
            }

            else if (menuInput == "6")
            {

                Console.WriteLine("What would you like to spend your points on?");
                Console.WriteLine(" 1. 30 Minutes of Gaming (100 pts)");
                Console.WriteLine(" 2. A Sweet Treat (200 pts)");
                Console.WriteLine(" 3. A Movie Night (500 pts)");
                Console.Write("Select an option: ");

                string spendChoice = Console.ReadLine();
                int cost = 0;

                if (spendChoice == "1") cost = 100;
                else if (spendChoice == "2") cost = 200;
                else if (spendChoice == "3") cost = 500;

                if (_score >= cost && cost > 0)
                {
                    _score -= cost;
                    Console.WriteLine("Purchase successful! Enjoy your reward.");
                }
                else
                {
                    Console.WriteLine("Insufficient points or invalid choice.");
                }

                Console.Write("\nPress Enter to continue: ");
                Console.ReadLine();
            }

            else if (menuInput == "7")
            {
                quit = true;
            }
        }
    }

    public void GoalTypes()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
    }
}
