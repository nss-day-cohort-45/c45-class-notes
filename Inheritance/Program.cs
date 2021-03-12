using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Some Students and Instructors");

            Student roy = new Student()
            {
                Name = "Roy",
                Age = 12,
                Grade = "6th",
                SlackHandle = "@royrules",
            };
            Student jane = new Student() {
                Name = "Jane",
                Age = 13,
                Grade = "7th",
                SlackHandle = "@janetastic"
            };

            Instructor rita = new Instructor() {
                Name = "Rita",
                Age = 39,
                Specialty = "Global Thermo-nuclear War Prevention",
                Email = "rita@school.edu",
                SlackHandle = "@rita",
            };
            Instructor leon = new Instructor() {
                Name = "Leon",
                Age = 45,
                Specialty = "Bird watching",
                Email = "leon@school.edu",
                SlackHandle = "@leon",
            };
            Instructor pat = new Instructor() {
                Name = "Pat",
                Age = 50,
                Specialty = "Tuning Ukuleles",
                Email = "pat@school.com",
                SlackHandle = "@pat",
            };

            Person someGeneridPerson = new Person() {
                Name = "Rando",
                Age = 91,
                SlackHandle = "@notonslack",
            };
        }

        static void ShowDetails(Person person)
        {
            person.PrintDescription();
        }
    }
}