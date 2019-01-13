using System;
using System.Collections.Generic;

namespace Employees.Data.Classes
{
    public class Project
    {
        public string ProjectName { get; set; }
        public Dictionary<Employee, int> EmployeesOnProjectAndWorkHours { get; set; }
        public DateTime ProjectStart { get; set; }
        public DateTime ProjectFinish { get; set; }

        public Project(string projectName, Dictionary<Employee, int> employeesOnProjectAndWorkHours, DateTime projectStart, DateTime projectFinish)
        {
            ProjectName = projectName;
            EmployeesOnProjectAndWorkHours = employeesOnProjectAndWorkHours;
            ProjectStart = projectStart;
            ProjectFinish = projectFinish;
        }

        public override string ToString()
        {
            return $"{ProjectName} - {EmployeesOnProjectAndWorkHours.Count} employee(s) working on this project.";
        }

        public void RemoveEmployee(Employee employeeToRemove)
        {
            EmployeesOnProjectAndWorkHours.Remove(employeeToRemove);
        }

        public void AddEmployee(Employee employeeToAdd, int numberOfHours)
        {
            EmployeesOnProjectAndWorkHours.Add(employeeToAdd, numberOfHours);
        }
    }
}
