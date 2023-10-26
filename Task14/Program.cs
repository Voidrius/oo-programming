using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Amplifier
{
    private int _volume;

    public int Volume
    {
        get { return _volume; }
        set
        {
            if (value < 0)
            {
                _volume = 0;
                Console.WriteLine("Too low volume - Amplifier volume is set to minimum : 0");
            }
            else if (value > 100)
            {
                _volume = 100;
                Console.WriteLine("Too much volume - Amplifier volume is set to maximum : 100");
            }
            else
            {
                _volume = value;
                Console.WriteLine($"Amplifier volume is set to : {_volume}");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Amplifier amplifier = new Amplifier();

        string input;
        do
        {
            Console.Write("Give a new volume value (0-100) or enter 'X' to exit > ");
            input = Console.ReadLine().ToUpper();

            if (input != "X")
            {
                if (int.TryParse(input, out int newVolume))
                {
                    amplifier.Volume = newVolume;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid volume value.");
                }
            }
        } while (input != "X");
    }
}

