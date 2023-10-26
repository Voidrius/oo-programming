using System;

public class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}\nModel: {Model}\nYear: {Year}\nColor: {Color}");
    }
}

public class Car : Vehicle
{
    public int NumDoors { get; set; }
    public bool IsConvertible { get; set; }
    public string FuelType { get; set; }

    public void DisplayCarInfo()
    {
        DisplayInfo();
        Console.WriteLine($"Number of Doors: {NumDoors}\nConvertible: {IsConvertible}\nFuel type: {FuelType}");
    }
}

public class Bicycle : Vehicle
{
    public int NumGears { get; set; }

    public void DisplayBicycleInfo()
    {
        DisplayInfo();
        Console.WriteLine($"Number of Gears: {NumGears}");
    }
}

public class Motorcycle : Vehicle
{
    public bool HasHelmet { get; set; }
    public string EngineType { get; set; }

    public void DisplayMotorcycleInfo()
    {
        DisplayInfo();
        Console.WriteLine($"Has Helmet: {HasHelmet}\nEngine Type: {EngineType}");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car
        {
            Brand = "Subaru",
            Model = "Impreza",
            Year = 1992,
            Color = "Blue",
            NumDoors = 4,
            IsConvertible = false,
            FuelType = "Gasoline"
        };

        Bicycle bicycle = new Bicycle
        {
            Brand = "Trek",
            Model = "Mountain Bike",
            Year = 2021,
            Color = "Green",
            NumGears = 21
        };

        Motorcycle motorcycle = new Motorcycle
        {
            Brand = "Harley-Davidson",
            Model = "Sportster",
            Year = 2020,
            Color = "Black",
            HasHelmet = true,
            EngineType = "1200cc Air-Cooled Evolution Engine"
        };
        
        Console.WriteLine("Car Details:");
        car.DisplayCarInfo();

        Console.WriteLine("\nMotorcycle Details:");
        motorcycle.DisplayMotorcycleInfo();

        Console.WriteLine("\nBicycle Details:");
        bicycle.DisplayBicycleInfo();
    }
}
