# Keyword This

We're going to add some part of the `Quiz Class`, So that we can display a question on the screen .

`this` Keyword :  
has many use case but in our case, is going to say  
> This is going to be in the questions of the `entire Instance` instead of the questions of our `Constructor` .

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
            questions = questions;
        }
    }
}
```
- `private Question[] questions;` :  
  This `questions` is grayed out because it's never used, But we used it here ↓  
  ```cs
    public Quiz(Question[] questions)
    {
        questions = questions; 👈
    }
  ```
  🔑 The thing is we used the same name for the `questions parameter` as the `questions Global private variable`  
  So for this filed → `private Question[] questions;`  
  Now the compiler doesn't know that this questions is supposed to be that question variable,  
  If we want to make sure that it understand it we should add `this.` ↓  
  ```cs
    namespace MyQuizApp
    {
        internal class Quiz
        {
            private Question[] questions; // 🔑private field

            public Quiz(Question[] questions)
            {
                👉this.questions = questions;
            }
        }
    }
  ```
  So it basiaclly saying, we want to use the variable called `questions` that belongs to the  
  `Class Quiz` not the one from the `parameter` that being passed in .