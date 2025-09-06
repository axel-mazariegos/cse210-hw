using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Generate the magic number.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        // 2. Initialize the guess to start the loop.
        int guess = 0;
        int guessCount = 0;
        Console.Write("\n");

        // 3. Loop as long as the guess is incorrect.
        while (guess != magicNumber)
        {
            // 4. Ask for the user's guess and convert it to a number.
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            // 4a. Provide hints to the user.
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            guessCount++;
        }

        // 5. The loop is over, so they guessed it!
        Console.WriteLine("You guessed it!");
        Console.WriteLine($"It took you {guessCount} guesses.\n");
    }
}