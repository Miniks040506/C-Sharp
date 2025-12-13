namespace WhileAndDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While and do while loop
            int count = 0;
            //this is the infinite loop because it can't reached breakpoint 
            //while (count != 0)
            //{
            //    Console.WriteLine("loops");
            //}
            //while check the condition every time, if true -> it will done
            while (count < 10)
            {
                count++;
                Console.WriteLine("The count number is " + count);
            }
            Console.Write("How old are you? ");
            int age;
            while(!int.TryParse(Console.ReadLine(), out age) || age < 0)
            {
                Console.WriteLine("Age must be numeric and positive");
            }
            string check = (age >= 18) ? "Welcome!" : "Go home!";
            Console.WriteLine(check);

            //Guess game
            Console.WriteLine("\n----------------------------------------------------\n");
            Console.WriteLine("Welcome to my guess game!");
            Console.WriteLine("You need to find the secret number!");
            Random random = new Random();
            int secretNumber = random.Next(1, 10);
            int userGuess = 0;
            int counter = 0;

            while (userGuess != secretNumber && counter != 5)
            {
                Console.Write("Enter your guess number: ");
                while (!int.TryParse(Console.ReadLine(), out userGuess) || age < 0)
                {
                    Console.WriteLine("guess must be numeric and from 1 to 100");
                    Console.Write("Try again: ");
                }
                counter++;
                if (userGuess == secretNumber)
                {
                    Console.WriteLine("Congratulation! Your guess number is right!");
                    // use break to end the loop
                    // use continue to skip the turn of loop and jump to next turn
                    break;
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Wrong number! the secret number is smaller than your guess!");
                } else
                {
                    Console.WriteLine("Wrong number! the secret number is greater than your guess!");
                }

                if (counter == 5)
                {
                    Console.WriteLine("Sorry you are lose!");
                }
            }

            //Do while loop 
            //do the code block first then check th condition for next loop

            int index = 0;
            do
            {
                index++;
                // skip odd index
                if (index % 2 == 1)
                {
                    continue;
                }
                Console.WriteLine("Num: " + index);    
            } while (index < 10);


            Console.ReadKey();
        }
    }
}
