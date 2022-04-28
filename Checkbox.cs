using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    internal class Checkbox : Question
    {
        public override string Inquiry { get; set; }
        public override List<string> Choices { get; set; }
        public override string CorrectAnswer { get; set; }
        private readonly string checkboxWarning = "(answer must be in order from top to bottom)";

        public Checkbox(string inquiry, List<string> choices, string correctAnswer) : base(inquiry, choices, correctAnswer)
        {
        }

        public override string ToString()
        {
            string theStr = Inquiry + checkboxWarning + "\n";

            for (int i = 0; i < Choices.Count; i++)
            {
                theStr += $"\t{Choices[i]}\n";
            }

            return theStr;
        }
    }
}
