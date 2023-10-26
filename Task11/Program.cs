using System;
using System.Collections.Generic;

public class Song
{
    public string Name { get; set; }
    public string Duration { get; set; }

    public Song(string name, string duration)
    {
        Name = name;
        Duration = duration;
    }
}

public class CD
{
    public string Artist { get; }
    public string Name { get; }
    public string Genre { get; }
    public decimal Price { get; }
    public List<Song> Songs { get; }

    public CD (string artist, string name, string genre, decimal price, List<Song> songs)
    {
        Artist = artist;
        Name = name;
        Genre = genre;
        Price = price;
        Songs = songs;
    }

    public void AddSong(Song song)
    {
        Songs.Add(song);
    }

    public string GetAllInfo()
    {
        var cdInfo = $"CD:\n" +
                     $"- Artist: {Artist}\n" +
                     $"- Name: {Name}\n" +
                     $"- Genre: {Genre}\n" +
                     $"- Price: ${Price}\n" +
                     $"Songs:\n";

        foreach (var song in Songs)
        {
            cdInfo += $"--- Name: {song.Name} - {song.Duration}\n";
        }

        return cdInfo;
    }
}

class Program
{
    static void Main()
    {
        var songs = new List<Song>
        {
            new Song("The Fire Is Gone", "02:40"),
            new Song("Unstoppable Force", "04:00"),
            new Song("Cerberus", "02:21"),
            new Song("A Thousand Greetings", "05:42"),
            new Song("Castle Vein", "05:40"),
            new Song("Divine Intervention", "02:36")
        };

        var cd = new CD("Heaven Pierce Her", "ULTRAKILL: INFINITE HYPERDEATH", "Breakcore", 3.99m, songs);

        // Print CD information
        Console.WriteLine(cd.GetAllInfo());
    }
}