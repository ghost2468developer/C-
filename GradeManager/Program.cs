using System;
using System.Collections.Generic;

class Program
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== Student Grade Manager ===");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Show Average Grade");
            Console.WriteLine("4. Exit");
            Console.Write("Choose option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    ViewStudents();
                    break;
                case "3":
                    ShowAverage();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    static void AddStudent()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        double grade = ReadGrade("Enter grade (0-100): ");

        students.Add(new Student(name, grade));
        Console.WriteLine("Student added!");
    }

    static void ViewStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students yet.");
            return;
        }

        Console.WriteLine("\n--- Students ---");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Name}: {student.Grade}");
        }
    }

    static void ShowAverage()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students yet.");
            return;
        }

        double total = 0;
        foreach (var student in students)
        {
            total += student.Grade;
        }

        Console.WriteLine($"Average Grade: {total / students.Count}");
    }

    static double ReadGrade(string message)
    {
        double value;
        Console.Write(message);

        while (!double.TryParse(Console.ReadLine(), out value) || value < 0 || value > 100)
        {
            Console.Write("Invalid grade, try again: ");
        }

        return value;
    }
}

class Student
{
    public string Name { get; set; }
    public double Grade { get; set; }

    public Student(string name, double grade)
    {
        Name = name;
        Grade = grade;
    }
}
