namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to my calculator!");
            //with some special character like ", ', \ can add \ before to make compiler understand
            Console.WriteLine("I can help you to calculate some \'basic\' operation !");
            Console.Write("Please enter you name: ");
            string name = Console.ReadLine()!;
            Console.WriteLine("Hello {0}!", name);

            //#pragma warning disable
            //input number
            int num1, num2;
            Console.Write("Enter number 1: ");
            while(!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Try again number 1: ");
            }
            Console.Write("Enter number 2: ");
            while(!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Try again number 2: ");
            }

            //int put operator
            Console.Write("Enter operator (+ - * /): ");
            char op;
            while (!char.TryParse(Console.ReadLine(), out op) || !"+-*/".Contains(op))
            {
                Console.Write("Invalid operator. Please try again (+ - * /): ");
            }

            //execute 
            Console.WriteLine("----------------------------");
            switch (op)
            {
                case '+':
                    Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero!");
                    }
                    else
                    {
                        Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
                    }
                    break;
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
