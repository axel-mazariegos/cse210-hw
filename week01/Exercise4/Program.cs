using System;
using System.Collections.Generic; // You need this to use Lists!

class Program
{
    static void Main(string[] args)
    {
        // 1. Create the list
        List<int> numbers = new List<int>();

        Console.WriteLine("\nEnter a list of numbers, type 0 when finished.");
        int userNumber = -1; // Initialize to a non-zero number to start the loop

        // 2. Gather user input
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            // Add the number to the list if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // 3. Perform calculations
        int sum = 0;
        int max = numbers[0];
        int min = int.MaxValue;

        foreach (int number in numbers)
        {
            sum += number; // Add to the sum

            if (number > max) // Check for a new maximum
            {
                max = number;
            }

            if (number < min && number > 0) // Check for a new minimum
            {
                min = number;
            }

        }


        // 4. Calculate the average
        // We cast sum to a float to get a decimal result
        float average = ((float)sum) / numbers.Count;

        // 5. Display the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min}");

        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\n");

    }
}