using System.Collections.Generic;

namespace ExceptionsAndTryCatch
{
    public class Company
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }

        public Company()
        {
            // commend this line out to get a NullReferenceException when you run the program
            Employees = new List<Employee>();
        }
    }
}