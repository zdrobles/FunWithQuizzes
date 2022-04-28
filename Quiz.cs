using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    internal class Quiz
    {
        public List<Question> QList { get; set; }

        public List<string> CandidateAnswers { get; set; }

        private double NumOfCorrect = 0;
        public Quiz(List<Question> qList)
        {
            QList = qList;
        }


        public void Add(Question q)
        {
            QList.Add(q);
        }

        public void Run()
        {
            CandidateAnswers = new List<string>();
            for (int i = 0; i < QList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {QList[i]}");
                CandidateAnswers.Add(Console.ReadLine());
                Grade(CandidateAnswers[i].ToLower() == QList[i].CorrectAnswer.ToLower());
                
            }
            Console.WriteLine($"You scored {NumOfCorrect}/{QList.Count}: {Math.Round(NumOfCorrect/QList.Count * 10000) / 100}%");
        }

        private void Grade(bool correctness)
        {
            if (correctness)
            {
                Console.WriteLine("Correct!");
                NumOfCorrect++;
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }
        }
    }
}
