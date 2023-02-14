public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void RunActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.Write("\nBreath in...");
        DisplayCountDown(2);
        Console.Write("Now breath out...");
        DisplayCountDown(3);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            DisplayCountDown(4);
            Console.Write("Now breath out...");
            DisplayCountDown(6);

        }
    }
}
