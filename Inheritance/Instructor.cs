namespace Inheritance
{
    public class Instructor : Person
    {
        public string Specialty { get; set; }
        public string Email { get; set; }

        public void Teach(Student student)
        {
            student.Learn(Specialty);
        }

        public string JudgeStudent(Student student)
        {
            if (student.Knowledge.Count < 3)
            {
                return $"{student.Name} has a lot to learn.";
            }
            else
            {
                return $"{student.Name} knows some stuff.";
            }
        }
    }
}