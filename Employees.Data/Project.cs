using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Data
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
            return $"{ProjectName} - {EmployeesOnProjectAndWorkHours.Count} employees working on this project.";
        }
    }
}
