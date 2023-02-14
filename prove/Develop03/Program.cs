class Program
{
    public static Scripture myScripture = new Scripture("2 Peter 1:5-7","And beside this, giving all adiligence, add to your faith virtue; and to virtue knowledge; And to knowledge temperance; and to temperance patience; and to patience godliness; And to godliness brotherly kindness; and to brotherly kindness charity. For if these things be in you, and abound, they make you that ye shall neither be barren nor unfruitful in the knowledge of our Lord Jesus Christ.");
	
    static void Main(string[] args)
    {        
        Display();
    }

    static void Display()    
    {        
        int hideCount = 2;
        while(1 == 1)
        {
            Console.Clear();            
            myScripture.DisplayFull();
            Console.WriteLine();
            string userInput = GetInputLine("Press enter to continue, type 'quit' to finish or 'reset' for see all the scripture:");

            if(userInput == "quit")
            {
                break;
            }            
            else if(userInput == "reset")
            {
                myScripture.Reset();
            }
            else
            {
                try
                {
                    try
                    {
                        int newHideCount = int.Parse(userInput);
                        if(newHideCount == 0)
                        {
                            throw new ArgumentNullException();
                        }
                        hideCount = newHideCount;
                    }
                    catch(OverflowException)
                    {
                        throw new ArgumentNullException();
                    }
                    catch(FormatException)
                    {
                        throw new ArgumentNullException();
                    }
                }
                catch(ArgumentNullException)
                {
                    if(myScripture.HideWords(hideCount) == false)
                    {
                        break;
                    }
                }
            }
        }
    }

    public static string GetInputLine(string inputMessage="", bool returnLowerCase = true)
    {
        return GetInput(inputMessage+Environment.NewLine, returnLowerCase);
    }
    public static string GetInput(string inputMessage="", bool returnLowerCase = true)
    {
        Console.Write(inputMessage);
        string userInput = Console.ReadLine();
        if(returnLowerCase)
        {
            return userInput.ToLower();
        }
        return userInput;
    }   
}