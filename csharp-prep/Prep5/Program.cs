using System;

class Program
{
    
    static void Main(string[] args)
    {
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program! ");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string inputName = Console.ReadLine();
        return inputName;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number:");
        string inputNumber = Console.ReadLine();
        int number = int.Parse(inputNumber);
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number *number;
        return square;
    }

    static void DisplayResult(string userName, int squareNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
    }

}