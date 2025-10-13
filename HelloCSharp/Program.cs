using System;

class Program
{
    static void Main()
    {
        Console.Write(" How many hours did you work? ");
        string hoursInput = Console.ReadLine();
        double hours = Convert.ToDouble(hoursInput);

        Console.Write("What is your hourly rate? ");
        string rateInput = Console.ReadLine();
        double rate = Convert.ToDouble(rateInput);

        double total = hours * rate;

        Console.WriteLine($"You earned {total} this week");
    }
}