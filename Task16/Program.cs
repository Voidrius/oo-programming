using System;

public class Vehicle
{
    public string Name { get; set; }
    public string Model { get; set; }
    public int ModelYear { get; set; }
    public string Color { get; set; }

    public override string ToString()
    {
        return $" Name: {Name}\n Model: {Model}\n ModelYear: {ModelYear}\n Color: {Color}\n";
    }
}

public class Bicycle : Vehicle
{
    public bool GearWheels { get; set; }
    public string GearName { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()} GearWheels: {GearWheels}\n Gear Name: {GearName}";
    }
}

public class Boat : Vehicle
{
    public int SeatCount { get; set; }
    public string BoatType { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()} SeatCount: {SeatCount}\n BoatType: {BoatType}";
    }
}

class Program
{
    static void Main()
    {
        Bicycle bike1 = new Bicycle
        {
            Name = "Jopo",
            Model = "Street",
            ModelYear = 2016,
            Color = "Blue",
            GearWheels = false,
            GearName = ""
        };

        Bicycle bike2 = new Bicycle
        {
            Name = "Tunturi",
            Model = "StreetPower",
            ModelYear = 2010,
            Color = "Black",
            GearWheels = true,
            GearName = "Shimano Nexus"
        };

        Boat boat1 = new Boat
        {
            Name = "SummerFun",
            Model = "S900",
            ModelYear = 1990,
            Color = "White",
            SeatCount = 3,
            BoatType = "Rowboat"
        };

        Boat boat2 = new Boat
        {
            Name = "Yamaha",
            Model = "Model 1000",
            ModelYear = 2010,
            Color = "Yellow",
            SeatCount = 5,
            BoatType = "Motorboat"
        };

        Console.WriteLine("- Bike1 info");
        Console.WriteLine(bike1);
        Console.WriteLine();
        Console.WriteLine("- Bike2 info");
        Console.WriteLine(bike2);
        Console.WriteLine();
        Console.WriteLine("- Boat1 info");
        Console.WriteLine(boat1);
        Console.WriteLine();
        Console.WriteLine("- Boat2 info");
        Console.WriteLine(boat2);
    }
}
