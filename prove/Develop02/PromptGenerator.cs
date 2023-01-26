using System;
public class PromptGenerator
{

    public int _numberQuestion;
    
    public List<string> _questions = new List<string>();

    public int _userOption = 0;    

    public string _promt;

    private Journal journal = new Journal();


    public void DisplayUserOptions()
    {
        Console.WriteLine("Welcome to the journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }

    public void ChooseOptions()
    {
        do 
        {
            DisplayUserOptions();
            Console.WriteLine("What would you like to do?");
            string userOption = Console.ReadLine();
            _userOption = int.Parse(userOption);
            switch (_userOption)
            {
                case 1: { 
                    _promt = GetQuestions();
                    Console.WriteLine(_promt);
                    Entry entry1 = new Entry();
                    entry1._fecha = DateTime.Now.ToShortDateString();
                    entry1._prompt = _promt;
                    entry1._response = Console.ReadLine();                    
                    journal.AddNewEntry(entry1);
                } break; 
                case 2: journal.DisplayJourney(); break;  
                case 3: {
                    Console.WriteLine("What is the name of the file that you can open?");
                    journal._fileName  = Console.ReadLine();  
                    journal.LoadFromFile();
                    } break;              
                case 4: {
                    Console.WriteLine("Write a name for your file:");
                    journal._fileName  = Console.ReadLine();  
                    journal.SaveToFile();
                    }; break;                
            }
            
        } while (_userOption != 5);     
        
    }
    public String GetQuestions()
    
    {
        Random randomNumber = new Random();
        _numberQuestion = randomNumber.Next(1,5);
        if(_numberQuestion==1)
        {
            _promt = "Who was the most interesting person I interacted with today?";            
        }
        else if(_numberQuestion==2)
        {
            _promt = "What was the best part of my day?";            
        }
        else if(_numberQuestion==3)
        {
            _promt = "How did I see the hand of the Lord in my life today?";            
        }
        else if(_numberQuestion==4)
        {
            _promt = "What was the strongest emotion I felt today?";            
        }
        else
        {
            _promt = "If I had one thing I could do over today, what would it be?";            
        }
        return _promt;
    }
}