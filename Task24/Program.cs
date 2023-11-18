using System;
using System.Collections.Generic;

public class Tire
{
    public string Manufacturer { get; }
    public string Model { get; }
    public string TireSize { get; }

    public Tire(string manufacturer, string model, string tireSize)
    {
        Manufacturer = manufacturer;
        Model = model;
        TireSize = tireSize;
    }
}

public class Vehicle
{
    public string Name { get; }
    public string Model { get; }
    public List<Tire> Tires { get; } = new List<Tire>();

    public Vehicle(string name, string model)
    {
        Name = name;
        Model = model;
    }

    public void AddTire(Tire tire)
    {
        Tires.Add(tire);
        Console.WriteLine($"Tire {tire.Manufacturer} added to vehicle {Name}");
    }

    public void PrintTires()
    {
        Console.WriteLine($"Vehicle Name: {Name} Model: {Model} has tires:");
        foreach (var tire in Tires)
        {
            Console.WriteLine($"-Name: {tire.Manufacturer} Model: {tire.Model} TireSize: {tire.TireSize}");
        }
    }
}

class Program
{
    static void Main()
    {
        Vehicle porsche = new Vehicle("Porsche", "911");
        porsche.AddTire(new Tire("Nokia", "Hakkapeliitta", "205R16"));
        porsche.AddTire(new Tire("Nokia", "Hakkapeliitta", "205R16"));
        porsche.AddTire(new Tire("Nokia", "Hakkapeliitta", "205R16"));
        porsche.AddTire(new Tire("Nokia", "Hakkapeliitta", "205R16"));

        porsche.PrintTires();

        Vehicle ducati = new Vehicle("Ducati", "Diavel");
        ducati.AddTire(new Tire("MIC", "Pilot", "160R17"));
        ducati.AddTire(new Tire("MIC", "Pilot", "140R16"));

        ducati.PrintTires();
    }
}