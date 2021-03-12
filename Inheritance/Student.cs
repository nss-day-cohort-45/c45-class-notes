using System.Collections.Generic;

namespace Inheritance
{
    public class Student : Person
    {
        public string Grade { get; set; }

        public List<string> Knowledge { get; } = new List<string>();

        public void Learn(string lesson)
        {
            Knowledge.Add(lesson);
        }
    }
}