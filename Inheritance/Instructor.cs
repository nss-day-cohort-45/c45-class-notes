using System.Collections.Generic;

namespace Inheritance
{
    public class Instructor : Person, ILearner
    {
        public string Specialty { get; set; }
        public string Email { get; set; }

        public List<string> Knowledge { get; set; } = new List<string>();

        public void Teach(Student student)
        {
            student.Learn(Specialty);
        }

        // The instructor can *use* the Student class, but 
        //  doesn't have any "special" access to Student
        public Student MakeStudent()
        {
            return new Student();
        }

        public string JudgeStudent(Student student)
        {
            student.PrintDescription();
            if (student.Knowledge.Count < 3)
            {
                return $"{student.Name} has a lot to learn.";
            }
            else
            {
                return $"{student.Name} knows some stuff.";
            }
        }

        public void Learn(string lesson)
        {
            Knowledge.Add(lesson);
        }
    }
}