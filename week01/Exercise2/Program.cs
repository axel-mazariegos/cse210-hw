using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Get the user's grade and convert it to a number.
        Console.Write("\nWhat is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);

        // 2. Determine the letter grade.
        string letter = ""; // Create the letter variable

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // 2.1 Determine the sign grade.
        string sign = ""; // Create the sign variable

        if (percent >= 60 && percent <= 96) // Only assign signs for grades D, C, B, A-
        {
            int lastDigit = percent % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit <= 2)
            {
                sign = "-";
            }
        }


        // Print the letter grade after the if-chain is complete.
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // 3. Check if the user passed and display a message.
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!\n");
        }
        else
        {
            Console.WriteLine("Don't give up! You can do it next time.\n");
        }
    }
}