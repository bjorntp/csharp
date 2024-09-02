using Assignment2;

class TemperatureConverter
{

/// <summary>
/// Main method
/// </summary>
    public static void Start()
    {

        int choice = 0;
        do
        {
            DisplayMenu();
            choice = Input.ReadIntegerConsole("Enter number: ");

            if (choice == 1)
            {
                CalculateFahrenheitToCelsius();

            }
            else if (choice == 2)
            {
                CalculateCelsiusToFahrenheit();
            }
        } while (choice != 0);
    }

/// <summary>
/// Converts from fahreinheit to celsius
/// </summary>
    private static void CalculateFahrenheitToCelsius()
    {

        for (double i = 0; i <= 210; i += 10)
        {
            double celsius = (i - 32) * 5 / 9;
            string output = string.Format("{0,16:f2} F = {1,6:f2} C", i, celsius);
            Console.WriteLine(output);
        }

    }

/// <summary>
/// Converts from celsius to fahrenheit and then prints it.
/// </summary>
    private static void CalculateCelsiusToFahrenheit()
    {
        for (double i = 0; i <= 100; i += 10)
        {
            double fahrenheit = 32 + i * 9 / 5;
            string output = string.Format("{0,16:f2} C = {1,6:f2} F", i, fahrenheit);
            Console.WriteLine(output);
        }
    }
    /// <summary>
    /// Show menu
    /// </summary>
    private static void DisplayMenu()
    {
        Console.WriteLine("**************************************");
        string menu = string.Format("{0,23:f2}", "MAIN MENU");
        Console.WriteLine(menu);
        Console.WriteLine("**************************************");
        Console.WriteLine(" Convert Fahrenheit to Celsius\t: 1");
        Console.WriteLine(" Convert Celsius to Fahrenheit\t: 2");
        Console.WriteLine(" Exit the Converter\t\t: 0");
        Console.WriteLine("**************************************");
    }

}
