using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

public class FinanceManager
{
    private List<Category> _categories;

    private List<Subscription> _subscription;

    private List<SavingsGoal> _goals;

    private List<Expense> _expenses;

    public void DisplayMenu()
    {
       bool running = true;
        while (running == true)
        {

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


                string categoryType = Console.ReadLine();
            
                        // 2. The Shared Questions
                Console.Write("What is the name of the category? ");
                string name = Console.ReadLine();

                Console.Write("What is a short description? ");
                string desc = Console.ReadLine();

                Console.Write("What is the monthly limit/goal amount? ");
                double limit = double.Parse(Console.ReadLine());

                // 3. The Logic Branch
                if (categoryType == "1")
                {
            
                    _categories.Add(new SpendingCategory(name, desc, limit));
                    Console.WriteLine($"Success! '{name}' added as a Spending Category.");
                }
                else if (categoryType == "2")
                {
        
                    _categories.Add(new SavingCategory(name, desc, limit));
                    Console.WriteLine($"Success! '{name}' added as a Saving Category.");
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
                Console.WriteLine("Thank you for using the personal finance app have a wonderful rest of your day!");
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

}