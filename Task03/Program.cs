using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter distance traveled: ");
        string input = Console.ReadLine();
        int distance = int.Parse(input);
        double consumption = CalculateConsumption(distance);
        double price = CalculatePrice(consumption);
        Console.WriteLine($"Fuel consumption is {consumption} liters and it costs {price} euros.");
    
    
    }

    static double CalculateConsumption(int distance)
    {
        Random rnd = new Random();
        double consumption = rnd.Next(6, 10) * distance / 100.0;
        return consumption;
    }

    static double CalculatePrice(double consumption)
    {
        Random rnd = new Random();
        double price = rnd.Next(175, 250) / 100.0 * consumption;
        return price;
    }


}
