using System;
using Learning04;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("James De Guzman", "Fractions");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("James", "Fractions", "7.3", "18-19");
        Console.WriteLine(a2.GetSummary());

        string m = a2.GetHomeWorkList();
        Console.WriteLine(m);

        WritingAssignment a3 = new WritingAssignment("James", "European History", "The Causes of World War II");
        string w = a3.GetWritingInfo();
        Console.WriteLine(w);
    }
}
