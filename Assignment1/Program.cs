using System;

class Program
{
    static void Main(string[] args)
    {
        SetupConsoleWindow();
        Pet pet = new();
        pet.Start();
        TicketSeller ticketseller = new();
        ticketseller.Start();
        Album album = new();
        album.Start();
        Table table = new();
        table.Start();
    }

    static void SetupConsoleWindow()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Title = "My Console Classes";
    }
}
