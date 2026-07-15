# Displaying Questions

Now that we've seen the `this` Keyword let's keep going with the question displaying feature .

```cs
// Quiz.cs

namespace MyQuizApp
{
    internal class Quiz
    {
        private Question[] questions;

        public Quiz(Question[] questions)
        {
            this.questions = questions;
        }

        private void DisplayQuestion(Question question)
        {
            Console.WriteLine(question.QuestionText 👈);
        }
    }
}
```

```cs
// Question.cs

namespace MyQuizApp
{
    internal class Question
    {
        public string QuestionText { get; set; } 👈
        public string[] Answers { get; set; }
        public int CorrectAnserIndex { get; set; }

        public Question(string questionText, string[] answer, int correctAnserIndex)
        {
            QuestionText = questionText;
            Answers = answer;
            CorrectAnserIndex = correctAnserIndex;
        }

        public bool IsCorrectAnswer(int choice)
        {
            return CorrectAnserIndex == choice;
        }
    }
}
```

- `private void DisplayQuestion(Question question)` :  
  It's `private`, so we can't use it inside the `Program.cs` file, so we'll make it `public` for a second  
  So we can test it .


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

            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
```
- So we're using the `new` **Keyword** to 🔑`A-locate` space in the  🔑`Heep` ( In `Memory` ) for a  
  `New Question[]`.
- Then we add 1 Question so we can test our application 
- Then we have this ↓  
  ```cs
    Question[] questions = new Question[]
    {
        new Question(
            "What is the capital of Germany",
            new string[] {"Paris", "Berling","London","Madrid"},
            1
        )
    };
  ```
  - We creating a new Entry of a Question Object, We've not seen it before because whenever  
    we used `Arrays` so far we just used `default DataTypes` ( string, int, bool ... )  
    🔑 But this time we're using a `DataType` of a `Class` ( of a `Question` `Class` ) .

Now let's display the first question :  

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

            myQuiz.DisplayQuestion(questions[0]); 👈

            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
```

```console
What is the capital of Germany
```

in next step we're going to Modify our application to do it in the correct way . 