using System;
using System.Collections.Generic;

class WorkHourEntry
{
    public string Initials { get; set; }
    public DateTime Date { get; set; }
    public string ProjectId { get; set; }
    public double HoursWorked { get; set; }

    public WorkHourEntry(string initials, DateTime date, string projectId, double hoursWorked)
    {
        Initials = initials;
        Date = date;
        ProjectId = projectId;
        HoursWorked = hoursWorked;
    }

    public override string ToString()
    {
        return $"{Date.ToShortDateString()} | {Initials} | Project: {ProjectId} | Hours: {HoursWorked:F2}";
    }
}

class Fellow
{
    public string Initials { get; set; }
    public List<WorkHourEntry> WorkHours { get; } = new List<WorkHourEntry>();

    public Fellow(string initials)
    {
        Initials = initials;
    }

    public void AddWorkHourEntry(DateTime date, string projectId, double hoursWorked)
    {
        WorkHourEntry entry = new WorkHourEntry(Initials, date, projectId, hoursWorked);
        WorkHours.Add(entry);
    }

    public double CalculateTotalHours()
    {
        double totalHours = 0;
        foreach (var entry in WorkHours)
        {
            totalHours += entry.HoursWorked;
        }
        return totalHours;
    }
}
class Company
{
    private List<Fellow> fellows;

    public Company()
    {
        fellows = new List<Fellow>();
    }

    public void AddFellow(string initials)
    {
        Fellow fellow = new Fellow(initials);
        fellows.Add(fellow);
    }

    public void AddWorkHourEntry(string initials, DateTime date, string projectId, double hoursWorked)
    {
        Fellow fellow = fellows.Find(f => f.Initials == initials);
        if (fellow != null)
        {
            fellow.AddWorkHourEntry(date, projectId, hoursWorked);
        }
        else
        {
            Console.WriteLine($"Error: Fellow {initials} not found.");
        }
    }

    public double CalculateTotalHours()
    {
        double totalHours = 0;
        foreach (var fellow in fellows)
        {
            totalHours += fellow.CalculateTotalHours();
        }
        return totalHours;
    }

    public void PrintWorkHoursByFellow(string initials)
    {
        Fellow fellow = fellows.Find(f => f.Initials == initials);
        if (fellow != null)
        {
            Console.WriteLine($"Work hours for Fellow {initials}:");
            foreach (var entry in fellow.WorkHours)
            {
                Console.WriteLine(entry);
            }
        }
        else
        {
            Console.WriteLine($"Error: Fellow {initials} not found.");
        }
    }

    public void PrintTotalHours()
    {
        Console.WriteLine($"Total hours worked by all fellows: {CalculateTotalHours():F2}");
    }
}

class Program
{
    static void Main()
    {
        Company myCompany = new Company();

        myCompany.AddFellow("AB");
        myCompany.AddFellow("CD");
        myCompany.AddFellow("EF");

        myCompany.AddWorkHourEntry("AB", new DateTime(2023, 10, 1), "ProjectA", 8);
        myCompany.AddWorkHourEntry("CD", new DateTime(2023, 10, 1), "ProjectB", 6);
        myCompany.AddWorkHourEntry("EF", new DateTime(2023, 10, 2), "ProjectA", 7);

        myCompany.PrintWorkHoursByFellow("AB");
        myCompany.PrintWorkHoursByFellow("CD");
        myCompany.PrintWorkHoursByFellow("EF");

        myCompany.PrintTotalHours();
    }
}
