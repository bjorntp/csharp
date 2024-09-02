using System;

class Program
{
    static void Main(string[] args)
    {
        SetupConsoleWindow();
        TemperatureConverter.Start();
        StringFunctions.Start();
        MathWork.Calculate();
        Scheduler.Start();
    }

    static void SetupConsoleWindow()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Title = "My Console Classes";
    }
}
