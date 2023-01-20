using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();
        int userInput;
        int sum = 0;
        do
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            String inputNumber = Console.ReadLine();
            userInput = int.Parse(inputNumber);
            numbers.Add(userInput);           
        } while(userInput!=0);

        foreach (int number in numbers){
            sum +=number;
        }

        
        Console.WriteLine(numbers);
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {(float)sum/numbers.Count}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
        Console.WriteLine($"The smallest number is: {numbers.Min()}");
    }
}