public class WashingMachine
{
    private bool isOn;
    private int waterLevel;
    private int temperature;
    private int detergentLevel;

    public bool IsOn => isOn;
    public int WaterLevel => waterLevel;
    public int Temperature => temperature;
    public int DetergentLevel => detergentLevel;

    public WashingMachine()
    {
        isOn = false;
        waterLevel = 0;
        temperature = 0;
        detergentLevel = 0;
    }

    public WashingMachine(int initialWaterLevel, int initialTemperature, int initialDetergentLevel)
    {
        isOn = false;
        waterLevel = initialWaterLevel;
        temperature = initialTemperature;
        detergentLevel = initialDetergentLevel;
    }

    public void TurnOn()
    {
        isOn = true;
    }

    public void TurnOff()
    {
        isOn = false;
    }

    public void SetWaterLevel(int level)
    {
        waterLevel = level;
    }

    public void SetTemperature(int temp)
    {
        temperature = temp;
    }

    public void AddDetergent(int amount)
    {
        detergentLevel += amount;
    }

    public string StartWashing()
    {
        if (isOn && waterLevel > 0 && temperature > 0 && detergentLevel > 0)
        {
            return "Washing machine started!";
        }
        else
        {
            return "Cannot start washing. Please check water level, temperature, and detergent level.";
        }
    }

    public override string ToString()
    {
        return $"Washing Machine: On={isOn}, WaterLevel={waterLevel}, Temperature={temperature}, DetergentLevel={detergentLevel}";
    }
}

class Program
{
    static void Main()
    {
        WashingMachine washingMachine = new WashingMachine();

        Console.Write("Enter initial water level: ");
        if (int.TryParse(Console.ReadLine(), out int initialWaterLevel))
        {
            washingMachine.SetWaterLevel(initialWaterLevel);
        }
        else
        {
            Console.WriteLine("Invalid input for water level. Using default value.");
        }

        Console.Write("Enter initial temperature: ");
        if (int.TryParse(Console.ReadLine(), out int initialTemperature))
        {
            washingMachine.SetTemperature(initialTemperature);
        }
        else
        {
            Console.WriteLine("Invalid input for temperature. Using default value.");
        }

        Console.Write("Enter initial detergent level: ");
        if (int.TryParse(Console.ReadLine(), out int initialDetergentLevel))
        {
            washingMachine.AddDetergent(initialDetergentLevel);
        }
        else
        {
            Console.WriteLine("Invalid input for detergent level. Using default value.");
        }


        washingMachine.TurnOn();


        string washResult = washingMachine.StartWashing();

        Console.WriteLine(washingMachine.ToString());
        Console.WriteLine(washResult);

        // Turn off the washing machine
        washingMachine.TurnOff();
        Console.WriteLine("Washing machine turned off.");
    }
}