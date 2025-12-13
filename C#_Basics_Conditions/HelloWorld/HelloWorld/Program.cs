using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //input name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine()!;
            //input age
            Console.Write("Enter your age: ");
            int age;
            //check integer format and age must be positive
            while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            {
                Console.Write("Invalid number format! Enter your age again: ");
            }
            //check age condition!!!
            if (18 - age <= 0)
            {
                Console.WriteLine($"Hello {name}! Welcome to C#!");
            } else
            {
                Console.WriteLine($"Sorry {name}! Please comeback after {18 - age} years!");
            }
            Console.ReadKey();
        }
    }
}
