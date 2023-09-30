public class Television
{
    public bool IsOn { get; private set; }
    public int Volume { get; private set; }
    public int Channel { get; private set; }
    public int Brightness { get; private set; }
    public int Contrast { get; private set; }

    public Television()
    {
        IsOn = false;
        Volume = 25; 
        Channel = 1; 
        Brightness = 50; 
        Contrast = 50; 
    }

    public void TurnOn()
    {
        IsOn = true;
    }

    public void TurnOff()
    {
        IsOn = false;
    }

    public void SetVolume(int volume)
    {
        if (volume >= 0 && volume <= 100)
        {
            Volume = volume;
        }
        else
        {
            Console.WriteLine("Invalid volume value. Volume must be between 0 and 100.");
        }
    }

    public void SetChannel(int channel)
    {
        if (channel > 0)
        {
            Channel = channel;
        }
        else
        {
            Console.WriteLine("Invalid channel value. Channel must be greater than 0.");
        }
    }

    public void SetBrightness(int brightness)
    {
        if (brightness >= 0 && brightness <= 100)
        {
            Brightness = brightness;
        }
        else
        {
            Console.WriteLine("Invalid brightness value. Brightness must be between 0 and 100.");
        }
    }

    public void SetContrast(int contrast)
    {
        if (contrast >= 0 && contrast <= 100)
        {
            Contrast = contrast;
        }
        else
        {
            Console.WriteLine("Invalid contrast value. Contrast must be between 0 and 100.");
        }
    }

    public override string ToString()
    {
        return $"Television: IsOn={IsOn}, Volume={Volume}, Channel={Channel}, Brightness={Brightness}, Contrast={Contrast}";
    }
}
class Program
{
    static void Main()
    {
        Television tv = new Television();

        // Adjust television properties
        tv.TurnOn();
        tv.SetVolume(75);
        tv.SetChannel(5);
        tv.SetBrightness(70);
        tv.SetContrast(60);

        // Display television status
        Console.WriteLine(tv.ToString());

        // Turn off the television
        tv.TurnOff();
        Console.WriteLine("Television turned off.");
    }
}