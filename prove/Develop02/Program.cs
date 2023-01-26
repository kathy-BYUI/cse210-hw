using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Journal");
        PromptGenerator option = new PromptGenerator();    
        option.ChooseOptions(); 
    }
}