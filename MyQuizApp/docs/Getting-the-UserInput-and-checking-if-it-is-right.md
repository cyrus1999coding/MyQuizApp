# Getting the UserInput and checking if it is right

```cs

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

        public void DisplayQuestion(Question question)
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
            👇
            if (GetUserChoice() == question.CorrectAnserIndex)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
            👆
        }
        👇
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
        👆
    }
}

```

```console
     .-')                    ('-.    .-')    .-') _                            .-') _
   .(  OO)                 _(  OO)  ( OO ). (  OO) )                          ( OO ) )
  (_)---\_)   ,--. ,--.   (,------.(_)---\_)/     '._ ,-.-')  .-'),-----. ,--./ ,--,'
  '  .-.  '   |  | |  |    |  .---'/    _ | |'--...__)|  |OO)( OO'  .-.  '|   \ |  |\
 ,|  | |  |   |  | | .-')  |  |    \  :` `. '--.  .--'|  |  \/   |  | |  ||    \|  | )
(_|  | |  |   |  |_|( OO )(|  '--.  '..`''.)   |  |   |  |(_/\_) |  |\|  ||  .     |/
  |  | |  |   |  | | `-' / |  .--' .-._)   \   |  |  ,|  |_.'  \ |  | |  ||  |\    |
  '  '-'  '-.('  '-'(_.-'  |  `---.\       /   |  | (_|  |      `'  '-'  '|  | \   |
   `-----'--'  `-----'     `------' `-----'    `--'   `--'        `-----' `--'  `--'
What is the capital of Germany
     1. Paris
     2. Berling
     3. London
     4. Madrid
Your anser (number):2
Correct!
```

- `while (!int.TryParse(input, out choice))` :
  As long as this wrok the code will run .

- This is not going to be how our final application is going to look like but we;re just adding  
  These to the `DisplayQuestion` `Method` so that we can quickly check that the `GetUserChoice` `Method`  
  Is working correctly or not.

Next we're going to take care of Desining how to start the quiz correctly . ( Displaying multiple question ) .
after each answer we given it can start with the next question