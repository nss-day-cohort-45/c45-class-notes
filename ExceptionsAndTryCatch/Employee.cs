namespace ExceptionsAndTryCatch
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string fullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}