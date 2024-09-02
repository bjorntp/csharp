using Assignment2;

class StringFunctions
{
    /// <summary>
    /// Main method
    /// </summary>
    public static void Start()
    {

        bool runAgain = false;

        do
        {
            string input = ReadInputString();
            DisplayStringLengthInfo(input);
            PredictMyDay();
            runAgain = AskToRunAgain();

        } while (runAgain);
    }
    /// <summary>
    /// Read a line of text and returns it
    /// </summary>
    private static string ReadInputString()
    {
        Console.WriteLine("Write a text with any number of characters and press Enter.\nYou can even copy text from a file and paste it here!");
        string? input = Console.ReadLine();
        while (input == null)
        {
            input = Console.ReadLine();
        }
        return input;
    }
    /// <summary>
    /// Print given string in all caps and prints the number of characters in the string
    /// </summary>
    private static void DisplayStringLengthInfo(string input)
    {
        Console.WriteLine("\n ---- STRING LENGTH ----\n");
        Console.WriteLine(input.ToUpper());

        Console.WriteLine(input.Length);
    }

    /// <summary>
    /// Prints a specific string depending on the input from the user
    /// </summary>
    private static void PredictMyDay()
    {

        int choice = Input.ReadIntegerConsole("Let me predict your day! Select a number between 1 and 7: ");
        switch (choice)
        {
            case 1:
                Console.WriteLine("Keep calm on Mondays! You can fall apart!");
                break;
            case 2:
                Console.WriteLine("Tuesdays and Wednesdays break your heart!");
                break;
            case 3:
                Console.WriteLine("Tuesdays and Wednesdays break your heart!");
                break;
            case 4:
                Console.WriteLine("Thursday is your lucky day, don't wait for Friday!");
                break;
            case 5:
                Console.WriteLine("Friday, you are in love"!);
                break;
            case 6:
                Console.WriteLine("Saturday, do nothing and to plenty of it");
                break;
            case 7:
                Console.WriteLine("And Sunday always comes too soon!");
                break;
            default:
                Console.WriteLine("No day? A good day but it doesn't exist!");
                break;
        }
    }
    /// <summary>
    /// Prompts the user to keep going and returns a boolean
    /// </summary>
    private static bool AskToRunAgain()
    {
        Console.WriteLine("Do you want to run again? (j/n)");
        while (true)
        {
            string? c = Console.ReadLine();
            while (c == null)
            {
                c = Console.ReadLine();
            }
            if (c == "j")
            {
                return true;
            }
            else if (c == "n")
            {
                return false;
            }
        }
    }

}
