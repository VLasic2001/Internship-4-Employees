using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Data;

namespace Employees.Domain
{
    public class EmployeeRepository
    {
        public List<Employee> Employees;

        public EmployeeRepository()
        {
            SeedData();
        }

        private void SeedData()
        {
            Employees = new List<Employee>
            {
                new Employee("Vedran", "Lasic", new DateTime(1999, 6, 10), "12345678901", Jobs.Programmer),
                new Employee("Luka", "Lukanovic Lukic", new DateTime(1989, 10, 19), "98765432109", Jobs.Designer),
                new Employee("Filip", "Filipovic", new DateTime(1998, 9, 16), "3008576921", Jobs.Accountant)
            };
        }

        public List<Employee> GetAllItems() => Employees;

        public void RemoveEmployee(Employee employeeToDelete) => Employees.Remove(employeeToDelete);
    }
}
