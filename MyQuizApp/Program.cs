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
                ),
                    new Question(
                    "What is 2 + 2",
                    new string[] {"3", "4" ,"5", "6"},
                    1
                ),
                    new Question(
                   " Who wrote 'Hemlet' ?",
                    new string[] {"goethe", "Auston", "Shakespeare", "Dickens"},
                    2
                ),
            };

            Quiz myQuiz = new Quiz(questions);

            //myQuiz.DisplayQuestion(questions[0]); 
            myQuiz.StartQuiz();

            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
