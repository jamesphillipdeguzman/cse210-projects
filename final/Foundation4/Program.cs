using System;
using Foundation4;
/* Author: James Phillip K. De Guzman
 * Programming Language: C Sharp or C#
 * Instructor: Brother Duane Richards
 * Date Started: July 15, 2024
 * Date Finished: July 20. 2024
 /
/* Rubrics for Foundation 4: Polymorphism with Exercise Tracking
 * 1. Abstraction
 *   - Classes exist for the base class and each type of activity.
 *
 * 2. Encapsulation
 *   - All member variables are private, or they are protected if a derived class needs direct access.
 *
 * 3. Inheritance
 *   - Each specific type of activity is derived from a base class. The date and length of activity are defined in
 *    the base class and inherited. The unique attributes (distance, speed, number of laps) are NOT stored in
 *    the base class.
 *
 * 4. Polymorphism: Method Overriding
 *   - Virtual methods are defined in the base class for getting distance, speed, and pace. These are
 *    overridden in each derived class.
 *
 * 4. Polymorphism: Using Virtual Methods in the Base Class
 *   - GetSummary method is defined in the base class and calls virtual methods for getting the distance,
*     speed, and pace.
 *
 * 5. Functionality
 *   - Program runs without errors. Instances of each type of activity are created and put into the same list.
 *    GetSummary method is called for each of them AND the correct results are displayed.
 *
 * 6. Style: Whitespace
 *   - Vertical and horizontal whitespace (blank lines, indentation, braces) is correct throughout the program.
 *
 * 7. Style: Naming Conventions
 *   - Classes and methods use TitleCase, member variables use _underscoreCamelCase, local variables use camelCase.
 *
 */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Foundation 4: Polymorphism with Exercise Tracking");
        Console.WriteLine("=============================================\n");
        // Create a new date object
        DateTime currentDate = DateTime.Now;
        string dateText = currentDate.ToString("dd MMMM yy");

        // Activity 1: Running
        string activity1 = "Running";
        int runMinutes = 30;
        double runDistance = 4.8;
        RunningActivity running = new RunningActivity(activity1, dateText, runMinutes, runDistance);
        running.GetSpeed(runDistance, runMinutes);
        running.GetPace(runMinutes, runDistance);
        Console.WriteLine(running.GetSummary());

        // Activity 2: Cycling
        string activity2 = "Cycling";
        int cycleMinutes = 15;
        double cyclePace = 10;
        CyclingActivity cycling = new CyclingActivity(activity2, dateText, cycleMinutes, cyclePace);
        double cycleSpeed = cycling.GetSpeed(cyclePace);
        cycling.GetPace(cycleSpeed);
        cycling.GetDistance(cycleSpeed, cycleMinutes);
        Console.WriteLine(cycling.GetSummary());

        // Activity 3: Swimming
        string activity3 = "Swimming";
        int swimMinutes = 8;
        double numberOfLaps = 25;
        SwimmingActivity swimming = new SwimmingActivity(activity3, dateText, swimMinutes, numberOfLaps);
        double swimDistance = swimming.GetDistance(numberOfLaps);
        swimming.GetSpeed(swimDistance, swimMinutes);

        Console.WriteLine(swimming.GetSummary());


    }
}
