using System;


// create custom types to represent an Employee and a Company. Then you will create some employees, hire them into the company and then display a simple report showing the employee names and their titles.

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get; set; } = default!;

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */

        public Company(string name, DateTime time)
        {
            Name = name;
            CreatedOn = time;
        }
        public void ListEmployees(string FirstName, string Title, DateTime StartDate)
        {
            foreach (Employee employee in Employees)
                Console.WriteLine($"{employee.FullName()} works for {Name} as {employee.Title} since {employee.StartDate}");
        }
    }
}