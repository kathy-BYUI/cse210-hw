public class ListingActivity : Activity
{
    private List<string> _listingPrompts;
    private int _itemCount;

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _listingPrompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };
        _itemCount = 0;
    }

    public void RunActivity()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:\n");
        string prompt = GetPrompt();
        Console.WriteLine($" --- {prompt} ---");
        Console.Write("\nYou may begin in: ");
        DisplayCountDown(5);
    
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
                
        while (DateTime.Now < endTime)
        {
            Console.Write($"> ");
            Console.ReadLine();
            _itemCount++;
        }

        Console.WriteLine($"You listed {_itemCount} items!");
    }
    public string GetPrompt()
    {
        Random random = new Random();
        int index = random.Next(_listingPrompts.Count);
        return _listingPrompts[index];
    }
}
