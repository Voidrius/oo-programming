using System;
using System.Collections.Generic;

abstract class Shape
{
    public string Name { get; set; }
    public abstract double Area();
    public abstract double Circumference();
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Name = "Circle";
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public override double Circumference()
    {
        return 2 * Math.PI * Radius;
    }

    public override string ToString()
    {
        return $"{Name} Radius={Radius} Area={Area():F2} Circumference={Circumference():F2}";
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Name = "Rectangle";
        Width = width;
        Height = height;
    }

    public override double Area()
    {
        return Width * Height;
    }

    public override double Circumference()
    {
        return 2 * (Width + Height);
    }

    public override string ToString()
    {
        return $"{Name} Width={Width} Height={Height} Area={Area():F2} Circumference={Circumference():F2}";
    }
}

class Shapes
{
    private List<Shape> shapes;

    public Shapes()
    {
        shapes = new List<Shape>();
    }

    public void AddShape(Shape shape)
    {
        shapes.Add(shape);
    }

    public void PrintShapes()
    {
        foreach (var shape in shapes)
        {
            Console.WriteLine(shape);
        }
    }
}

class Program
{
    static void Main()
    {
        Shapes shapesList = new Shapes();

        Circle circle1 = new Circle(1);
        Circle circle2 = new Circle(2);
        Circle circle3 = new Circle(3);

        shapesList.AddShape(circle1);
        shapesList.AddShape(circle2);
        shapesList.AddShape(circle3);

        Rectangle rectangle1 = new Rectangle(10, 20);
        Rectangle rectangle2 = new Rectangle(20, 30);
        Rectangle rectangle3 = new Rectangle(40, 50);

        shapesList.AddShape(rectangle1);
        shapesList.AddShape(rectangle2);
        shapesList.AddShape(rectangle3);

        shapesList.PrintShapes();

        Console.WriteLine("\nPress enter key to continue...");
        Console.ReadKey();
    }
}
