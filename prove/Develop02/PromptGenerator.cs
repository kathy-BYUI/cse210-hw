using System;

public class PromptGenerator
{

    public int _numberQuestion;
    
    public List<string> _questions = new List<string>();

    public int _userOption = 0;    

    public string _promt;


    public void DisplauUserOptions()
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
            DisplauUserOptions();
            Console.WriteLine("What would you like to do?");
            string userOption = Console.ReadLine();
            _userOption = int.Parse(userOption);
            Console.WriteLine($"The selected Option is {_userOption}");
            if (_userOption==1)
            {
                
                DisplayQuestions();
                //He creado una instancia y un objeto para guardar los datos que debe tener una entrada
                //En realidad, éste código debería estar en Entry.cs pero cuando lo intento alla en la función WriteEntry() no puedo obtener nada
                //En la prueba de impresión de aquí sí obtengo los datos correctos
                Entry entry1 = new Entry();
                entry1._fecha = DateTime.Now.ToShortDateString();
                entry1._response = Console.ReadLine();
                entry1._prompt = _promt;
                
                Console.WriteLine("*******************************");
                Console.WriteLine($"fechaaaaaaaaa {entry1._fecha}");
                Console.WriteLine($"prompt {entry1._prompt}");
                Console.WriteLine($"response {entry1._response}");
                Console.WriteLine("*******************************"); 
                
                entry1.WriteEntry();
                
                
            }
            if (_userOption==2)
            {
                
                Entry entry = new Entry();
                entry.DisplayEntry();
            }
        } while (_userOption != 5);     
        
    }

    public void DisplayQuestions()
    
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
        Console.WriteLine(_promt);
    }




}