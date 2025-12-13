namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //There are 3 kinds of basic loops
            //for, while, do-while

            string rocket = "     |\r\n     |\r\n    / \\\r\n   / _ \\\r\n  |.o '.|\r\n  |'._.'|\r\n  |     " +
                "|\r\n ,'|  | |`.\r\n/  |  | |  \\\r\n|,-'--|--'-.|";
            for (int i = 10; i >= 0; i--)
            {
                //clear the console
                Console.Clear();
                Console.WriteLine("counter is " + i);
                Console.WriteLine(rocket);
                rocket = "\r\n" + rocket;
                Thread.Sleep(1000);
            }
            Console.WriteLine("The rocket has landing");
            Console.WriteLine("\n-----------------------------------------------------\n");
            //count sum from 1 to n
            Console.Write("Enter number(n): ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
            {
                Console.WriteLine("n must be numeric and greater than 1");
            }
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of all numbers from 1 to {n} is {sum}");

            // in string \ is an "Escape character"
            // \r\n is CRLF -> \r is Carriage Return and LF is Line Feed
            Console.WriteLine("Now we talk a little bit about Thread.Sleep()    \r\nOk, let's start");

            //Thread.Sleep(int n) is use to freeze the program n milisecond
            Thread.Sleep(2000);
            Console.WriteLine("Wake up");

            Console.ReadKey();

        }
    }
}
