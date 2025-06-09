using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", 
               "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        int cycleTime = 6; // 3 seconds inhale + 3 seconds exhale
        int cycles = duration / cycleTime;

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("\nBreathe in... ");
            ShowCountDown(3);

            Console.Write("\nNow breathe out... ");
            ShowCountDown(3);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}
