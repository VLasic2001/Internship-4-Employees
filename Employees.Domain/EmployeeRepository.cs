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
            Employees=new List<Employee>()
            {
                new Employee("Vedran", "Lasic", new DateTime(2001, 6, 10), "12345678901", Jobs.Programmer),
                new Employee("Luka", "Lukanovic Lukic", new DateTime(2001, 10, 19), "98765432109", Jobs.Designer),
                new Employee("Filip", "Filipovic", new DateTime(2001, 9, 16), "3008576921", Jobs.Accountant)
            };
        }
    }
}
