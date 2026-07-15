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
        }
    }
}
