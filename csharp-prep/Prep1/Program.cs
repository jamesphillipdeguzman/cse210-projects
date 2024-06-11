using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? ");
        String fname = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        String lname = Console.ReadLine();
        Console.Write($"Your name is {lname}, {fname} {lname}.");
    }
}
