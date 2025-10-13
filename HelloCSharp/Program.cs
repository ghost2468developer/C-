using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to C#");
        Console.Write("Enter you name: ");
        string name = Console.ReadLine();
        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Hello {name}, you are {age} years old");
    }
}