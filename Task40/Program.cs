using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SID { get; set; }
    public string Group { get; set; }

    public Student(string firstName, string lastName, string group)
    {
        FirstName = firstName;
        LastName = lastName;
        Group = group;
        SID = GenerateSID();
    }


    private string GenerateSID()
    {
        string initials = $"{FirstName.Substring(0, 1)}{LastName.Substring(0, 1)}";

        int count = MiniPeppi.Students.Count(s => s.SID.StartsWith(initials));

        string runningNumber = (count + 1).ToString("D3");

        return $"{initials}{runningNumber}";
    }
}

class MiniPeppi
{
    public static List<Student> Students = new List<Student>();

    public static void AddStudent(string firstName, string lastName, string group)
    {
        Student newStudent = new Student(firstName, lastName, group);

        if (Students.All(s => s.SID != newStudent.SID))
        {
            Students.Add(newStudent);
            Console.WriteLine($"{newStudent.FirstName} {newStudent.LastName} added successfully. " +
                $"There are now {Students.Count} students in MiniPeppi.");
        }
        else
        {
            Console.WriteLine($"Error: Student with SID {newStudent.SID} already exists.");
        }
    }

    public static void DisplayStudents(string message)
    {
        Console.WriteLine(message);
        foreach (var student in Students)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName} {student.SID} {student.Group}");
        }
        Console.WriteLine();
    }

    public static void DisplayAlphabeticalOrder()
    {
        var sortedStudents = Students.OrderBy(s => s.FirstName).ThenBy(s => s.LastName);
        DisplayStudents("The all students in alphabetical order in the MiniPeppi:");
    }
}

class Program
{
    static void Main()
    {
        MiniPeppi.AddStudent("Hanna", "Husso", "TTV19S1");
        MiniPeppi.AddStudent("Kirsi", "Kernel", "TTV19S2");
        MiniPeppi.AddStudent("Masa", "Niemi", "TTV19S3");
        MiniPeppi.AddStudent("Teppo", "Tester", "TTV19SM");
        MiniPeppi.AddStudent("Allan", "Aalto", "TTV19SMM");

        MiniPeppi.DisplayStudents("The first student in the MiniPeppi:");
        MiniPeppi.DisplayStudents("The last student in the MiniPeppi:");

        MiniPeppi.DisplayStudents("The all 5 students in the MiniPeppi:");

        MiniPeppi.DisplayAlphabeticalOrder();

        Console.WriteLine("Please, give data of new Student:");
        Console.Write("SID: ");
        string sid = Console.ReadLine();
        Console.Write("First name: ");
        string firstName = Console.ReadLine();
        Console.Write("Surname: ");
        string lastName = Console.ReadLine();
        Console.Write("Group: ");
        string group = Console.ReadLine();

        MiniPeppi.AddStudent(firstName, lastName, group);

        MiniPeppi.DisplayStudents("The all students after adding a new student:");
    }
}