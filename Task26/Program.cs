using System;
using System.Collections.Generic;
using System.Linq;

public class Player
{
    public string FirstName { get; }
    public string LastName { get; }
    public string GameLocation { get; }
    public int Number { get; }

    public Player(string firstName, string lastName, string gameLocation, int number)
    {
        FirstName = firstName;
        LastName = lastName;
        GameLocation = gameLocation;
        Number = number;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} ({Number}) - {GameLocation}";
    }
}

public class Team
{
    public string Name { get; }
    public string Hometown { get; }
    public List<Player> Players { get; } = new List<Player>();

    public Team(string team)
    {
        Name = team;
        Hometown = GetHometown(team);
        InitializePlayers();
    }

    private void InitializePlayers()
    {
        switch (Name.ToUpper())
        {
            case "JYP":
                Players.Add(new Player("Player1", "JYP", "Home", 1));
                Players.Add(new Player("Player2", "JYP", "Away", 2));
                Players.Add(new Player("Player3", "JYP", "Home", 3));
                break;

            case "ILVES":
                Players.Add(new Player("PlayerA", "Ilves", "Home", 4));
                Players.Add(new Player("PlayerB", "Ilves", "Away", 5));
                Players.Add(new Player("PlayerC", "Ilves", "Home", 6));
                break;

        }
    }

    private string GetHometown(string team)
    {
        return $"Hometown_{team}";
    }
}

class Program
{
    static void Main()
    {
        Team jypTeam = new Team("JYP");
        Team ilvesTeam = new Team("Ilves");

        Console.WriteLine($"Players for {jypTeam.Name}:");
        DisplayPlayers(jypTeam.Players);

        Console.WriteLine($"\nPlayers for {ilvesTeam.Name}:");
        DisplayPlayers(ilvesTeam.Players);


        Player newPlayer = new Player("NewPlayer", "JYP", "Away", 7);
        jypTeam.Players.Add(newPlayer);
        Console.WriteLine($"\nAdded a new player to {jypTeam.Name}: {newPlayer}");

        Console.WriteLine($"\nUpdated players for {jypTeam.Name}:");
        DisplayPlayers(jypTeam.Players);

        Console.WriteLine($"\nPlayers for {ilvesTeam.Name} (unchanged):");
        DisplayPlayers(ilvesTeam.Players);

        Player playerToRemove = ilvesTeam.Players.FirstOrDefault(p => p.Number == 5);
        if (playerToRemove != null)
        {
            ilvesTeam.Players.Remove(playerToRemove);
            Console.WriteLine($"\nRemoved player from {ilvesTeam.Name}: {playerToRemove}");
        }

        Console.WriteLine($"\nFinal players for {jypTeam.Name}:");
        DisplayPlayers(jypTeam.Players);

        Console.WriteLine($"\nFinal players for {ilvesTeam.Name}:");
        DisplayPlayers(ilvesTeam.Players);
    }

    static void DisplayPlayers(List<Player> players)
    {
        foreach (var player in players)
        {
            Console.WriteLine(player);
        }
    }
}