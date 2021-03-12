using System;

namespace Inheritance
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string SlackHandle { get; set; }

        public void PrintDescription()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"SlackHandle: {SlackHandle}");
        }
    }
}