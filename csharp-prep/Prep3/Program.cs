using System;

class Program
{
    static void Main(string[] args)
    {
        // Computer will supply the magic number randomly this time around...
        Random randNumber = new Random();
        int magicNumber = randNumber.Next(1, 101);
        int guessNumber;
        int ctr = 0;

        // intro for the game
        Console.WriteLine("---------------------");
        Console.WriteLine("Guess the number");
        Console.WriteLine("---------------------");

        do
        {
            // loop through while user still tries to guess the magic number...
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            // add a counter to count number of times user guessed the magic number...
            ctr += 1;

            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (magicNumber != guessNumber);

        // Prompt to show user the number of times he tried to guess the magic number

        Console.WriteLine($"You guessed {ctr} times.");

        // int magicNumber;
        // int guessNumber;
        // // Ask the user at least once before going into the Do While loop...
        // Console.Write("What is the magic number? ");
        // magicNumber = int.Parse(Console.ReadLine());
        // do
        // {
        //     // loop through while user still tries to guess the magic number...
        //     Console.Write("What is your guess? ");
        //     guessNumber = int.Parse(Console.ReadLine());

        //     if (magicNumber > guessNumber)
        //     {
        //         Console.WriteLine("Higher");
        //     }
        //     else if (magicNumber < guessNumber)
        //     {
        //         Console.WriteLine("Lower");
        //     }
        //     else
        //     {
        //         Console.WriteLine("You guessed it!");
        //     }
        // } while (magicNumber != guessNumber);


    }
}
