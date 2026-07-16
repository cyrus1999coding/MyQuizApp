# Displaying Multiple Questions and if we are right or wrong

We want build another `method` that will start the quiz and handling quiz questions .

```cs
// Quiz.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace MyQuizApp
{
    internal class Quiz
    {
        private Question[] questions;

        public Quiz(Question[] questions)
        {
            this.questions = questions;
        }

        /// <summary>
        /// Takes care of displaying quiz
        /// </summary>
        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz");
            int questionNumber = 1; // Dispay question numbers 

            foreach (Question question in questions) {
                Console.WriteLine($"Question {questionNumber++}:");
                DisplayQuestion(question);

                int userChoice = GetUserChoice();

                👇
                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Corerct!");
                }
                else
                {
                    //Console.WriteLine($"Worng the correct answer was: {question.CorrectAnserIndex}");
                    Console.WriteLine($"Worng the correct answer was: {question.Answers[question.CorrectAnserIndex]}");
                }
                👆
            }
        }
        👉 public void DisplayQuestion(Question question)
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
        /// Taking the valid User Input 
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

```
- 🔑 Cool thing is in the `Quiz Class` we're using the `IsCorrectAnswer` `Method` in the `Question Class`  ↓  
  ```cs
  // Quiz.cs
  .
  .
  .
                if (question.IsCorrectAnswer(userChoice)👈)
                {
                    Console.WriteLine("Corerct!");
                }
                else
                {
                    //Console.WriteLine($"Worng the correct answer was: {question.CorrectAnserIndex}");
                    Console.WriteLine($"Worng the correct answer was: {question.Answers[question.CorrectAnserIndex]}");
                }
  ```

  ```cs
    // Question.cs

    public bool IsCorrectAnswer(int choice)
    {
        return CorrectAnserIndex == choice;
    }
  ```
  Which checks wheter whatever we entered as an id is correct or not .

- `public void DisplayQuestion(Question question)` :  
  Now we can make sure that we make `DisplayQuestion` `private` because we don't need to  
  use that outside of the `Quiz` `Class`, It takes care of displaying questions in the → `StartQuiz` `Method` .  
  🔑🔑 So we don't need to expose the `Method` to other `Classes` .

```cs
// Program.cs
namespace MyQuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question(
                    "What is the capital of Germany",
                    new string[] {"Paris", "Berling","London","Madrid"},
                    1
                )
            };

            Quiz myQuiz = new Quiz(questions);

            //myQuiz.DisplayQuestion(questions[0]); 
            myQuiz.StartQuiz();

            Console.ReadLine();

            Console.ReadKey();
        }
    }
}

```
- And modify the `Program.cs` :  
  ```cs
    //myQuiz.DisplayQuestion(questions[0]); 
    myQuiz.StartQuiz(); 👈
  ```

And add more questions .

Now we're almost done all we have to do is to display the result .
