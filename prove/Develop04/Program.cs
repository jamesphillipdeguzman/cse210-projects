using System;
using System.Diagnostics;
using Develop04;

class Program
{
    static void Main(string[] args)
    {

        // Initialize some variables here...
        string userInput = "";
        int duration = 0;
        // Display menu system to user


        do
        {
            Console.WriteLine(".::Mindfulness by James De Guzman::.\n");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Start breathing activity ");
            Console.WriteLine("2. Start reflecting activity ");
            Console.WriteLine("3. Start listing activity ");
            Console.WriteLine("4. Quit ");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine().Trim().ToLower();
            switch (userInput)
            {
                case "1":
                    BreathingActivity breathingActivity =
                    new BreathingActivity("Breathing Activity",
                    "This activity will help you relax by walking you through breathing in and out slowly. \n" +
                    "Clear your mind and focus on your breathing.\n", duration);
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity =
                    new ReflectingActivity("Reflecting Activity",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. \n" +
                    "This will help you recognize the power you have and how you can use it in other aspects of your life.\n", duration);
                    reflectingActivity.Run();
                    break;

                case "3":
                    ListingActivity listingActivity =
                    new ListingActivity("Listing Activity",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n", duration);
                    listingActivity.Run();
                    break;
                case "4":
                    Console.WriteLine("Bye!");
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;

            }

        } while (userInput != "4");


    }
}
