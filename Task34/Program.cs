using Microsoft.VisualStudio.TestTools.UnitTesting;

public class ArrayCalculator
{
    public static double Sum(double[] array)
    {
        return array.Sum();
    }

    public static double Average(double[] array)
    {
        return array.Any() ? array.Average() : 0;
    }

    public static double Min(double[] array)
    {
        return array.Any() ? array.Min() : 0;
    }

    public static double Max(double[] array)
    {
        return array.Any() ? array.Max() : 0;
    }
}

[TestClass]
public class ArrayCalculatorTests
{
    [TestMethod]
    public void Sum_ShouldCalculateSumCorrectly()
    {
        double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
        double expected = 25.6;

        double result = ArrayCalculator.Sum(array);

        Assert.AreEqual(expected, result, 0.001);
    }

    [TestMethod]
    public void Average_ShouldCalculateAverageCorrectly()
    {
        double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
        double expected = 3.657;

        double result = ArrayCalculator.Average(array);

        Assert.AreEqual(expected, result, 0.001);
    }

    [TestMethod]
    public void Min_ShouldReturnMinValue()
    {
        double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
        double expected = -4.5;

        double result = ArrayCalculator.Min(array);

        Assert.AreEqual(expected, result, 0.001);
    }

    [TestMethod]
    public void Max_ShouldReturnMaxValue()
    {
        double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
        double expected = 12.0;

        double result = ArrayCalculator.Max(array);

        Assert.AreEqual(expected, result, 0.001);
    }
}

class Program
{
    static void Main()
    {
        double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };

        Console.WriteLine($"Sum = {ArrayCalculator.Sum(array):F2}");
        Console.WriteLine($"Ave = {ArrayCalculator.Average(array):F2}");
        Console.WriteLine($"Min = {ArrayCalculator.Min(array):F2}");
        Console.WriteLine($"Max = {ArrayCalculator.Max(array):F2}");

        Console.WriteLine("\nPress enter key to continue...");
        Console.ReadLine();
    }
}
