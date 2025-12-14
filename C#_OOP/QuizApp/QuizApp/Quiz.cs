using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace QuizApp
{
    internal class Quiz
    {
        private Question[] _questions;
        private int _score;

        public Quiz(Question[] questions)
        {
            //when the field and the initial param of 
            //constructor are equals -> use this for the field
            //this -> sth of current object;
            this._questions = questions;
            this._score = 0;
        }

        public void StartQuiz()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("WELCOME TO THE QUIZ GAME!\n");
            Console.ResetColor();
            int questionNumbers = 1;

            foreach (Question question in _questions)
            {
                Console.WriteLine($"Question {questionNumbers++}: ");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();

                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Correct answer!");
                    Console.ResetColor();
                    _score++;
                }
                else
                {
                    Console.Write($"Wrong answer! The correct answer was: ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(question.CorrectAnswerIndex + ". " +
                        question.Answers[question.CorrectAnswerIndex]);
                    //end the foreground color 
                    Console.ResetColor();
                }

                Console.WriteLine();
            }

            DisplayResults();
        }

        private void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Question                                ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++)
            {
                // ForegroundColor -> set to a given color
                //ConsoleColor is an enum of color that contains color to set
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("   ");
                Console.Write(i + 1);
                //end the foreground color 
                Console.ResetColor();
                Console.WriteLine($". {question.Answers[i]}");
            }

        }

        private void DisplayResults()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Results                                 ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine($"Quiz finished. Your score is: {_score} " +
                $"out of {_questions.Length}");

            double percentage = (double)_score / _questions.Length;
            if (percentage >= 0.8)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Excellent Work!");
            }
            else if (percentage >= 0.5)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Good Effort!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Keep practicing!");
            }
            Console.ResetColor();
        }

        private int GetUserChoice()
        {
            Console.Write("Your Answer (number): ");
            string input = Console.ReadLine()!;
            int choice = 0;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.Write("Invalid choice. Please enter a number between 1 and 4: ");
                input = Console.ReadLine()!;
            }

            return choice - 1; // because answer array is 0-3
        }

    }
}
