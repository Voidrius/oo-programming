using System;

public class Window
{
    public double Width { get; }
    public double Height { get; }

    public Window(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }

    public double CalculateCircumference()
    {
        return 2 * (Width + Height);
    }

    public double CalculateWoodUsage()
    {

        double frameWidth = 0.1; 
        double frameArea = 2 * frameWidth * (Width + Height);

        return frameArea;
    }

    public double CalculateGlassUsage()
    {

        double glassArea = Width * Height;

        return glassArea;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the width of the window (in meters): ");
        if (double.TryParse(Console.ReadLine(), out double width))
        {
            Console.Write("Enter the height of the window (in meters): ");
            if (double.TryParse(Console.ReadLine(), out double height))
            {
                Window window = new Window(width, height);

                Console.WriteLine($"Area of the window: {window.CalculateArea()} square meters");
                Console.WriteLine($"Circumference of the window: {window.CalculateCircumference()} meters");
                Console.WriteLine($"Wood usage for the frame: {window.CalculateWoodUsage()} square meters");
                Console.WriteLine($"Glass usage for the window: {window.CalculateGlassUsage()} square meters");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid height.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid width.");
        }

        Console.ReadLine();
    }
}
