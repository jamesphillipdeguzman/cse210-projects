using System;
using System.Numerics;
using System.Xml;

class Program
{
    static void Main()
    {
        string[,] myMatrix = new string[5, 3]
        {
            {"1", "2", "3"},
            {"-+-----", "+------", "+-"},
            {"4", "5", "6"},
            {"-+-----", "+------", "+-"},
            {"7", "8", "9"},
        };
        PrintMatrix(myMatrix);
        Console.Write("Enter a number on the board: ");
        string boardNum = Console.ReadLine();
        Console.Write("Enter an 'x' or 'o' on the board: ");
        string newChar = Console.ReadLine();
        ReplaceCharacterInMatrix(myMatrix, boardNum, newChar);
        PrintMatrix(myMatrix);


    }


    static void PrintMatrix(string[,] myMatrix)
    {
        for (int i = 0; i < myMatrix.GetLength(0); i++) // Loop through rows. Note: GetLength(0) refers to the first dimension (i.e., rows)
        {
            for (int j = 0; j < myMatrix.GetLength(1); j++) // Loop through columns Note: GetLength(1) refers to the second dimension (i.e., columns)
            {
                Console.Write(myMatrix[i, j] + "\t");
            }
            Console.WriteLine(); // Create a new line after printing the matrix row by row
        }
    }

    static void ReplaceCharacterInMatrix(string[,] myMatrix, string boardNum, string newChar)
    {
        for (int i = 0; i < myMatrix.GetLength(0); i++) // Loop through rows
        {
            for (int j = 0; j < myMatrix.GetLength(1); j++) // Loop through columns
            {
                if (myMatrix[i, j] == boardNum)  // replace the chosen number with the character 'x' or 'o'
                {
                    myMatrix[i, j] = newChar;
                }
            }
        }
    }

}
