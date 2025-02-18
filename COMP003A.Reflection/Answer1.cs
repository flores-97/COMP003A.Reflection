using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Reflection
{
    internal class Answer1
    {
        private string _answerOne;

        public string AnswerOne
        {
            get { return _answerOne; }
            set { _answerOne = value; }
        }

        public virtual void DisplayAnswerOne()
        {
            Console.WriteLine($"Response: {AnswerOne}");
        }
    }
}
