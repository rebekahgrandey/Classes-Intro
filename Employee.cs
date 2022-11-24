using System;

namespace Classes
{
    public class Employee
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Title { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}