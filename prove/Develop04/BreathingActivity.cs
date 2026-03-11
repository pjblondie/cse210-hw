using System.Globalization;
using System.Runtime.CompilerServices;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. \n Clear your mind and focus on your breathing") { }
    public void BRun()
    {
        {
            int durationOne = _duration;
            while (durationOne > 0)
            {
                BreatheExercise();
                durationOne -= 12;
            }
        }
    }
    private void BreatheExercise()
    {
        
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("Breathe In");
        DotSleep();
        NumberCount();
        Console.WriteLine("");
        Console.WriteLine("");

        Console.Write("Now Breath Out");
        DotSleep();
        NumberCount();
    }

}