using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company Ingram = new Company("Ingram", new DateTime(2022, 11, 22)); //why new before DateTime?
            // Create three employees
            List<Employee> EmployeeList = new List<Employee> {
            new Employee() {
                FirstName = "Bob",
                LastName = "Builder",
                Title = "Software Dev",
                StartDate = new DateTime(2022, 09, 28)

            },
            new Employee() {
                FirstName = "Michael",
                LastName = "Scott",
                Title = "Boss",
                StartDate = new DateTime(2021, 02, 17)

            },
            new Employee() {
                FirstName = "Rebekah",
                LastName = "Taylor",
                Title = "Junior Software Dev",
                StartDate = new DateTime()
            }
            };

            // Assign the employees to the company
            Ingram.Employees = EmployeeList;
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

        }
    }
}