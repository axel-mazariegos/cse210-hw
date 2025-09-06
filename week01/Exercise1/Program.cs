using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their first name.
        Console.Write("What is your first name? ");
        // Read the input and store it in a variable called "firstName".
        string firstName = Console.ReadLine();

        // Ask the user for their last name.
        Console.Write("What is your last name? ");
        // Read the input and store it in a variable called "lastName".
        string lastName = Console.ReadLine();

        // Use string interpolation ($) to create the final sentence and print it.
        Console.WriteLine($"\nYour name is {lastName}, {firstName} {lastName}.");
    }
}