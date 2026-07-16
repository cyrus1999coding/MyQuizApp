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

        /// <summary>
        /// takes an integer and check the correctness
        /// </summary>
        /// <param name="choice">an inteter</param>
        /// <returns>returns a boolean value</returns>
        public bool IsCorrectAnswer(int choice)
        {
            return CorrectAnserIndex == choice;
        }
    }
}
