using System;
using System.Collections.Generic;
using System.Linq;

public class Song
{
    public string Name { get; set; }
    public TimeSpan Length { get; set; }

    public Song(string name, int minutes, int seconds)
    {
        Name = name;
        Length = new TimeSpan(0, minutes, seconds);
    }
}

public class CD
{
    public string Name { get; set; }
    public string Artist { get; set; }
    public List<Song> Songs { get; set; }

    public int NumberOfSongs => Songs.Count;
    public TimeSpan TotalLength => Songs.Aggregate(TimeSpan.Zero, (total, song) => total + song.Length);

    public CD(string name, string artist, List<Song> songs)
    {
        Name = name;
        Artist = artist;
        Songs = songs;
    }
}

class Program
{
    static void Main()
    {
        // Creating songs for the CD
        List<Song> songs = new List<Song>
        {
            new Song("Shudder Before the Beautiful", 6, 29),
            new Song("Weak Fantasy", 5, 23),
            new Song("Elan", 4, 45),
            new Song("Yours Is an Empty Hope", 5, 34),
            new Song("Our Decades in the Sun", 6, 37),
            new Song("My Walden", 4, 38),
            new Song("Endless Forms Most Beautiful", 5, 7),
            new Song("Edema Ruh", 5, 15),
            new Song("Alpenglow", 4, 45),
            new Song("The Eyes of Sharbat Gula", 6, 3),
            new Song("The Greatest Show on Earth", 24, 0)
        };

        // Creating a CD
        CD nightwishCD = new CD("Endless Forms Most Beautiful", "Nightwish", songs);

        // Displaying CD information
        Console.WriteLine($"You have a CD:");
        Console.WriteLine($"- Name: {nightwishCD.Name}");
        Console.WriteLine($"- Artist: {nightwishCD.Artist}");
        Console.WriteLine($"- Total Length: {nightwishCD.TotalLength.TotalMinutes} min {nightwishCD.TotalLength.Seconds} sec");
        Console.WriteLine($"- {nightwishCD.NumberOfSongs} songs:");

        foreach (var song in nightwishCD.Songs)
        {
            Console.WriteLine($"  - {song.Name}, {song.Length.Minutes}:{song.Length.Seconds:D2}");
        }
    }
}