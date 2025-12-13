namespace Recursion_Fibonanci
{
    internal class Program
    {
        public static long CalculateNthFibonacciRecursive(int n)
        {
            // 1. Base Cases: The termination points of the recursion
            if (n < 0)
            {
                // Return -1 for invalid input (negative position)
                return -1;
            }
            if (n <= 1)
            {
                return n; // F(0) = 0, F(1) = 1
            }

            // 2. Recursive Step: Calls itself twice
            // F(n) = F(n-1) + F(n-2)
            return CalculateNthFibonacciRecursive(n - 1) + CalculateNthFibonacciRecursive(n - 2);
        }

        // Function 2: Prints Fibonacci numbers LESS THAN a given limit (uses Iteration for efficiency)
        public static void PrintFibonacciLessThan(int limit)
        {
            if (limit <= 1)
            {
                Console.WriteLine("The Fibonacci sequence only includes 0 up to this limit.");
                return;
            }

            Console.Write($"\n=> Fibonacci Series less than {limit}: 0 1");

            long a = 0;
            long b = 1;

            // Start calculation from F(2)
            while (true)
            {
                long next = a + b;
                if (next >= limit)
                {
                    break; // Stop when the next number reaches or exceeds the limit
                }
                Console.Write(" " + next);
                a = b;
                b = next;
            }
            Console.WriteLine();
        }

        // Function 3: Main method to control the program flow and menu
        public static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- FIBONACCI PROGRAM MENU (Recursive N-th) ---");
                Console.WriteLine("1. Calculate the N-th Fibonacci number (Uses Recursion).");
                Console.WriteLine("2. Print Fibonacci numbers less than a limit.");
                Console.WriteLine("3. Exit the program.");
                Console.Write("Please enter your choice: ");

                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        Console.Write("\nEnter the position N to find (small non-negative integer, starting from 0): ");
                        if (int.TryParse(Console.ReadLine(), out int position) && position >= 0)
                        {
                            // Call the recursive function
                            long result = CalculateNthFibonacciRecursive(position);

                            if (result != -1)
                            {
                                Console.WriteLine($"\n=> The Fibonacci number at position {position} is: {result}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error: Invalid input or N is negative.");
                        }
                        break;

                    case "2":
                        Console.Write("\nEnter the limit N (positive integer): ");
                        if (int.TryParse(Console.ReadLine(), out int limit) && limit > 0)
                        {
                            PrintFibonacciLessThan(limit);
                        }
                        else
                        {
                            Console.WriteLine("Error: Invalid input or N is not positive.");
                        }
                        break;

                    case "3":
                        running = false;
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
