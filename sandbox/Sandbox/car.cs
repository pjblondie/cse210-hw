using System;
using System.Runtime;
using System.Threading;

public class Program_car
{
    public static void Main()
    {
        Car myCar = new Car();
        myCar.Run();
    }
}

public class Car
{
    public Door driverDoor = new Door("Driver", false);

    public Door passengerDoor = new Door("Passenger", false);
    public Horn carHorn = new Horn();
    public RemoteClicker clicker = new RemoteClicker();
    public bool IsRunning = true;

    public void Run()
    {
        driverDoor.Name = "Driver Door";
        passengerDoor.Name = "Passenger Door";
        
           int i = 0;
        while (IsRunning)
        {
            // 1. DISPLAY OPTIONS
            PrintMenu();

            // 2. CHECK STATUS (The "Brain")
            if (clicker.IsArmed)
            {
                if (driverDoor.IsOpen || passengerDoor.IsOpen)
                {
                    carHorn.Honk();
                    i += 1;
                    if (i != 2)
                    {
                        Console.WriteLine("Warning Warning do not trigger alarm again");
                    }
                    else
                    {
                        Console.WriteLine("Last warning given...setting to defend car at all costs, self-destruct in...");
                        Console.WriteLine("3");
                        Thread.Sleep(1000);
                        Console.WriteLine("2");
                        Thread.Sleep(1000);
                        Console.WriteLine("1");
                        Thread.Sleep(1000);
                        Console.WriteLine("*KABOOM*");
                    }


                }
            }

            // 3. GET INPUT
            if (IsRunning == true)
            {
                Console.Write("\nSelect an option (1-5): ");
                string input = Console.ReadLine();

                if (input == "1") driverDoor.Toggle();
                else if (input == "2") passengerDoor.Toggle();
                else if (input == "3") clicker.IsArmed = true;
                else if (input == "4") clicker.IsArmed = false;
                else if (input == "5") IsRunning = false;
                else Console.WriteLine("Invalid choice, try again.");

                // 4. SHOW CURRENT STATE
                Console.WriteLine("----------------------------------");
                Console.WriteLine($"SYSTEM STATUS: [Armed: {clicker.IsArmed}]");
                Console.WriteLine($"DOORS:         [Driver: {driverDoor.GetStatus()}] [Passenger: {passengerDoor.GetStatus()}]");
                Console.WriteLine("----------------------------------");
            }
        }
        Console.WriteLine("Goodbye!");
    }

    public void PrintMenu()
    {
        Console.WriteLine("\n--- CAR ALARM MENU ---");
        Console.WriteLine("1. Open/Close Driver Door");
        Console.WriteLine("2. Open/Close Passenger Door");
        Console.WriteLine("3. Set Alarm (Arm)");
        Console.WriteLine("4. Disable Alarm (Disarm)");
        Console.WriteLine("5. Exit Program");
    }
}

// --- Component Classes ---

public class Door
{
    public string Name;
    public bool IsOpen = false;

    public Door(string name, bool isOpen)
    {
        string Name = name;
        bool IsOpen = isOpen;
    }

    public void Toggle()
    {
        IsOpen = !IsOpen;
        Console.WriteLine($"[Action] {Name} is now {(IsOpen ? "OPEN" : "CLOSED")}");
    }

    public string GetStatus()
    {
        return IsOpen ? "Open" : "Closed"; 
    }
}

public class Horn
{
    public void Honk()
    {
        Console.WriteLine("\n!!! ALARM TRIGGERED !!!");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("BEEP! HONK!");
            Thread.Sleep(1000);
        }
    }
}

public class RemoteClicker
{
    public bool IsArmed = false;
}

// public class Expload
// {
    // int i = 0; 
    
// }