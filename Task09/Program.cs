using System;

public class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Speed { get; set; }
    public int Tires { get; set; }

    public string ShowInfo()
    {
        return $"Manufacturer: {Brand}, Model: {Model}";
    }

    public override string ToString()
    {
        return $"Manufacturer: {Brand}, Model: {Model}, Speed: {Speed} km/h, Tires: {Tires}";
    }
}

class Program
{
    static void Main()
    {
        Vehicle vehicle1 = new Vehicle
        {
            Brand = "Toyota",
            Model = "Impreza",
            Speed = 130,
            Tires = 4
        };

        Vehicle vehicle2 = new Vehicle
        {
            Brand = "Hyundai",
            Model = "Getz",
            Speed = 90,
            Tires = 4
        };

        Console.WriteLine("Vehicle 1 Info (ShowInfo method):");
        Console.WriteLine(vehicle1.ShowInfo());
        Console.WriteLine();

        Console.WriteLine("Vehicle 2 Info (ShowInfo method):");
        Console.WriteLine(vehicle2.ShowInfo());
        Console.WriteLine();

        vehicle1.Speed = 110;
        vehicle2.Tires = 3;

        Console.WriteLine("Vehicle 1 Info (ToString method):");
        Console.WriteLine(vehicle1);
        Console.WriteLine();

        Console.WriteLine("Vehicle 2 Info (ToString method):");
        Console.WriteLine(vehicle2);
    }
}
