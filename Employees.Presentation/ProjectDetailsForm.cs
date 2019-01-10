using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees.Data;
using Employees.Domain;

namespace Employees.Presentation
{
    public partial class ProjectDetailsForm : Form
    {
        public EmployeeRepository EmployeeRepository { get; set; }
        public Project Project { get; set; }

        public ProjectDetailsForm(EmployeeRepository employeeRepository, Project project)
        {
            InitializeComponent();
            EmployeeRepository = employeeRepository;
            Project = project;
            SetupForm();
        }

        private void SetupForm()
        {
            ProjectNameLabel.Text = Project.ProjectName;
            ProjectDatesLabel.Text = $@"{Project.ProjectStart} - {Project.ProjectFinish}";
            NumberOfEmployeesInPositions();
            foreach (var employee in Project.EmployeesOnProjectAndWorkHours.Keys)
            {
                if (employee.Job == Jobs.Designer)
                {
                    ProjectDesignersLabel.Text += Environment.NewLine + $@"{employee.FirstName} {employee.LastName} ({Project.EmployeesOnProjectAndWorkHours[employee]} hours)";
                }
                else if (employee.Job == Jobs.Programmer)
                {
                    ProjectProgrammersLabel.Text += Environment.NewLine + $@"{employee.FirstName} {employee.LastName} ({Project.EmployeesOnProjectAndWorkHours[employee]} hours)";
                }
                else
                {
                    ProjectAccountantsLabel.Text += Environment.NewLine + $@"{employee.FirstName} {employee.LastName} ({Project.EmployeesOnProjectAndWorkHours[employee]} hours)";
                }
            }
        }

        private void NumberOfEmployeesInPositions()
        {
            var listOfDesigners = Project.EmployeesOnProjectAndWorkHours.Keys.ToList();
            ProjectDesignersLabel.Text = $@"Designers ({listOfDesigners.Count(employee => employee.Job == Jobs.Designer)})";
            var listOfProgrammers = Project.EmployeesOnProjectAndWorkHours.Keys.ToList();
            ProjectProgrammersLabel.Text = $@"Programmers ({listOfProgrammers.Count(employee => employee.Job == Jobs.Programmer)})";
            var listOfAccountants = Project.EmployeesOnProjectAndWorkHours.Keys.ToList();
            ProjectAccountantsLabel.Text = $@"Accountants ({listOfAccountants.Count(employee => employee.Job == Jobs.Accountant)})"; 
        }
    }
}
