using System;

public abstract class Mammal
{
    public int Age { get; set; }

    public abstract void Move();
}

public class Human : Mammal
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }

    public override void Move()
    {
        Console.WriteLine("Moving");
    }

    public void Grow()
    {
        Age++;
    }
}

public class Baby : Human
{
    public string Diaper { get; set; }

    public override void Move()
    {
        Console.WriteLine("Crawling");
    }
}

public class Adult : Human
{
    public string Auto { get; set; }

    public override void Move()
    {
        Console.WriteLine("Walking");
    }
}

class Program
{
    static void Main()
    {
        Baby baby = new Baby
        {
            Name = "Masi",
            Age = 1,
            Weight = 8.5,
            Height = 0.6,
            Diaper = "Pampers"
        };

        Adult woman = new Adult
        {
            Name = "Anna Juupari",
            Age = 27,
            Weight = 55,
            Height = 1.60,
            Auto = "Porsche Carrera"
        };

        Adult man = new Adult
        {
            Name = "Matti Perttilä",
            Age = 30,
            Weight = 75.5,
            Height = 1.75,
            Auto = "Hyundai Getz"
        };

        Console.WriteLine("Baby Information:");
        Console.WriteLine($"Name: {baby.Name}, Age: {baby.Age} years, Weight: {baby.Weight} kg, Height: {baby.Height} m");
        baby.Move();
        Console.WriteLine($"Diaper Brand: {baby.Diaper}");

        Console.WriteLine("\nAdult 1 Information:");
        Console.WriteLine($"Name: {man.Name}, Age: {man.Age} years, Weight: {man.Weight} kg, Height: {man.Height} m");
        man.Move();
        Console.WriteLine($"Auto: {man.Auto}");

        Console.WriteLine("\nAdult 2 Information:");
        Console.WriteLine($"Name: {woman.Name}, Age: {woman.Age} years, Weight: {woman.Weight} kg, Height: {woman.Height} m");
        woman.Move();
        Console.WriteLine($"Auto: {woman.Auto}");
    }
}
