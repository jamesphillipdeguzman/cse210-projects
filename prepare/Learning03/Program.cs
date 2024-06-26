using System;
using Learning03;

class Program
{
    static void Main(string[] args)
    {

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());





        // Fraction f1 = new Fraction();
        // Console.WriteLine(f1);

        // Fraction f2 = new Fraction(6);
        // Console.WriteLine(f2);

        // Fraction f3 = new Fraction(6, 7);
        // Console.WriteLine(f3);

        // Fraction f4 = new Fraction();

        // Console.WriteLine($"GetTop() returns {f4.GetTop()}");

        // int top = 3;

        // Console.WriteLine($"SetTop() returns {f4.SetTop(top)}");

        // Console.WriteLine($"GetBottom() returns {f4.GetBottom()}");

        // int bottom = 4;

        // Console.WriteLine($"SetBottom() returns {f4.SetBottom(bottom)}");

        // Console.WriteLine(f4.GetFractionString());

        // Console.WriteLine(f4.GetDecimalValue());

    }


}


