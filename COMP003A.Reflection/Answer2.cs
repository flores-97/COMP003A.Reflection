using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Reflection
{
    internal class Answer2 : Answer1
    {
        public string AnswerTwo { get; set; }

        public Answer2(string answerTwo)
        {
            AnswerTwo = answerTwo;
        }

        public void DisplayAnswerTwo()
        {
            Console.WriteLine($"Response: {AnswerTwo}");
        }
    }
}
