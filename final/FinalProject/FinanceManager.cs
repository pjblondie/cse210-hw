using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

public class FinanceManager
{
    private List<Category> _categories;

    private List<Subscription> _subscription;

    private List<SavingsGoal> _goals;

    private List<Expense> _expenses;

    public FinanceManager()
    {
        _categories = new List<Category>();
        _subscription = new List<Subscription>();
        _goals = new List<SavingsGoal>();
        _expenses = new List<Expense>();
    }

    public void DisplayMenu()
    {
        bool running = true;
        while (running == true)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Personal Finance ");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(" 1. Create a new budget Category");
            Console.WriteLine(" 2. Track a Subscription");
            Console.WriteLine(" 3. Record an expense");
            Console.WriteLine(" 4. Record a Finance Goal");
            Console.WriteLine(" 5. Receive a Finance Tip");
            Console.WriteLine(" 6. Display Categories");
            Console.WriteLine(" 7. Display Expenses");
            Console.WriteLine(" 8. Save");
            Console.WriteLine(" 9. Load");
            Console.WriteLine(" 10. Quit");
            Console.WriteLine("------------------------------------");
            Console.Write("Record your response here: ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                // Budget category goes here
                Console.Clear();
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("What type of category would you like to create?");
                Console.WriteLine("     1. A Spending Category (Food, Rent, Etc.)");
                Console.WriteLine("     2. A Savings Category (Emergancy Fund, Etc.)");
                Console.WriteLine("------------------------------------------------------");
                Console.Write("Record your response here: ");

                string categoryType = Console.ReadLine();

                // 2. The Shared Questions
                Console.Write("What is the name of the category? ");
                string name = Console.ReadLine();

                Console.Write("What is a short description? ");
                string desc = Console.ReadLine();

                Console.Write("What is the monthly limit amount? ");
                double limit = double.Parse(Console.ReadLine());

                // 3. The Logic Branch
                if (categoryType == "1")
                {

                    _categories.Add(new SpendingCategory(name, desc, limit));
                    Console.Write("Saving your category...");
                    Spinner();
                    Console.WriteLine("");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine($"Success! '{name}' added as a Spending Category.");
                    Console.WriteLine("------------------------------------------------------");
                    Console.Write("     Please press enter to return to menu: ");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (categoryType == "2")
                {

                    _categories.Add(new SavingCategory(name, desc, limit));
                    Console.Write("Saving your category...");
                    Spinner();
                    Console.WriteLine("");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine($"Success! '{name}' added as a Saving Category.");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("     Please press enter to return to menu: ");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid selection. Category creation cancelled.");
                }
            }
            else if (userInput == "2")
            {
                if (_categories.Count == 0)
                {
                    Console.WriteLine("Error: You must create a Category first to house this subscription.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("What type of subscription would you like to create?");
                    Console.WriteLine("     1. A Monthly Subscription");
                    Console.WriteLine("     2. A Yearly Subscription");
                    Console.WriteLine("------------------------------------------------------");
                    Console.Write("Record your response here: ");

                    string subType = Console.ReadLine();

                    Console.Write("What is the total price (format like 00.00)? ");
                    double price = double.Parse(Console.ReadLine());

                    Console.Write("What is the subscription charger? ");
                    string name = Console.ReadLine();
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("\nSelect a category for this subscription:");
                    Console.WriteLine("------------------------------------------------------");

                    DisplayCategoryOptions();
                    int index = int.Parse(Console.ReadLine()) - 1;


                    if (subType == "1")
                    {
                        _subscription.Add(new MonthlySubscription(name, price, _categories[index]));
                    }
                    else
                    {
                        _subscription.Add(new YearlySubscription(name, price, _categories[index]));
                    }

                    Console.Write("Processing billing cycle...");
                    Spinner();

                    double monthlyCost = _subscription[^1].GetMonthlyCost();

                    _categories[index].AddSpending(monthlyCost);


                    Console.Clear();
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine($"Success! Added {name}, Monthly budget impact: ${monthlyCost:F2}");
                    Console.WriteLine("------------------------------------------------------");
                    Console.Write("Press enter to return to menu: ");
                    Console.ReadLine();
                }
            }
            else if (userInput == "3")
            {
                Console.Clear();
                if (_categories.Count == 0)
                {
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("Error: You must create a Category first.");
                    Console.WriteLine("------------------------------------------------------");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("Record an Expense");
                    Console.WriteLine("------------------------------------------------------");

                    Console.Write("What was the expense?: ");
                    string name = Console.ReadLine();

                    Console.Write("What was the price?: ");
                    double amount = double.Parse(Console.ReadLine());

                    Console.Write("What is the date? (format like 00/00/0000): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());


                    DisplayCategoryOptions();

                    int index = int.Parse(Console.ReadLine()) - 1;

                    _expenses.Add(new Expense(name, amount, date, _categories[index]));

                    Console.Write("Recording transaction...");
                    _categories[index].AddSpending(amount);
                    Spinner();
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine($"Success! Added {name} to {_categories[index].GetName()}.");
                    Console.WriteLine("------------------------------------------------------");
                    Console.Write("Please press enter to return to menu: ");
                    Console.ReadLine();
                }
            }
            else if (userInput == "4")
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Record a Finance Goal");
                Console.WriteLine("------------------------------------------------------");

                Console.Write("What is the name of this goal? ");
                string name = Console.ReadLine();

                Console.Write("Enter a prompt/question for this goal (like 'How will you save for this?'): ");
                string prompt = Console.ReadLine();


                SavingsGoal newGoal = new SavingsGoal(name, prompt);

                newGoal.AskGoal();

                _goals.Add(newGoal);

                Console.WriteLine("Goal recorded successfully!");
                Console.WriteLine("------------------------------------------------------");
                Console.Write("Press enter to return to menu: ");

                Console.ReadLine();
            }
            else if (userInput == "5")
            {
                Console.Clear();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Finance Tip");
                Console.WriteLine("------------------------------------");
                if (_categories.Count == 0)
                {
                    Console.WriteLine("Tip: Start by creating a budget category to track your goals!");
                }
                else
                {
                    Category lowestCat = _categories[0];

                    foreach (Category cat in _categories)
                    {
                        if (cat.GetRemaining() < lowestCat.GetRemaining())
                        {
                            lowestCat = cat;
                        }
                    }
                    if (lowestCat.GetRemaining() <= 0)
                    {
                        Console.WriteLine($"ALERT: Your '{lowestCat.GetName()}' category is over budget!");
                        Console.WriteLine("Tip: Review your recent expenses to see where you can cut back next month.");
                    }
                    else if (lowestCat.GetRemaining() < (lowestCat.GetLimit() * 0.2))
                    {
                        Console.WriteLine($"ALERT: You have less than 20% left in '{lowestCat.GetName()}'.");
                        Console.WriteLine("Tip: Try to avoid any non-essential spending in this category for a few days.");
                    }
                    else
                    {
                        Console.WriteLine("Great job! All your categories are looking healthy.");
                        Console.WriteLine("Tip: Consider putting any extra 'Remaining' money into a Savings Goal!");
                    }
                }

                Console.WriteLine("------------------------------------------------------");
                Console.Write("Please press enter to return to menu: ");
                Console.ReadLine();
            }
            else if (userInput == "6")
            {
                Console.Clear();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Budget Categories");
                Console.WriteLine("------------------------------------");

                if (_categories.Count == 0)
                {
                    Console.WriteLine("No categories found.");
                }

                foreach (Category cat in _categories)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine($"Name: {cat.GetName()}, {cat.GetCategoryDetails}");
                    Console.WriteLine($"Description {cat.GetDescription()}");
                    Console.WriteLine($"Budget: ${cat.GetRemaining():F2} remaining of ${cat.GetLimit():F2}");
                    Console.WriteLine("------------------------------------");

                }
                Console.Write("Please press enter to return to menu: ");
                Console.ReadLine();
            }
            else if (userInput == "7")
            {
                Console.Clear();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Expenses");
                Console.WriteLine("------------------------------------");

                if (_expenses.Count == 0)
                {
                    Console.WriteLine("   No expenses recorded yet.");
                }
                else
                {
                    foreach (Expense exp in _expenses)
                    {
                        Console.WriteLine(exp.GetDate().ToString("d") + " - " + exp.GetName() + ": $" + exp.GetAmount() + " [" + exp.GetCategory().GetName() + "]");
                    }
                }
                Console.WriteLine("------------------------------------------------------");
                Console.Write("Please press enter to return to menu: ");
                Console.ReadLine();

            }
            else if (userInput == "8")
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Save");
                Console.WriteLine("------------------------------------------------------");
                SaveToFile();
                Console.WriteLine("File saved successfully!");
                Console.WriteLine("------------------------------------------------------");
                Console.Write("Press enter to return to menu: ");
                Console.ReadLine();
            }
            else if (userInput == "9")
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Load");
                Console.WriteLine("------------------------------------------------------");
                LoadFromFile();
                Console.WriteLine("File loaded successfully!");
                Console.WriteLine("------------------------------------------------------");
                Console.Write("Press enter to return to menu: ");
                Console.ReadLine();
            }
            else if (userInput == "10")
            {
                // add auto save the file to Finance.txt
                Console.Clear();
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine("Thank you for using the personal finance app have a wonderful rest of your day!");
                Console.WriteLine("----------------------------------------------------------------------------------");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid Input please try again");
            }
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter filename (e.g., finance.txt): ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {

            foreach (Category cat in _categories)
            {

                outputFile.WriteLine($"Category:{cat.GetType().Name}|{cat.GetName()}|{cat.GetDescription()}|{cat.GetLimit()}|{cat.GetTotalSpent()}");
            }


            foreach (Expense exp in _expenses)
            {
                outputFile.WriteLine($"Expense:{exp.GetName()}|{exp.GetAmount()}|{exp.GetDate()}|{exp.GetCategory().GetName()}");
            }


            foreach (Subscription sub in _subscription)
            {

                outputFile.WriteLine($"Subscription:{sub.GetType().Name}|{sub.GetName()}|{sub.GetPrice()}|{sub.GetCategory().GetName()}");
            }


            foreach (SavingsGoal goal in _goals)
            {

                outputFile.WriteLine($"Goal:{goal.GetGoalName()}|{goal.GetPromptText()}|{goal.GetUserResponse()}|{goal.GetIsAchieved()}");
            }
        }

        
        }


   public void LoadFromFile()
{
    Console.Write("Enter the filename to load: ");
    string filename = Console.ReadLine();

    if (File.Exists(filename))
    {
        string[] lines = File.ReadAllLines(filename);
        
        _categories.Clear();
        _expenses.Clear();
        _subscription.Clear();
        _goals.Clear();

            foreach (string line in lines)
            {
                string[] mainParts = line.Split(':');
                string entryType = mainParts[0];
                string[] data = mainParts[1].Split('|');

                if (entryType == "Category")
                {
                    string typeName = data[0];
                    string name = data[1];
                    string desc = data[2];
                    double limit = double.Parse(data[3]);
                    double spent = double.Parse(data[4]);

                    if (typeName == "SpendingCategory")
                    {
                        SpendingCategory newSpender = new SpendingCategory(name, desc, limit);
                        newSpender.AddSpending(spent);
                        _categories.Add(newSpender);
                    }
                    else
                    {
                        SavingCategory newSaver = new SavingCategory(name, desc, limit);
                        newSaver.AddSpending(spent);
                        _categories.Add(newSaver);
                    }
                }
                else if (entryType == "Expense")
                {
                    string name = data[0];
                    double amt = double.Parse(data[1]);
                    DateTime date = DateTime.Parse(data[2]);
                    string catName = data[3];


                    Category found = null;
                    foreach (Category c in _categories)
                    {
                        if (c.GetName() == catName) { found = c; }
                    }
                    _expenses.Add(new Expense(name, amt, date, found));
                }
            else if (entryType == "Subscription")
            {
                string subClass = data[0];
                string name = data[1];
                double price = double.Parse(data[2]);
                string catName = data[3];

                Category found = null;
                foreach (Category c in _categories)
                {
                    if (c.GetName() == catName) { found = c; }
                }

                if (subClass == "MonthlySubscription")
                    _subscription.Add(new MonthlySubscription(name, price, found));
                else
                    _subscription.Add(new YearlySubscription(name, price, found));
            }
            
            else if (entryType == "Goal")
            {
                string name = data[0];
                string prompt = data[1];
                string response = data[2];
                bool achieved = bool.Parse(data[3]);

                SavingsGoal loadedGoal = new SavingsGoal(name, prompt);

                loadedGoal.SetLoadedData(response, achieved); 

                _goals.Add(loadedGoal);
            }
        }
        
        Console.WriteLine("Successfully loaded your records.");
    }
    else
    {
        Console.WriteLine("File not found.");
    }
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

    public void DisplayCategoryOptions()
    {
        for (int i = 0; i < _categories.Count; i++)
        {
            Console.WriteLine($"    {i + 1}. {_categories[i].GetName()}");
        }
        Console.Write("Enter your response here: ");
    }
    
}

