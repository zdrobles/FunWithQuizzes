using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    internal class TrueFalse : Question
    {
        public override string Inquiry { get; set; }
        public override List<string> Choices { get; set; }
        public override string CorrectAnswer { get; set; }

        public TrueFalse(string inquiry, List<string> choices, string correctAnswer) : base(inquiry, choices, correctAnswer)
        {
        }

        public override string ToString()
        {
            string theStr = Inquiry + "\n\tTrue\n\tFalse";
            return theStr;
        }
    }
}
