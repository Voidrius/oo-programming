using System;
using System.Collections.Generic;

public abstract class FoodItem
{
    public string Name { get; }

    protected FoodItem(string name)
    {
        Name = name;
    }

    public abstract string GetDescription();
}

public class Fruit : FoodItem
{
    public string Color { get; }

    public Fruit(string name, string color) : base(name)
    {
        Color = color;
    }

    public override string GetDescription()
    {
        return $"{Color} {Name}";
    }
}

public class DairyProduct : FoodItem
{
    public DateTime ExpiryDate { get; }

    public DairyProduct(string name, DateTime expiryDate) : base(name)
    {
        ExpiryDate = expiryDate;
    }

    public override string GetDescription()
    {
        return $"{Name} (Expires on: {ExpiryDate.ToShortDateString()})";
    }
}

public class Refrigerator
{
    private List<FoodItem> contents = new List<FoodItem>();

    public void AddFoodItem(FoodItem foodItem)
    {
        contents.Add(foodItem);
    }

    public void DisplayContents()
    {
        Console.WriteLine("Refrigerator Contents:");
        foreach (var item in contents)
        {
            Console.WriteLine($"- {item.GetDescription()}");
        }
    }
}

class Program
{
    static void Main()
    {
        Refrigerator myRefrigerator = new Refrigerator();

        myRefrigerator.AddFoodItem(new Fruit("Apple", "Red"));
        myRefrigerator.AddFoodItem(new Fruit("Banana", "Yellow"));
        myRefrigerator.AddFoodItem(new DairyProduct("Milk", DateTime.Now.AddDays(7)));
        myRefrigerator.AddFoodItem(new DairyProduct("Yogurt", DateTime.Now.AddDays(14)));

        myRefrigerator.DisplayContents();
    }
}