using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Develop04;

/* Author: James Phillip De Guzman
 * Program Title: Scripture Memorizer
 * Instructor: Brother Duane Richards
 * Date Completed: 7/9/2024
 * Creativity: 1) Added auto save feature for Listing Activity.
 *             2) Added additional menu#4 - which loads their recent Listing activity as a
 *               reminder to the user from last listing activity.
 *             2) Created a musical tune before the user starts each activity besides the default animations.
 *
 */

class Program
{
    static void Main(string[] args)
    {

        // Initialize some variables here...
        string userInput = "";
        int duration = 0;
        string myFileName = "listing.csv";
        // Display menu system to user
        do
        {
            Console.WriteLine(".::Mindfulness by James De Guzman::.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity ");
            Console.WriteLine("2. Start reflecting activity ");
            Console.WriteLine("3. Start listing activity ");
            Console.WriteLine("4. Load listing activity");
            Console.WriteLine("5. Quit ");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine().Trim().ToLower();
            switch (userInput)
            {
                // 1. Start Breathing Activity
                case "1":
                    BreathingActivity breathingActivity =
                    new BreathingActivity("Breathing Activity",
                    "This activity will help you relax by walking you through breathing in and out slowly. \n" +
                    "Clear your mind and focus on your breathing.\n", duration);
                    breathingActivity.Run();
                    breathingActivity.DisplayEndingMessage();
                    break;
                // 2. Start Reflecting Activity
                case "2":
                    ReflectingActivity reflectingActivity =
                    new ReflectingActivity("Reflecting Activity",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. \n" +
                    "This will help you recognize the power you have and how you can use it in other aspects of your life.\n", duration);
                    reflectingActivity.Run();
                    reflectingActivity.DisplayEndingMessage();
                    break;
                // 3. Start Listing Activity
                case "3":
                    ListingActivity listingActivity =
                    new ListingActivity("Listing Activity",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n", duration);
                    listingActivity.Run();
                    listingActivity.DisplayEndingMessage();
                    break;
                // 4. Load Listing Activity
                case "4":

                    if (File.Exists(myFileName))
                    {
                        ListingActivity listContent = new ListingActivity();
                        listContent.LoadFromFile(myFileName);
                    }
                    else
                    {
                        Console.WriteLine(">> Invalid or empty file!");
                        break;
                    }

                    break;

                // 5. Quit Mindfulness program
                case "5":
                    Console.WriteLine("Bye!");
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;

            }

        } while (userInput != "5");
    }

}

