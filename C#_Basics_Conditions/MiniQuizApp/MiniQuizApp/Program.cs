namespace MiniQuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ques1 = "What is the capatal of VietNam ?";
            string ans1 = "HaNoi";

            //random math question
            Random rd = new Random();
            //random number from 1 to 11
            int num1 = rd.Next(1, 11);
            int num2 = rd.Next(1, 11);
            string ques2 = $"What is {num1} * {num2} ?";
            int ans2 = num1 * num2;

            string ques3 = "What color do you get by mixing blue and yellow ?";
            string ans3 = "Green";

            int score = 0;

            //question 1
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine(ques1);
            string userAns = Console.ReadLine()!.Trim();
            if (userAns.ToLower() == ans1.ToLower())
            {
                Console.WriteLine("Correct answer! + 1 score");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong, the correct answer is " + ans1);
            }

            //question 2
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine(ques2);
            int userAnsInt;
            while (!int.TryParse(Console.ReadLine(), out userAnsInt))
            {
                Console.Write("Answer must be numeric! Please try again: ");
            }
            if (userAnsInt == ans2)
            {
                Console.WriteLine("Correct answer! + 1 score");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong, the correct answer is " + ans2);
            }

            //question 3
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine(ques3);
            userAns = Console.ReadLine()!.Trim();
            if (userAns.ToLower() == ans3.ToLower())
            {
                Console.WriteLine("Correct answer! + 1 score");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong, the correct answer is " + ans3);
            }

            //show score
            Console.WriteLine("------------------------------------------------------------");
            if (score > 0)
            {
                Console.WriteLine($"Congratulation! You got {score} scores!");
            }
            else
            {
                Console.WriteLine("Oops, hope to have best score next turn!");
            }

            Console.ReadKey();
        }
    }
}
