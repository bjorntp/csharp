using Assignment2;

class MathWork
{
    /// <summary>
    /// Main method
    /// </summary>
    public static void Calculate()
    {
        bool stop = false;
        do
        {
            int n1 = Input.ReadIntegerConsole("Give first number: ");
            int n2 = Input.ReadIntegerConsole("Give second number: ");

            Console.WriteLine(string.Format("**** Them sum of numbers between {0} and {1} is: {2}\n", n1, n2, SumNumbers(n1, n2)));
            PrintEvenNumbers(n1, n2);
            PrintOddNumbers(n1, n2);
            CalculateSquareRoots(n1, n2);

            stop = ExitCalculation();


        } while (stop);



    }
    /// <summary>
    /// Prints all square roots between given integers
    /// </summary>
    private static void CalculateSquareRoots(int num1, int num2)
    {
        Console.WriteLine("\t******* Square Roots ******* ");
        for (int i = num1; i < num2; i++)
        {
            string output = "Sqrt(";
            for (int j = i; j < num2; j++)
            {
                double num = Math.Sqrt(Convert.ToDouble(j));
                output = string.Format(output + "{0:f2}", num);
            }
            Console.WriteLine(output);

        }
    }
    /// <summary>
    /// Promps wheter to stop the calculations and returns a boolean
    /// </summary>
    private static bool ExitCalculation()
    {
        Console.WriteLine("Exit Math work? (y/n)");
        while (true)
        {
            string? c = Console.ReadLine();
            while (c == null)
            {
                c = Console.ReadLine();
            }
            if (c == "y")
            {
                return true;
            }
            else if (c == "n")
            {
                return false;
            }
        }
    }
    /// <summary>
    /// Prints all even numbers within the range of two integers
    /// </summary>
    private static void PrintEvenNumbers(int number1, int number2)
    {
        Console.WriteLine(string.Format("**** Even numbers between {0} and {1}", number1, number2));
        string output = "";
        for (int i = number1; i < number2; i++)
        {
            if (i % 2 == 0)
            {
                output = string.Format("{0}\t{1}", output, i);
            }
        }
        Console.WriteLine(output + "\n");
    }
    /// <summary>
    /// ????
    /// </summary>
    private static void PrintMultiplicationTable()
    {
        // ?
    }
    /// <summary>
    /// Prints all uneven numbers within a range of two integers
    /// </summary>
    private static void PrintOddNumbers(int number1, int number2)
    {
        Console.WriteLine(string.Format("**** Odd numbers between {0} and {1}", number1, number2));
        string output = "";
        for (int i = number1; i < number2; i++)
        {
            if (i % 2 != 0)
            {
                output = string.Format("{0}\t{1}", output, i);
            }
        }
        Console.WriteLine(output + "\n");
    }
    /// <summary>
    /// Returns the sum of all numbers in a range of two integers
    /// </summary>
    public static int SumNumbers(int start, int end)
    {
        int result = 0;
        for (int i = start; i < end; i++)
        {
            result += i;
        }

        return result;

    }
}
