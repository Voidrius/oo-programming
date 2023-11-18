using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Friend
{
    public string Name { get; set; }
    public string Email { get; set; }
}

class MailBook
{
    private readonly List<Friend> friends;

    public IReadOnlyList<Friend> Friends => friends;

    public MailBook()
    {
        friends = LoadFriendsFromFile();
    }

    private List<Friend> LoadFriendsFromFile()
    {
        List<Friend> loadedFriends = new List<Friend>();

        try
        {
            string[] lines = File.ReadAllLines("friends.csv");

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length == 2)
                {
                    loadedFriends.Add(new Friend { Name = parts[0], Email = parts[1] });
                }
            }

            Console.WriteLine($"{loadedFriends.Count} names in the address book:");
            foreach (Friend friend in loadedFriends)
            {
                Console.WriteLine(friend.Name);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No existing friends file found. Creating a new one.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        return loadedFriends;
    }

    public void ShowAllFriends()
    {
        Console.WriteLine("\nAll friends in the address book:");
        foreach (Friend friend in friends)
        {
            Console.WriteLine($"{friend.Name} {friend.Email}");
        }
    }

    public void SearchFriends(string searchTerm)
    {
        var searchResults = friends
            .Where(friend => friend.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (searchResults.Any())
        {
            Console.WriteLine($"\nSearch results for '{searchTerm}':");
            foreach (Friend friend in searchResults)
            {
                Console.WriteLine($"{friend.Name} {friend.Email}");
            }
        }
        else
        {
            Console.WriteLine($"\nNo friends found with '{searchTerm}'.");
        }
    }

    public void AddFriend(string name, string email)
    {
        try
        {
            Friend newFriend = new Friend { Name = name, Email = email };
            friends.Add(newFriend);

            File.AppendAllText("friends.csv", $"{name},{email}\n");

            Console.WriteLine($"Friend {name} added successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}

class Program
{
    static void Main()
    {
        MailBook mailBook = new MailBook();

        Console.Write("\nEnter the name or part of the name of the person you are looking for > ");
        string searchTerm = Console.ReadLine();

        mailBook.SearchFriends(searchTerm);

        mailBook.ShowAllFriends();

        Console.WriteLine("\nProgram completed successfully. Press any key to continue...");
        Console.ReadKey();
    }
}