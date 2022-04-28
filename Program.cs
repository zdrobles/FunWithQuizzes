using System;
using System.Collections.Generic;

namespace FunWithQuizzes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> torf = new List<string>();
            torf.Add("True");
            torf.Add("False");

            List<string> choices1 = new List<string>();
            choices1.Add("Jitter Bug");
            choices1.Add("Anxiety Mosquito");
            choices1.Add("Love Bug");
            choices1.Add("Hate Worm");

            List<string> choices2 = new List<string>();
            choices2.Add("Gavin");
            choices2.Add("Pete");
            choices2.Add("Maury");
            choices2.Add("Mona");

            MultipleChoice walter = new MultipleChoice("What kind of bug is Walter?", choices1, "Love Bug");
            Checkbox hormoneMonster = new Checkbox("Which characters are hormone monsters?", choices2, "Gavin, Maury, Mona");
            TrueFalse safi = new TrueFalse("Yara married Safi.", torf, "False");

            List<Question> questionList = new List<Question>()
            {
                walter, hormoneMonster, safi
            };

            Quiz humanResources = new Quiz(questionList);

            humanResources.Run();
        }
    }
}
