using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        Console.Write("Please enter your favorite number:  ");
        string faveNumber = Console.ReadLine();
        int userNumber = PromptUserNumber(faveNumber);

        string myName = PromptUserName();
        double num = SquareNumber(userNumber);
        DisplayResult(myName, num);

    }

    // Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    // Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber(string faveNumber)
    {
        int convertedNumber = int.Parse(faveNumber);

        return convertedNumber;
    }

    // Accepts an integer as a parameter and returns that number squared (as an integer)
    static double SquareNumber(int userNum)
    {
        double squared = Math.Pow(userNum, 2);
        return squared;
    }

    // Accepts the user's name and the squared number and displays them
    static void DisplayResult(string fname, double squaredNum)
    {
        Console.Write($"Brother {fname}, the square of your number is {squaredNum}");
    }

}
