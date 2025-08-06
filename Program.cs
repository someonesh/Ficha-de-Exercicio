using System;

namespace MyFirstCSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to My First C# Program!");

            Console.Write("What's your name? ");
            string name = Console.ReadLine();

            Console.Write("What year were you born? ");
            int birthYear = int.Parse(Console.ReadLine());

            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;

            Console.WriteLine($"\nHello, {name}!");
            Console.WriteLine($"You are approximately {age} years old.");
        }
    }
}

