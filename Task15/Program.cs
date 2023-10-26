using System;

public class Employee
{
    public string Name { get; set; }
    public string Profession { get; set; }
    public decimal Salary { get; set; }

    public override string ToString()
    {
        return $"Employee:\n- Name: {Name}\n- Profession: {Profession}\n- Salary: {Salary}";
    }
}

public class Boss : Employee
{
    public string Car { get; set; }
    public decimal Bonus { get; set; }

    public override string ToString()
    {
        return $"Boss:\n- Name: {Name}\n- Profession: {Profession}\n- Salary: {Salary}\n- Car: {Car}\n- Bonus: {Bonus}";
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee
        {
            Name = "Kirsi Kernel",
            Profession = "Teacher",
            Salary = 1200
        };

        Boss boss = new Boss
        {
            Name = "Hanna Husso",
            Profession = "Head of Institute",
            Salary = 9000,
            Car = "Audi",
            Bonus = 5000
        };

        Console.WriteLine(employee);
        Console.WriteLine();
        Console.WriteLine(boss);

        // Modify Kirsi Kernel's information
        employee.Profession = "Principal Teacher";
        employee.Salary = 2200;

        Console.WriteLine();
        Console.WriteLine(employee);
    }
}