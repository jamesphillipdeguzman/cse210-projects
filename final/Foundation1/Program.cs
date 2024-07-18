using System;
using System.Runtime.CompilerServices;
using Foundation1;
/* Author: James Phillip K. De Guzman
 * Programming Language: C Sharp or C#
 * Instructor: Brother Duane Richards
 * Date Started: June 15, 2024
 * Date Finished: TBA
 /
/* Rubrics for Foundation 1: Abstraction with YouTube Videos
 * 1. Abstraction: Video Class
 *   - A Video class exists and has a way to track the title, author, and length.
 *
 * 2. Abstraction: Comment Class
 *   - A Comment class exists that stores the name of the person and the text of the comment.
 *
 * 3. Class Composition
 *   - The Video class stores a list of Comment class objects.
 *
 * 4. Class Behaviors
 *   - The Video class contains a method that returns the number of comments directly from the way comments
 *     are stored (for example returns the length of the list).
 *
 * 5. Functionality: Object Creation
 *   - Program runs without errors. It correctly creates at least 3 Video objects (including setting their values),
 *    and for each Video creates and sets at least 3 Comment objects (including setting their values).
 *    The Video objects are stored in a list.
 *
 * 6. Functionality: Object Use
 *   - Program runs without errors. It iterates through a list of Video objects and for each one displays the title,
 *    author, length, and number of comments (using the method) and for each video also displays the comments for that
 *    video (include the commenter's name and text).
 *
 * 7. Style: Whitespace
 *   - Vertical and horizontal whitespace (blank lines, indentation, braces) is correct throughout the program.
 *
 * 7. Style: Naming Conventions
 *   - Classes and methods use TitleCase, member variables use _underscoreCamelCase, local variables use camelCase.
 */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Foundation 1: Abstraction with YouTube Videos\n");
        Console.WriteLine("=============================================\n");
        // Create a new video
        Video vid1 = new Video();
        List<Video> videos = new List<Video>();

        // Video 1 include title, author and length of video...
        vid1.SetVideo("Where Faith Lives (EFY 2002 - Cherie Call)", "James De Guzman", "4:01");
        videos.Add(vid1);
        // Display Video 1 to console
        Console.WriteLine(vid1.GetVideoInfo());

        // Add at least 3 videos for Video 1
        Comment com1 = new Comment();
        com1.SetComment("@carolelayne663", "Very nice voice! Lovely song with a wonderful singer and pianist");
        vid1.GetNumberOfComments(com1);

        Comment com2 = new Comment();
        com2.SetComment("@carolelayne663", "Very nicely done!");
        vid1.GetNumberOfComments(com2);

        Comment com3 = new Comment();
        com3.SetComment("@yamyam6170", "Enjoyed recording this, kuya James! Thanks for the opportunity hehe ~ ");
        vid1.GetNumberOfComments(com3);


        // Create a new video
        Video vid2 = new Video();
        List<Video> videos2 = new List<Video>();

        // Video 2 include title, author and length of video...
        vid2.SetVideo("La vie en rose -  Edith Piaf Violin Cover by James", "James De Guzman", "3:22");
        videos2.Add(vid2);
        // Display Video 1 to console
        Console.WriteLine(vid2.GetVideoInfo());

        // Add at least 3 videos for Video 2
        Comment com4 = new Comment();
        com4.SetComment("@MirenMusic", "Go kuya James!!!! :)");
        vid2.GetNumberOfComments(com4);

        Comment com5 = new Comment();
        com5.SetComment("@isaiahmcclure8894", "Good work man! How long have you been playing?");
        vid2.GetNumberOfComments(com5);

        Comment com6 = new Comment();
        com6.SetComment("@jamesphillipdeguzman6495", "Thanks Isaiah.Almost 4 years now.");
        vid2.GetNumberOfComments(com6);

        Comment com7 = new Comment();
        com7.SetComment("@isaiahmcclure8894", "Nice! ~ ");
        vid2.GetNumberOfComments(com7);


        // Create a new video
        Video vid3 = new Video();
        List<Video> videos3 = new List<Video>();

        // Video 3 include title, author and length of video...
        vid3.SetVideo("Do You Hear What I Hear - cover by James and Kyle", "James De Guzman", "4:19");
        videos3.Add(vid3);
        // Display Video 1 to console
        Console.WriteLine(vid3.GetVideoInfo());

        // Add at least 3 videos for Video 2
        Comment com8 = new Comment();
        com8.SetComment("@carmelitadeguzman9663", "Very nice, my son! Excellent rendition and great collaboration");
        vid3.GetNumberOfComments(com8);

        Comment com9 = new Comment();
        com9.SetComment("@amandahugnkiss9882", "Positivity beautiful");
        vid3.GetNumberOfComments(com9);

        Comment com10 = new Comment();
        com10.SetComment("@amandahugnkiss9882", "I love Ed Ames and your rendition was perfect ~ ");
        vid3.GetNumberOfComments(com10);


    }
}
