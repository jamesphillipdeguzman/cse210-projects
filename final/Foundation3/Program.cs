using System;
using Foundation3;
/* Author: James Phillip K. De Guzman
 * Programming Language: C Sharp or C#
 * Instructor: Brother Duane Richards
 * Date Started: June 15, 2024
 * Date Finished: TBA
 /
/* Rubrics for Foundation 3: Inheritance with Event Planning
 * 1. Abstraction
 *   - Classes exist for the base class and each type of event.
 *
 * 2. Encapsulation
 *   - All member variables are private, or they are protected if a derived class needs direct access.
 *
 * 3. Inheritance Hierarchy
 *   - Each specific type of event is derived from a base class.
 *
 * 4. Inheriting Attributes
 *   - All member variables that could be shared among classes are defined in the base class
 *   (including title, description date, time, and address).
 *
 * 4. Inheriting Behaviours
 *   - All methods that could be shared among classes are defined in the base class (including methods for
 *   getting the standard details and short description).
 *
 * 5. Functionality
 *   - Program runs without errors. Each type of event is created, values set, and methods are used to generate all
 *   required marketing messages (Standard details, Full details, Short description).
 *
 * 6. Style: Whitespace
 *   - Vertical and horizontal whitespace (blank lines, indentation, braces) is correct throughout the program.
 *
 * 7. Naming Conventions
 *   - Classes and methods use TitleCase, member variables use _underscoreCamelCase, local variables use camelCase.
 *
 */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Foundation 3: Inheritance with Event Planning");
        Console.WriteLine("=============================================\n");
        // Create a new Lecture Event
        LectureEvent lectureEvent = new LectureEvent();

        Console.WriteLine(lectureEvent.FullDetails("What is Digital Amnesia?", "The speaker will delve into the topic of digital amnesia and how people can minimize its effect by reducing screen time among the younger generation and also the adults. ", "June 20, 2024", "5:00pm - 6:30pm", "Iloilo Convention Center, Megaworld Boulevard, Iloilo City, PH", "James Phillip De Guzman", 50));
        Console.WriteLine("=============================================\n");

        // Create a new Reception Event
        ReceptionEvent receptionEvent = new ReceptionEvent();

        Console.WriteLine(receptionEvent.StandardDetails("Game Over: James and Angel Temple Marriage", "This is a wedding reception for James and Angel  celebrating their temple marriage with family, friends and guests.", "August 24, 2013", "6:00pm - 8:00pm", "The Church of Jesus Christ of Latter Day Saints, Aurora Blvd. Cnr J. P. Rizal St., Project 4, Quezon City, PH", "bessy1125@gmail.com"));
        Console.WriteLine("=============================================\n");

        // Create a new Outdoor Event
        OutdoorEvent outdoorEvent = new OutdoorEvent();

        Console.WriteLine(outdoorEvent.ShortDescription(" Family 2k-4k Marathon", "This is a fun run for your family. Join us to celebrate family life!", "September 28, 2024", "5:00am - 8:00am", "Freedom Grandstand, Muelle Loney Street, City Proper, Iloilo City, PH", "The weather is sunny and clear. Temperature is around 25 degrees celsius. Perfect for an outdoor family fun run activity!"));
        Console.WriteLine("=============================================\n");

    }
}
