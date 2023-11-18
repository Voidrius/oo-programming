using System;

public class Dice
{
    private Random random = new Random();

    public int Roll()
    {
        return random.Next(1, 7);
    }
}

class Program
{
    static void Main()
    {
        Dice dice = new Dice();
        int singleThrow = dice.Roll();
        Console.WriteLine($"Dice, one test throw value is {singleThrow}");
        Console.WriteLine();

        Console.Write("How many times you want to throw a dice: ");
        if (int.TryParse(Console.ReadLine(), out int numberOfThrows))
        {
            int sum = 0;
            for (int i = 0; i < numberOfThrows; i++)
            {
                int result = dice.Roll();
                sum += result;
            }

            double average = (double)sum / numberOfThrows;
            Console.WriteLine($"Dice is now thrown {numberOfThrows} times, average is {average:F4}");
            Console.WriteLine();

            Console.WriteLine($"Dice is now thrown {numberOfThrows} times");
            Console.WriteLine($"- average is {average:F4}");

            int[] counts = new int[7];
            for (int i = 0; i < numberOfThrows; i++)
            {
                int result = dice.Roll();
                counts[result]++;
            }

            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine($"- {i} count is {counts[i]}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number of throws.");
        }

        Console.ReadLine();
    }
}