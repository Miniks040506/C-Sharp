namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my app! I will have you to check palindrome number.");
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine()!;
            Console.WriteLine($"Welcome {name} to my app!");

            Console.Write("Enter your number: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Please enter integer number");
            }

            int reverse = 0;
            int temp = number;
            while (temp > 0)
            {
                reverse = reverse * 10 + temp % 10;
                temp /= 10;
            }

            if (reverse == number)
            {
                Console.WriteLine($"{number} is a palindrome number");
            }
            else
            {
                Console.WriteLine($"{number} is not a palindrome number");
            }

            Console.ReadKey();
        }
    }
}
