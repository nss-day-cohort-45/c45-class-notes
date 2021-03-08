using System;

namespace ExceptionsAndTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee groucho = new Employee()
            {
                FirstName = "Groucho",
                LastName = "Marx"
            };
            Employee harpo = new Employee()
            {
                FirstName = "Harpo",
                LastName = "Marx",
            };
            Employee gracie = new Employee()
            {
                FirstName = "Gracie",
                LastName = "Allen",
            };
            Employee george = new Employee()
            {
                FirstName = "George",
                LastName = "Burns",
            };

            Company vaudeville = new Company()
            {
                Name = "Vaudeville"
            };

            vaudeville.Employees.Add(groucho);
            vaudeville.Employees.Add(harpo);
            vaudeville.Employees.Add(gracie);
            vaudeville.Employees.Add(george);

            int numerator = 12;
            int denominator = 0;
            try
            {
                int quotient = numerator / denominator;
            }
            catch
            {
                Console.WriteLine($"{numerator} / {denominator} failed.");
            }

        }
    }
}