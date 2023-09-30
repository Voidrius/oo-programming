using System;

class Program
{
    static void Main()
    {
        int[] stylePoints = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Give points: ");
            if (int.TryParse(Console.ReadLine(), out int points))
            {
                stylePoints[i] = points;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                i--; // Account for the invalid input and allow the app to continue running normally
            }
        }

        int pointSum = CalculateTotalPoints(stylePoints);
        Console.WriteLine($"Total points are {pointSum}");
    }

    static int CalculateTotalPoints(int[] stylePoints)
    {
        Array.Sort(stylePoints);

        // Sum up all points except the largest and smallest value
        int total = 0;
        for (int i = 1; i < 4; i++)
        {
            total += stylePoints[i];
        }

        return total;
    }
}