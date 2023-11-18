using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

class Program
{
    static void Main()
    {
        List<Person> personList = new List<Person>();
        Console.WriteLine("List Collection:");
        Console.WriteLine($"- Adding time: {AddPersonsToList(personList)} ms");
        Console.WriteLine($"- Persons count: {personList.Count}");
        PrintRandomPerson(personList);

        Console.WriteLine("\nPress enter key to continue...");
        Console.ReadLine();

        Dictionary<string, Person> personDictionary = new Dictionary<string, Person>();
        Console.WriteLine("\nDictionary Collection:");
        Console.WriteLine($"- Adding time: {AddPersonsToDictionary(personDictionary)} ms");
        Console.WriteLine($"- Persons count: {personDictionary.Count}");
        PrintRandomPerson(personDictionary);

        Console.WriteLine("\nPress enter key to exit...");
        Console.ReadLine();
    }

    static long AddPersonsToList(List<Person> personList)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        Random random = new Random();
        for (int i = 0; i < 10000; i++)
        {
            string firstName = GenerateRandomName(4, random);
            string lastName = GenerateRandomName(10, random);
            personList.Add(new Person(firstName, lastName));
        }

        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }

    static long AddPersonsToDictionary(Dictionary<string, Person> personDictionary)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        Random random = new Random();
        for (int i = 0; i < 10000; i++)
        {
            string firstName = GenerateRandomName(4, random);
            string lastName = GenerateRandomName(10, random);
            
            while (personDictionary.ContainsKey(firstName))
            {
                firstName = GenerateRandomName(4, random);
            }

            personDictionary.Add(firstName, new Person(firstName, lastName));
        }

        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }

    static void PrintRandomPerson(object personCollection)
    {
        Random random = new Random();

        if (personCollection is List<Person> list)
        {
            Console.WriteLine($"- Random person : {GetRandomPerson(list, random)}");

            int personsToFind = 1000;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < personsToFind; i++)
            {
                string randomFirstName = GenerateRandomName(4, random);
                GetPersonByFirstName(list, randomFirstName);
            }
            stopwatch.Stop();

            Console.WriteLine($"\nFinding persons in collection (by first name):");
            Console.WriteLine($"- Persons tried to find : {personsToFind}");
            Console.WriteLine($"- Total finding time: {stopwatch.ElapsedMilliseconds} ms");
        }
        else if (personCollection is Dictionary<string, Person> dictionary)
        {
            Console.WriteLine($"- Random person : {GetRandomPerson(dictionary.Values, random)}");

            int personsToFind = 1000;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < personsToFind; i++)
            {
                string randomFirstName = GenerateRandomName(4, random);
                GetPersonByFirstName(dictionary.Values, randomFirstName);
            }
            stopwatch.Stop();

            Console.WriteLine($"\nFinding persons in collection (by first name):");
            Console.WriteLine($"- Persons tried to find : {personsToFind}");
            Console.WriteLine($"- Total finding time: {stopwatch.ElapsedMilliseconds} ms");
        }
    }

    static string GetRandomPerson(IEnumerable<Person> personCollection, Random random)
    {
        int randomIndex = random.Next(personCollection.Count());
        Person randomPerson = personCollection.ElementAt(randomIndex);
        return $"{randomPerson.FirstName} {randomPerson.LastName}";
    }

    static void GetPersonByFirstName(IEnumerable<Person> personCollection, string firstName)
    {
        Person foundPerson = personCollection.FirstOrDefault(p => p.FirstName == firstName);
        if (foundPerson != null)
        {
            Console.WriteLine($"- Found person with {firstName} firstname : {foundPerson.FirstName} {foundPerson.LastName}");
        }
    }

    static string GenerateRandomName(int length, Random random)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }
}
