using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    internal abstract class Question
    {
        public abstract string Inquiry { get; set; }
        public abstract List<string> Choices { get; set; }
        public abstract string CorrectAnswer { get; set; }

        protected Question(string inquiry, List<string> choices, string correctAnswer)
        {
           Inquiry = inquiry;
           Choices = choices;
           CorrectAnswer = correctAnswer;
        }
    }
}
