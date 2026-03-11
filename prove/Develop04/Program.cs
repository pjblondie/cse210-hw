using System;

class Program
{
    static void Main(string[] args)
    {
        // Breathing Tests // 

        // BreathingActivity breathing1 = new BreathingActivity();
        // breathing1.DisplayStartUp();
        // breathing1.ActivityStart();
        // breathing1.BRun();
        // breathing1.ActivityEnd();

        // Breathing Tests // 

        // Reflection Tests // 

        // Reflection reflecting = new Reflection();
        // reflecting.DisplayStartUp();
        // reflecting.ActivityStart();
        // reflecting.RRun();
        // reflecting.ActivityEnd();

        // Reflection Tests // 

        // Listing Tests //

        // Listing listing = new Listing();
        // listing.DisplayStartUp();
        // listing.ActivityStart();
        // listing.LRun();
        // listing.ActivityEnd();

        // Listing Tests //

        // Main Program // 
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                BreathingActivity breathing1 = new BreathingActivity();
                breathing1.DisplayStartUp();
                breathing1.ActivityStart();
                breathing1.BRun();
                breathing1.ActivityEnd();
            }
            else if (input == 2)
            {
                Reflection reflecting = new Reflection();
                reflecting.DisplayStartUp();
                reflecting.ActivityStart();
                reflecting.RRun();
                reflecting.ActivityEnd();
            }
            else if (input == 3)
            {
                Listing listingActivity = new Listing();
                listingActivity.DisplayStartUp();
                listingActivity.ActivityStart();
                listingActivity.LRun();
                listingActivity.ActivityEnd();
            }
            else
            {
                break;
            }
        }
    }
}