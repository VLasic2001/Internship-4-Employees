using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Data
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Oib { get; set; }
        public Jobs Job { get; set; }

        public Employee(string firstName, string lastName, DateTime dateOfBirth, string oib, Jobs job)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Oib = oib;
            Job = job;
        }
    }
}
