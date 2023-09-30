using System;

class Program
{
    static void Main()
    {   // Read users input
        Console.Write("Enter the student's score: ");
        if (int.TryParse(Console.ReadLine(), out int score))
        {   // Run the function and display grade
            int grade = GetGrade(score);
            Console.Write($"Your grade is: {grade}");
        }
        else
        {   // Catch invalid inputs
            Console.Write("Invalid input. Please enter a valid number.");
        }
    }

    // Define GetGrade logic
    static int GetGrade(int score)
    {
        if (score >= 0 && score <= 19)
        {
            return 0;
        }
        else if (score >= 20 && score <= 29)
        {
            return 1;
        }
        else if (score >= 30 && score <= 39)
        {
            return 2;
        }
        else if (score >= 40 && score <= 49)
        {
            return 3;
        }
        else if (score >= 50 && score <= 59)
        {
            return 4;
        }
        else if (score >= 60 && score <= 70)
        {
            return 5;
        }
        else
        {
            Console.Write("Score is out of range (0-70). Defaulting to grade 0.");
            return 0;
        }
    }
}
