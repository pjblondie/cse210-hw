using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

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
                // Subscription goes here
            }
            else if (userInput == "3")
            {
                // Expense goes here

            }
            else if (userInput == "4")
            {
                // Finacne goal goes here
            }
            else if (userInput == "5")
            {
                // Finance tip goes here
            }
            else if (userInput == "6")
            {
                // Display Categories Goes here
            }
            else if (userInput == "7")
            {
                // Display Expenses Goes here 
            }
            else if (userInput == "8")
            {
                // Saving goes here
            }
            else if (userInput == "9")
            {
                // Loading goes here
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

    }

    public void LoadFromFile()
    {
        
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
}