using System;

class Program
{
    // Create ONE Random object for the whole program
    static Random random = new Random();

    static void Main(string[] args)
    {
        string playAgain = "yes";

        // Main game loop
        while (playAgain.ToLower() == "yes")
        {
            PlayGame();

            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine().Trim().ToLower();
        }

        Console.WriteLine("Thanks for playing!");
    }

    static void PlayGame()
    {
        // Generate random number between 1 and 100
        int magicNumber = random.Next(1, 101);

        int guess = 0;
        int numberOfGuesses = 0;

        // Loop until guessed correctly
        while (guess != magicNumber)
        {
            // Get valid user input
            while (true)
            {
                Console.Write("What is your guess? ");
                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    break;
                }

                Console.WriteLine("Please enter a valid number.");
            }

            numberOfGuesses++;

            // Give feedback
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

        Console.WriteLine($"It took you {numberOfGuesses} guesses.");
        Console.WriteLine();
    }
}
