using System;

public class Elevator
{
    private int _currentFloor = 1;

    public int CurrentFloor => _currentFloor;

    public bool GoTo(int floor, out string message)
    {
        if (floor >= 1 && floor <= 5)
        {
            _currentFloor = floor;
            message = $"Elevator is now in floor: {_currentFloor}";
            return true;
        }
        else
        {
            if (floor < 1)
            {
                message = "Floor value is too low!";
            }
            else
            {
                message = "Floor value is too high!";
            }
            return false;
        }
    }
}

class Program
{
    static void Main()
    {
        Elevator elevator = new Elevator();
        string message;

        Console.WriteLine($"Elevator is now in floor: {elevator.CurrentFloor}");

        do
        {
            Console.Write("Give a new floor number (1-5) > ");
            int newFloor = Convert.ToInt32(Console.ReadLine());

            if (elevator.GoTo(newFloor, out message))
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine(message);
                // Elevator stays on the current floor for invalid input
            }

        } while (true);
    }
}
