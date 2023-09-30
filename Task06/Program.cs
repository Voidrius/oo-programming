namespace Task06
{
    public class Heater
    {
        private bool isOn;
        private int temperature;
        private double humidity;

        public bool IsOn
        {
            get { return isOn; }
            set { isOn = value; }
        }

        public int Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        public double Humidity
        {
            get { return humidity; }
            set { humidity = value; }
        }

        public Heater()
        {
            isOn = false;
            temperature = 0;
            humidity = 0.0;
        }

        public void TurnOn()
        {
            isOn = true;
        }

        public void TurnOff()
        {
            isOn = false;
        }

        public void AdjustTemperature(int newTemperature)
        {
            if (newTemperature >= 0)
            {
                temperature = newTemperature;
            }
            else
            {
                Console.WriteLine("Invalid temperature value. Temperature must be non-negative.");
            }
        }

        public void AdjustHumidity(double newHumidity)
        {
            if (newHumidity >= 0.0 && newHumidity <= 100.0)
            {
                humidity = newHumidity;
            }
            else
            {
                Console.WriteLine("Invalid humidity value. Humidity must be between 0 and 100.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Heater saunaHeater = new Heater();

            while (true)
            {
                Console.WriteLine("Sauna Heater Control Menu:");
                Console.WriteLine("1. Turn On");
                Console.WriteLine("2. Turn Off");
                Console.WriteLine("3. Adjust Temperature");
                Console.WriteLine("4. Adjust Humidity");
                Console.WriteLine("5. View Status");
                Console.WriteLine("6. Exit");

                Console.Write("Enter the desired operation (1-6): ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            saunaHeater.TurnOn();
                            Console.WriteLine("Sauna Heater turned on.");
                            break;
                        case 2:
                            saunaHeater.TurnOff();
                            Console.WriteLine("Sauna Heater turned off.");
                            break;
                        case 3:
                            Console.Write("Enter new temperature (in °C): ");
                            if (int.TryParse(Console.ReadLine(), out int newTemp))
                            {
                                saunaHeater.AdjustTemperature(newTemp);
                                Console.WriteLine($"Temperature adjusted to {newTemp}°C.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid temperature input. Temperature must be a valid number.");
                            }
                            break;
                        case 4:
                            Console.Write("Enter new humidity (in %): ");
                            if (double.TryParse(Console.ReadLine(), out double newHumidity))
                            {
                                saunaHeater.AdjustHumidity(newHumidity);
                                Console.WriteLine($"Humidity adjusted to {newHumidity}%.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid humidity input. Humidity must be a valid number.");
                            }
                            break;
                        case 5:
                            Console.WriteLine("Sauna Heater Status:");
                            Console.WriteLine($"Is On: {saunaHeater.IsOn}");
                            Console.WriteLine($"Temperature: {saunaHeater.Temperature}°C");
                            Console.WriteLine($"Humidity: {saunaHeater.Humidity}%");
                            break;
                        case 6:
                            Console.WriteLine("Exiting the program.");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option (1-6).");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid menu choice (1-6).");
                }

                Console.WriteLine();
            }
        }
    }
}





