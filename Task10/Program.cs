using System;
using System.Collections.Generic;
public class Student
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public int Age { get; private set; }
    public int Grade { get; private set; }

    public Student(int id, string name, int age, int grade)
    {
        Id = id;
        Name = name;
        Age = age;
        Grade = grade;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Age: {Age}, Grade: {Grade}";
    }
}


class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student(1, "Alice", 20, 5),
            new Student(2, "Bob", 22, 4),
            new Student(3, "Charlie", 21, 5),
            new Student(4, "David", 23, 3),
            new Student(5, "Eva", 19, 2)
        };

        foreach (var student in students)
        {
            Console.WriteLine(student.ToString());
        }
    }
}
