using System;
using System.Collections.Generic;
using System.Text;

namespace MyQuizApp
{
    internal class Quiz
    {
        private Question[] _questions;
        private int _score;


        public Quiz(Question[] questions)
        {
            this._questions = questions;
            _score = 0;
        }

        /// <summary>
        /// Takes care of displaying quiz
        /// </summary>
        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz");
            int questionNumber = 1; // Dispay question numbers 

            foreach (Question question in _questions) {
                Console.WriteLine($"Question {questionNumber++}:");
                DisplayQuestion(question);

                int userChoice = GetUserChoice();

             
                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Corerct!");
                    _score++;
                }
                else
                {
                    //Console.WriteLine($"Worng the correct answer was: {question.CorrectAnserIndex}");
                    Console.WriteLine($"Worng the correct answer was: {question.Answers[question.CorrectAnserIndex]}");
                }
            }
            DisplateResult();
        }
        
        private void DisplateResult()
        {
            Console.WriteLine("Result is: ");
            Console.WriteLine($"Quiz finished your score is : {_score} out of {_questions.Length}");

            double percentage = (double)_score / _questions.Length;
            if (percentage >= 0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Exelent work");
            } 
            else if (percentage >= 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good Effort");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Keep Practicing !");
            }
            Console.ResetColor();
        }
        private void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     .-')                    ('-.    .-')    .-') _                            .-') _  \r\n   .(  OO)                 _(  OO)  ( OO ). (  OO) )                          ( OO ) ) \r\n  (_)---\\_)   ,--. ,--.   (,------.(_)---\\_)/     '._ ,-.-')  .-'),-----. ,--./ ,--,'  \r\n  '  .-.  '   |  | |  |    |  .---'/    _ | |'--...__)|  |OO)( OO'  .-.  '|   \\ |  |\\  \r\n ,|  | |  |   |  | | .-')  |  |    \\  :` `. '--.  .--'|  |  \\/   |  | |  ||    \\|  | ) \r\n(_|  | |  |   |  |_|( OO )(|  '--.  '..`''.)   |  |   |  |(_/\\_) |  |\\|  ||  .     |/  \r\n  |  | |  |   |  | | `-' / |  .--' .-._)   \\   |  |  ,|  |_.'  \\ |  | |  ||  |\\    |   \r\n  '  '-'  '-.('  '-'(_.-'  |  `---.\\       /   |  | (_|  |      `'  '-'  '|  | \\   |   \r\n   `-----'--'  `-----'     `------' `-----'    `--'   `--'        `-----' `--'  `--'   ");
            Console.ResetColor();
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("     ");
                Console.Write(i + 1);
                Console.ResetColor();
                Console.WriteLine($". {question.Answers[i]}");
            }

            //if (GetUserChoice() == question.CorrectAnserIndex)
            //{
            //    Console.WriteLine("Correct!");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect");
            //}
        }

        /// <summary>
        /// Taking the User Input and check whether is valid
        /// </summary>
        /// <returns>Returns the user choice as an integer</returns>
        private int GetUserChoice()
        {
            Console.Write("Your anser (number):");
            string input = Console.ReadLine();
            int choice = 0;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4) {
                Console.Write("Invalid choice. please enter a number between 1 and 4:");
                input = Console.ReadLine();
            }

            return choice - 1; // Adjust to 0 indexed array
        }
    }
}
