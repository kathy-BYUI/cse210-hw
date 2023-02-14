public class ReflectionActivity : Activity
{
    private List<string> _reflectionPrompts;
    private List<string> _reflectionQuestions;

    public ReflectionActivity()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
        _reflectionPrompts = new List<string>
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };            
        _reflectionQuestions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };
    }

    public void RunActivity()
    {
        Console.WriteLine("Consider the following prompt:\n");
        string prompt = GetPrompt();
        Console.WriteLine($" --- {prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder of each of the following questions as they related to this experience");
        Console.Write("You may begin in: ");
        DisplayCountDown(5);
        Console.Clear();
    
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
                
        while (DateTime.Now < endTime)
        {
            string question = GetQuestion();
            Console.Write($"> {question} ");
            DisplayAnimation(15);
        }
    }

    public string GetPrompt()
    {
        Random random = new Random();
        int index = random.Next(_reflectionPrompts.Count);
        return _reflectionPrompts[index];
    }

    public string GetQuestion()
    {
        Random random = new Random();
        int index = random.Next(_reflectionQuestions.Count);
        return _reflectionQuestions[index];
    }
}
