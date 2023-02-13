using System;

class Program
{
    static void Main(string[] args)
    {        
        Fraction f1 = new Fraction();
        f1.SetTop(1);        
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction();
        f2.SetTop(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction();
        f3.SetTop(3);
        f3.SetBottom(4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction();
        f4.SetTop(1);
        f4.SetBottom(3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Console.WriteLine("{0:N4}", num);
    }
}