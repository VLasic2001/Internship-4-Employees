using System;
using System.Collections.Generic;
using System.Linq;
using Employees.Data.Classes;
using Employees.Data.Enums;

namespace Employees.Domain.Repositories
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
                new Employee("Vedran", "Lasic", new DateTime(1999, 6, 10), "12345678901", Jobs.Programmer, new Dictionary<Project, int>()),
                new Employee("Luka", "Lukanovic Lukic", new DateTime(1989, 10, 19), "98765432109", Jobs.Designer, new Dictionary<Project, int>()),
                new Employee("Filip", "Filipovic", new DateTime(1998, 9, 16), "3008576921", Jobs.Accountant, new Dictionary<Project, int>())
            };
        }

        public List<Employee> GetAllItems() => Employees;

        public void RemoveEmployee(Employee employeeToDelete) => Employees.Remove(employeeToDelete);

        public void AddEmployeeToRepository(Employee employee) => Employees.Add(employee);

        public bool IsListFilled()
        {
            return Employees.Count > 0;
        }

        public void EditEmployeeInRepository(Employee employeToDelete, Employee employeeToAdd)
        {

            Employees.Remove(employeToDelete);
            Employees.Add(employeeToAdd);
        }
    }
}
