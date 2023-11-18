using System;
using System.Threading;

public class Timer
{
    public int TimeInSeconds { get; private set; }
    public string AlarmMessage { get; private set; }


    public Timer(int timeInSeconds, string alarmMessage = "Wake up, the little bird!")
    {
        TimeInSeconds = timeInSeconds;
        AlarmMessage = alarmMessage;
    }

    public void StartTimer()
    {
        Console.WriteLine($"Timer set for {FormatTime(TimeInSeconds)}");
        Thread.Sleep(TimeInSeconds * 1000); 
        Console.WriteLine($"Alarm: {AlarmMessage}");
    }

    private string FormatTime(int seconds)
    {
        TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);
        return timeSpan.ToString(@"hh\:mm\:ss");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the time for the alarm (in seconds or minutes): ");
        if (int.TryParse(Console.ReadLine(), out int time))
        {
            Console.Write("Enter the alarm message (press Enter for default): ");
            string alarmMessage = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(alarmMessage))
            {
                alarmMessage = "Wake up, the little bird!";
            }

            Timer timer = new Timer(time, alarmMessage);
            timer.StartTimer();
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid time.");
        }

        Console.ReadLine();
    }
}
