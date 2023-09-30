using System;

struct Person
{
    public string name;
    public int yearOfBirth;
}

class Program
{
    static void Main()
    {
        Person[] persons = new Person[100];
        int count = 0;
        while (true)
        {
            Console.WriteLine("Enter name and year of birth separated by a comma: ");
            string input = Console.ReadLine();
            if (input == "")
            {
                break;
            }
            string[] parts = input.Split(',');
            persons[count].name = parts[0];
            persons[count].yearOfBirth = int.Parse(parts[1]);
            count++;
        }
        Console.WriteLine($"You entered {count} persons.");
        Console.WriteLine("Persons in order of age:");
        for (int i = 0; i < count; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                if (persons[i].yearOfBirth > persons[j].yearOfBirth)
                {
                    Person temp = persons[i];
                    persons[i] = persons[j];
                    persons[j] = temp;
                }
            }
        }
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{persons[i].name}, {persons[i].yearOfBirth}");
        }
    }
}








