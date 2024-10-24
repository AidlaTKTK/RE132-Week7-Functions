//Programm eeldab, et kasutaja kirjutab kümnendsüsteemi komadega
//ning ei sisesta rohkem kui ühe tähe, kui valib Celsius või Fahrenheit.

Console.WriteLine("Convert to Celsius or Fahrenheit? (C/F)");
char unitOfMeasurement = Char.Parse(Console.ReadLine().ToLower());

if (unitOfMeasurement == 'f' || unitOfMeasurement == 'c')
{
    Console.WriteLine("Enter the temperature:");
    string temperature = Console.ReadLine();
    float tempNum = 0;
    bool isTemperatureNumber = float.TryParse(temperature, out tempNum);

    if (!isTemperatureNumber)
    {
        Console.WriteLine("Invalid input.");
        return;
    }

    switch (unitOfMeasurement)
    {
        case 'f':
            ConvertToFahrenheit(tempNum);
            break;
        case 'c':
            ConvertToCelsius(tempNum);
            break;
    }
}
else
{
    Console.WriteLine("Invalid unit of measurement.");
}

static void ConvertToFahrenheit(float temp)
{
    float newTemperature = (temp * 9) / 5 + 32;
    Console.WriteLine($"The converted temperature is {newTemperature}°F");
}

static void ConvertToCelsius(float temp)
{
    float newTemperature = (temp - 32) * 5 / 9;
    Console.WriteLine($"The converted temperature is {newTemperature}°C");
}