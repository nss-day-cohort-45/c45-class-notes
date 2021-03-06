using System;
using System.Collections.Generic;

namespace Inheritance
{
    public class Student : Person, ILearner
    {
        public string Grade { get; set; }

        public List<string> Knowledge { get; } = new List<string>();

        public void Learn(string lesson)
        {
            Knowledge.Add(lesson);
        }

        public void AskQuestion()
        {
            Console.WriteLine("But, why???");
        }

        public override void PrintDescription()
        {
            base.PrintDescription();
            Console.WriteLine($"Grade: {Grade}");
        }

        public void PrintStudentDescription()
        {
            base.PrintDescription();
            Console.WriteLine($"Grade: {Grade}");
        }
    }
}