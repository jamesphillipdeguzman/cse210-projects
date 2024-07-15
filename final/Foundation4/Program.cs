using System;
/* Author: James Phillip K. De Guzman
 * Programming Language: C Sharp or C#
 * Instructor: Brother Duane Richards
 * Date Started: June 15, 2024
 * Date Finished: TBA
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
    }
}
