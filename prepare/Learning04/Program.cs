using System;

class Program
{
    static void Main(string[] args)
    {
        Assigment a1 = new Assigment("Kathy Campos","Good Habits");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Kat Campos","Fractions","7.3","8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAsignment a3 = new WritingAsignment("Lesly Campos","European History","The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}