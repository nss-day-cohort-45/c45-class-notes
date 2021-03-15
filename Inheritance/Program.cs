using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Some Students and Instructors");

            Student betty = new Student()
            {
                Age = 10,
                Name = "Betty",
                SlackHandle = "@youbettya",
                Grade = "5th",
            };

            betty.Learn("soap carving");
            betty.AskQuestion();
            betty.PrintDescription();
            betty.PrintStudentDescription();

            Student roy = new Student()
            {
                Name = "Roy",
                Age = 12,
                Grade = "6th",
                SlackHandle = "@royrules",
            };
            Student jane = new Student()
            {
                Name = "Jane",
                Age = 13,
                Grade = "7th",
                SlackHandle = "@janetastic"
            };

            Instructor rita = new Instructor()
            {
                Name = "Rita",
                Age = 39,
                Specialty = "Global Thermo-nuclear War Prevention",
                Email = "rita@school.edu",
                SlackHandle = "@rita",
            };
            Instructor leon = new Instructor()
            {
                Name = "Leon",
                Age = 45,
                Specialty = "Bird watching",
                Email = "leon@school.edu",
                SlackHandle = "@leon",
            };
            Instructor pat = new Instructor()
            {
                Name = "Pat",
                Age = 50,
                Specialty = "Tuning Ukuleles",
                Email = "pat@school.com",
                SlackHandle = "@pat",
            };

            leon.Teach(betty);
            pat.Teach(betty);
            rita.Teach(betty);
            string judgement = rita.JudgeStudent(betty);
            Console.WriteLine(judgement);

            leon.PrintDescription();

            Person someGeneridPerson = new Person()
            {
                Name = "Rando",
                Age = 91,
                SlackHandle = "@notonslack",
            };
            someGeneridPerson.PrintDescription();

            ShowDetails(someGeneridPerson);
            ShowDetails(betty);
            ShowDetails(leon);

            leon.Learn("ruby");
            leon.Knowledge = new List<string>() { "javascript", "tennis" };

            // a student's knowledge doesn't have a set
            //betty.Knowledge = new List<string>() { "Mountain Climbing"};

            TeachSomething(leon, "fishing");
            TeachSomething(betty, "Cleaning my deck");

            // Person does not implement ILearner
            //TeachSomething(someGeneridPerson, "c#");

            ILearner learner = new Student() {
                Name = "Learner",
                Age = 22, 
                SlackHandle = "@learner",
                Grade = "some grade"
            };

            List<ILearner> learners = new List<ILearner>() {
                leon, betty, learner, pat
            };
        }

        static void ShowDetails(Person person)
        {
            Console.WriteLine("-----------------------");
            person.PrintDescription();
            Console.WriteLine("-----------------------");
        }

        static void TeachSomething(ILearner learner, string lesson)
        {
            learner.Learn(lesson);
        }
    }
}