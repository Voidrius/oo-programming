using System;

public class Item
{
    public string Title { get; set; }
    public string Type { get; set; }
}

public class Electronic : Item
{
    public string PowerSource { get; set; }
}

public class GameDevice : Electronic
{
    public string Brand { get; set; }
    public int ReleaseYear { get; set; }
    public int StorageSize { get; set; }

}

public class Book : Item
{
    public string Author { get; set; }
    public string Genre { get; set; }
}

public class DigitalMedia : Item
{
    public string MediaType { get; set; }
    public int Duration { get; set; }
}

class Program
{
    static void Main()
    {
        Electronic laptop = new Electronic
        {
            Title = "Laptop",
            Type = "Electronics",
            PowerSource = "Battery"
        };

        Book novel = new Book
        {
            Title = "To Kill a Mockingbird",
            Type = "Book",
            Author = "Harper Lee",
            Genre = "Fiction"
        };

        DigitalMedia movie = new DigitalMedia
        {
            Title = "Inception",
            Type = "Movie",
            MediaType = "Blu-ray",
            Duration = 148
        };
        GameDevice console = new GameDevice
        {
            Title = "Switch",
            Type = "Game Device",
            PowerSource = "Power Outlet",
            Brand = "Nintendo",
            ReleaseYear = 2017,
            StorageSize = 32,
        };
        Console.WriteLine("Item: " + laptop.Title);
        Console.WriteLine("Power Source: " + laptop.PowerSource + "\n");

        Console.WriteLine("Item: " + novel.Title);
        Console.WriteLine("Author: " + novel.Author + "\n");

        Console.WriteLine("Item: " + movie.Title);
        Console.WriteLine("Media Type: " + movie.MediaType);
        Console.WriteLine("Duration: " + movie.Duration + " minutes\n");
        
        Console.WriteLine("Item: " + console.Title);
        Console.WriteLine("Brand: " + console.Brand);
        Console.WriteLine("Released: " + console.ReleaseYear);

    }
}