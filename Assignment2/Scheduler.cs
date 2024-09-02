using Assignment2;

class Scheduler
{
    /// <summary>
    /// Main method which also controls wheter or not to continue after each run
    /// </summary>
    public static void Start()
    {
        bool runAgain = true;
        Console.WriteLine("+++++++++++++ The Scheduler! +++++++++++++++++");
        Console.WriteLine("+++++++++++++ Your work schedule! +++++++++++++++++");
        while (runAgain)
        {
            Console.WriteLine("1 Show a list of the weekends to work.");
            Console.WriteLine("2 Show a list of the nights to work.");
            Console.WriteLine("0 Exit");
            int x = Input.ReadIntegerConsole("Your choice: ");
            if (x == 1)
            {
                ShowList(1, 52, 2);
                Console.WriteLine("------------------------------------------");
            }
            else if (x == 2)
            {
                ShowList(1, 52, 4);
                Console.WriteLine("------------------------------------------");
            }
            else if (x == 0)
                runAgain = false;
        }

    }

    /// <summary>
    /// Given interval 2 or 4 it prints the days the employee should work starting from either 2 or 1.
    /// </summary>

    private static void ShowList(int startWeek, int endWeek, int intervals)
    {
        string output = "";
        if (intervals == 2)
        {
            for (int i = startWeek; i <= endWeek; i++)
            {
                if (i % intervals == 0)
                {
                    output = string.Format("{0}Week\t{1}\t", output, i);

                }
            }
        }
        else if (intervals == 4)
        {
            for (int i = startWeek; i <= endWeek; i++)
            {
                if (i % intervals == 1)
                {
                    output = string.Format("{0}Week\t{1}\t", output, i);

                }
            }

        }
        Console.WriteLine(output);
    }
}
