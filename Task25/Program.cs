using System;
using System.Collections.Generic;

public class Human
{
    public string Name { get; }
    public int BirthYear { get; }

    public Human(string name, int birthYear)
    {
        Name = name;
        BirthYear = birthYear;
    }
}

public class Director : Human
{
    public Director(string name, int birthYear) : base(name, birthYear)
    {
    }
}

public class Actor : Human
{
    public Actor(string name, int birthYear) : base(name, birthYear)
    {
    }
}

public class Movie
{
    public string Name { get; }
    public int Year { get; }
    public Director Director { get; }
    public List<Actor> Actors { get; }

    public Movie(string name, int year, Director director, List<Actor> actors)
    {
        Name = name;
        Year = year;
        Director = director;
        Actors = actors;
    }
}

class Program
{
    static void Main()
    {
        Director christopherNolan = new Director("Christopher Nolan", 1970);
        Actor leoDiCaprio = new Actor("Leonardo DiCaprio", 1974);
        Actor ellenPage = new Actor("Ellen Page", 1987);
        Actor cillianMurphy = new Actor("Cillian Murphy", 1976);
        Actor rDowneyJr = new Actor("Robert Downey Jr.", 1965);


        List<Actor> inceptionActors = new List<Actor> { leoDiCaprio, ellenPage };
        List<Actor> oppenheimerActors = new List<Actor> { cillianMurphy, rDowneyJr };
        
        Movie inception = new Movie("Inception", 2010, christopherNolan, inceptionActors);
        Movie oppenheimer = new Movie("Oppenheimer", 2023, christopherNolan, oppenheimerActors);

        Console.WriteLine($"Movie: {inception.Name}");
        Console.WriteLine($"Year: {inception.Year}");
        Console.WriteLine($"Director: {inception.Director.Name}");
        Console.WriteLine("Actors:");
        foreach (var actor in inception.Actors)
        {
            Console.WriteLine($"- {actor.Name}");
        }

        Console.WriteLine($"Movie: {oppenheimer.Name}");
        Console.WriteLine($"Year: {oppenheimer.Year}");
        Console.WriteLine($"Director: {oppenheimer.Director.Name}");
        Console.WriteLine("Actors:");
        foreach (var actor in oppenheimer.Actors)
        {
            Console.WriteLine($"- {actor.Name}");
        }
    }
}