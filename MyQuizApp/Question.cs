using System;
using System.Collections.Generic;
using System.Text;

namespace MyQuizApp
{
    internal class Question
    {
        public string QuestionText { get; set; }
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
