public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {        
        DisplayAnimation(5);
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplayAnimation(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        DisplayAnimation(5);
       Console.WriteLine($"You have completed another {_duration} " +
            $"seconds of the {_name} Activity.");
        DisplayAnimation(5);
    }

    public void DisplayAnimation(int duration)
    {
        int cycles = duration;
        
        List<string> symbols = new List<string>{"-", "\\", "|", "/"};

        Console.Write(" ");

        for (int i = 0; i < cycles; i++)
        {
            for (int j = 0; j < symbols.Count(); j++)
            {
                Console.Write($"\b \b{symbols[j]}");
                Thread.Sleep(250);
            }
        }
        Console.Write("\b \b\n");
    }

    public void DisplayCountDown(int duration)
    {
        Console.Write(" ");

        for (int i = duration; i > 0; i--)
        {
            Console.Write($"\b \b{i}");
            Thread.Sleep(1000);
        }
        Console.Write("\b \b\n");
    }
}
