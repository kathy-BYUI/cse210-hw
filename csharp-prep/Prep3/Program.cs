using System;

class Program
{
    static void Main(string[] args)
    {
        int guessNumber;
        string response;
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1,15);
        Console.WriteLine($"What is the magic number? {magicNumber}");
        
        do
        {
            Console.WriteLine("What is the magic number?");
            string numberInput = Console.ReadLine();
            guessNumber = int.Parse(numberInput);

            if(guessNumber<magicNumber)
            {
                response = "Higher";
            }
            else if(guessNumber>magicNumber)
            {
                response = "Lower";
            }
            else 
            {
                response = "You guessed it!";
            }
            Console.WriteLine($"{response}");

        } while(magicNumber != guessNumber);



    }
} 