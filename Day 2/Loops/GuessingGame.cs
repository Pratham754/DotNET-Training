using System;
namespace Github
{
    public class GuessingGame
    {
        static void Main(string[] args)
        {
            Random random = new();
            int secretNumber = random.Next(1, 101);
            int userGuess = 0;

            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("I have selected a number between 1 and 100. Can you guess it?");

            do
            {
                Console.Write("Enter your guess: ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out userGuess))
                {
                    if (userGuess < secretNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (userGuess > secretNumber)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations! You've guessed the number!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

            } while (userGuess != secretNumber);
        }
    }
}