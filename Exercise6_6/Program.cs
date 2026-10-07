for (double celsius = -5; celsius <=40; celsius += 0.5)
{
    double fahrenheit = 32 + (9/5 * celsius);
    Console.WriteLine($"{celsius:F1}°C = {fahrenheit:F1}°F");
}