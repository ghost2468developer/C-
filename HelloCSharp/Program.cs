using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 11); // 1 to 10

        int guess = 0;
        int attempts = 0; // 🔹 New: tracks how many times you guess

        Console.WriteLine("🎯 Guess the Number Game!");
        Console.WriteLine("I'm thinking of a number between 1 and 10...");

        while (guess != secretNumber)
        {
            Console.Write("Enter your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++; // 🔹 Increase every time you guess

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
                Console.WriteLine($"🎉 Correct! You guessed it in {attempts} attempts!");
            }
        }
    }
}
