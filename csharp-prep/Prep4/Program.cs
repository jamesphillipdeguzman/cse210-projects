using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Enter a list of numbers, type 0 when finished.
        // Enter number: 18
        // Enter number: 36
        // Enter number: 2
        // Enter number: 48
        // Enter number: 6
        // Enter number: 12
        // Enter number: 9
        // Enter number: 0
        // The sum is: 131
        // The average is: 18.714285714285715
        // The largest number is: 48

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int number = 0;
        List<int> numbers = new List<int>();

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            // Add the numbers to the list
            numbers.Add(number);
        } while (number != 0);

        int sum = 0;
        int largestNum = 0;
        int ctr = 0;
        foreach (int num in numbers)
        {
            ctr++;
            sum += num; // get the sum
            if (largestNum < num)
            {
                largestNum = num;
            }


        }
        float avg = (float)sum / (ctr - 1); // type casting sum into float
        Console.WriteLine($"Count is: {ctr - 1}");
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largestNum}");

    }
}
