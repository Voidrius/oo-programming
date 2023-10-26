using System;

public class ElectricalDevice
{
    public bool IsOn { get; private set; }
    public float Power { get; private set; }

    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine("Device is ON.");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine("Device is OFF.");
    }

    public void SetPower(float power)
    {
        Power = power;
        Console.WriteLine($"Power set to: {Power} watts.");
    }
}

public class Radio : ElectricalDevice
{
    private int volume;
    private float frequency;

    public void SetVolume(int newVolume)
    {
        if (IsOn)
        {
            volume = newVolume;
            Console.WriteLine($"Volume set to: {volume}");
        }
        else
        {
            Console.WriteLine("Radio is OFF. Cannot set volume.");
        }
    }

    public void SetFrequency(float newFrequency)
    {
        if (IsOn)
        {
            if (newFrequency >= 2000.0 && newFrequency <= 26000.0)
            {
                frequency = newFrequency;
                Console.WriteLine($"Frequency set to: {frequency}");
            }
            else
            {
                Console.WriteLine("Invalid frequency value. Frequency must be between 2000.0 and 26000.0.");
            }
        }
        else
        {
            Console.WriteLine("Radio is OFF. Cannot set frequency.");
        }
    }

    public override string ToString()
    {
        return $"Radio Settings:\n- IsOn: {IsOn}\n- Power: {Power} watts\n- Volume: {volume}\n- Frequency: {frequency}";
    }
}

class Program
{
    static void Main()
    {
        Radio radio = new Radio();
        Console.WriteLine("Testing Radio Functions:");

        radio.TurnOn();
        radio.SetPower(10.5f);
        radio.SetVolume(5);
        radio.SetFrequency(15000.0f);
        Console.WriteLine(radio);

        radio.TurnOff();
        radio.SetVolume(3);
        radio.SetFrequency(18000.0f);
        Console.WriteLine(radio);
    }
}
