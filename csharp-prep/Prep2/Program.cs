using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's your percentage percentage?");
        string percentagePercent = Console.ReadLine();
        int percentage = int.Parse(percentagePercent);
        char grade;
        // if(percentage>=90)
        // {
        //     Console.WriteLine("Your percentage is A");         
        // }
        // else if(percentage>=80 && percentage<90)
        // {
        //     Console.WriteLine("Your percentage is B");         
        // }
        // else if(percentage>=70 && percentage<80)
        // {
        //     Console.WriteLine("Your percentage is C");         
        // }
        // else if(percentage>=60 && percentage<70)
        // {
        //     Console.WriteLine("Your percentage is D");         
        // }
        // else
        // {
        //     Console.WriteLine("Your percentage is F");         
        // } 
        if(percentage>=90)
        {
            grade = 'A';
        }
        else if(percentage>=80 && percentage<90)
        {
            grade = 'B';
        }
        else if(percentage>=70 && percentage<80)
        {
            grade = 'C';
        }
        else if(percentage>=60 && percentage<70)
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        } 

        Console.WriteLine($"Your percentage is {grade}");


        if(percentage>=70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Sorry, not this time");
        }
    }
}