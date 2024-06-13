using System;
using System.Runtime.CompilerServices;
class Program
{
    public static float LastDigit(float n)
    {
        float ldigit = n % 10;
        // return the last digit
        return ldigit;
    }
    public static void Main(string[] args)
    {
        /**
        A >= 90
        B >= 80
        C >= 70
        D >= 60
        F < 60
        */
        string response;
        response = "yes";
        while (response == "yes")
        {
            Console.Write("Compute letter grade again? [yes/no]: ");
            response = Console.ReadLine();
            response = response.ToLower();
            if (response == "yes")
            {
                Console.Write("Enter your grade: ");
                string input = Console.ReadLine();
                float grade = float.Parse(input);

                // initialize letter to nothing
                string letter = "";

                // if (grade % 10 == 0) {
                //     Console.WriteLine($"The number ends with {grade % 10}");
                // }
                // else {
                //     Console.WriteLine($"The number does not end with 7");
                // }
                //Console.WriteLine(LastDigit(grade));
                if (grade >= 90)
                {
                    letter = "A";
                }
                else if (grade >= 80 && grade <= 89 && LastDigit(grade) == 7)
                {
                    letter = "B+";
                }
                else if (grade >= 80 && grade <= 89 && LastDigit(grade) == 3)
                {
                    letter = "B-";
                }
                else if (grade >= 80 && grade <= 89 && (LastDigit(grade) != 7 || LastDigit(grade) != 3))
                {
                    letter = "B";
                }
                else if (grade >= 70 && grade <= 79 && LastDigit(grade) == 7)
                {
                    letter = "C+";
                }
                else if (grade >= 70 && grade <= 79 && LastDigit(grade) == 3)
                {
                    letter = "C-";
                }
                else if (grade >= 70 && grade <= 79 && (LastDigit(grade) != 7 || LastDigit(grade) != 3))
                {
                    letter = "C";
                }
                else if (grade >= 60 && grade <= 69 && LastDigit(grade) == 7)
                {
                    letter = "D+";
                }
                else if (grade >= 60 && grade <= 69 && LastDigit(grade) == 3)
                {
                    letter = "D-";
                }
                else if (grade >= 60 && grade <= 69 && (LastDigit(grade) != 7 || LastDigit(grade) != 3))
                {
                    letter = "D";
                }
                else
                {
                    letter = "F";
                }

                Console.WriteLine($"You got a grade of {letter}");
                // Console.WriteLine("Show the grade letter for this score? [yes/no]: ");
            }
            else
            {
                Console.WriteLine("Thanks!");
                break;
            }


        }
        /*int grade = int.Parse(Console.ReadLine());
        Console.WriteLine($"The grade is {grade}");
        if (grade >= 90)
        {
            Console.WriteLine("A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("D");
        }
        else {
            Console.WriteLine("F");
        }
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations. You passed!");
        }
        else {
            Console.WriteLine("Study harder and you will become successful!");
        }*/
    }
}
