using System;

class Program
{
    static void Main()
    {
        // Step 1: Create a random number
        Random random = new Random();
        int secretNumber = random.Next(1, 11); // between 1 and 10

        int guess = 0;

        Console.WriteLine("🎯 Guess the Number Game!");
        Console.WriteLine("I'm thinking of a number between 1 and 10...");

        // Step 2: Keep looping until the guess is correct
        while (guess != secretNumber)
        {
            Console.Write("Enter your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess < secretNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine("🎉 Correct! You guessed the number!");
            }
        }
    }
}
