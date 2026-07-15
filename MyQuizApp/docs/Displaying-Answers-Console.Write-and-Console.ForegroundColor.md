# Displaying Answers, Console.Write and Console.ForegroundColor  

Now let's also display the asnwers for that one question .


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

        public void DisplayQuestion(Question question)
        {
            Console.WriteLine(question.QuestionText);

            👇
            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.WriteLine($"{question.Answers[i]}");
            }
            👆
        }
    }
}
```

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

            myQuiz.DisplayQuestion(questions[0]); 

            Console.ReadLine();

            Console.ReadKey();
        }
    }
}

```

```console
What is the capital of Germany
Paris
Berling
London
Madrid
```

So let's make the anser a little bit nicer ( Using `Console Class` Features ) ↓  

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
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{question.Answers[i]}");
            }
        }
    }
}
```
- `Console.ForegroundColor = ConsoleColor.Red;` :  
  `enum System.ConsoleColor` → We're going to see what's 🔑`enum` is  
  Basically It's jsut a `Collection` of colors that we can use .

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
            Console.WriteLine(question.QuestionText);

            👇
            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("     ");
                Console.Write(i+1);
                Console.ResetColor();
                Console.WriteLine($"{question.Answers[i]}");
            }
            👆
        }
    }
}

```

```cosnole 
What is the capital of Germany
     1Paris
     2Berling
     3London
     4Madrid
```