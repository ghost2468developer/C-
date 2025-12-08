using System;

class Program
{
    static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\n=== Calculator ===");
            double num1 = ReadNumber("Enter first number: ");
            double num2 = ReadNumber("Enter second number: ");
            Console.Write("Enter operator (+, -, *, /): ");
            string op = Console.ReadLine();
            double result = 0;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num2 != 0 ? num1 / num2 : double.NaN;
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    continue;
            }
            Console.WriteLine($"Result: {result}");
            Console.Write("\nDo another? (y/n): ");
            if (Console.ReadLine().ToLower() != "y")
                running = false;
        }

        Console.WriteLine("Goodbye!");
    }

    static double ReadNumber(string message)
    {
        double value;
        Console.Write(message);

        while (!double.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Invalid number, try again: ");
        }
        return value;
    }
}
