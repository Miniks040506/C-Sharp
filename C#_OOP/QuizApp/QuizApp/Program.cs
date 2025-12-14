namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question(
                    "What is the capital of Japan?", //question
                    new string[] {"Paris", "London", "Tokyo", "Berlin"}, //answer list
                    2 // correct answer index
                ),
                new Question(
                    "What is the answer of 11 * 34?", //question
                    new string[] {"334", "344", "374", "314"}, //answer list
                    2 // correct answer index
                ),
                new Question(
                    "Which planet is known as the Red Planet?", // question
                    new string[] { "Earth", "Mars", "Jupiter", "Venus" }, // answer list
                    1 // correct answer index (Mars)
                ),
                new Question(
                    "Which programming language is primarily used with Unity?", // question
                    new string[] { "C#", "Python", "Java", "C++" }, // answer list
                    0 // correct answer index (C#)
                ),
                new Question(
                    "Which keyword is used to create an object in C#?", // question
                    new string[] { "class", "create", "object", "new" }, // answer list
                    3 // correct answer index (new)
                )
            };

            Quiz quiz = new Quiz(questions);
            quiz.StartQuiz();

            Console.ReadKey();
        }
    }
}
