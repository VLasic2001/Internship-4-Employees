using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Infrastructure
{
    public class EmployeeRepository
    {
        private List<Employee> _employeeRepository;

        public EmployeeRepository()
        {
            SeedData();
        }

        private void SeedData()
        {
            _employeeRepository = new List<Employee>()
            {
                new Employee()

            };
        }
    }
}
