using System;
using System.Threading.Tasks;

public class Tank
{
    private int _crewNumber = 4;
    private float _speed = 0;
    private readonly float _speedMax = 100;

    public string Name { get; set; }
    public string Type { get; set; }

    public int CrewNumber
    {
        get { return _crewNumber; }
        set
        {
            if (value >= 2 && value <= 6)
            {
                _crewNumber = value;
            }
            // else: Do nothing, keep the existing value
        }
    }

    public float Speed => _speed;

    public float SpeedMax => _speedMax;

    public void AccelerateTo(float targetSpeed)
    {
        if (targetSpeed >= 0 && targetSpeed <= _speedMax)
        {
            _speed = targetSpeed;
        }
        else Console.WriteLine($"Can't accelerate to {targetSpeed}, invalid value");
    }

    public void SlowTo(float targetSpeed)
    {
        if (targetSpeed >= 0 && targetSpeed <= _speedMax)
        {
            _speed = targetSpeed;
        }
        else Console.WriteLine($"Can't decelerate to {targetSpeed}, invalid value");
    }
}


class TestTank
{
    static void Main()
    {
        Tank tank = new Tank();
        tank.Name = "Abrams";
        tank.Type = "Main Battle Tank";

        // Testing CrewNumber property
        tank.CrewNumber = 5;
        Console.WriteLine($"Crew Number: {tank.CrewNumber}");

        // Testing AccelerateTo method
        tank.AccelerateTo(50);
        Console.WriteLine($"Current Speed: {tank.Speed}");

        // Attempting to set invalid speed
        tank.AccelerateTo(120);
        Console.WriteLine($"Current Speed (after invalid attempt): {tank.Speed}");

        // Testing SlowTo method
        tank.SlowTo(30);
        Console.WriteLine($"Current Speed (after slowing down): {tank.Speed}");

        // Attempting to set invalid speed
        tank.SlowTo(-10);
        Console.WriteLine($"Current Speed (after invalid attempt to slow down): {tank.Speed}");
    }
}
