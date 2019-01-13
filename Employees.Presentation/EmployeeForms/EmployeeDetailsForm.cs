using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Employees.Data;
using Employees.Data.Classes;
using Employees.Domain;
using Employees.Domain.Repositories;

namespace Employees.Presentation.EmployeeForms
{
    public partial class EmployeeDetailsForm : Form
    {
        public EmployeeRepository EmployeeRepository { get; set; }
        public ProjectRepository ProjectRepository { get; set; }
        public Employee Employee { get; set; }
        public int WeeklyWorkHours { get; set; }

        public EmployeeDetailsForm(EmployeeRepository employeeRepository, Employee employee, ProjectRepository projectRepository)
        {
            InitializeComponent();
            EmployeeRepository = employeeRepository;
            ProjectRepository = projectRepository;
            Employee = employee;
            UpdateForm();
        }

        private void EditEmployee(object sender, EventArgs e)
        {
            var editEmployee = new EditEmployeeForm(EmployeeRepository, Employee, ProjectRepository);
            editEmployee.ShowDialog();
            Employee = editEmployee.Employee;
            UpdateForm();
        }

        private void EditHours(object sender, EventArgs e)
        {
            if (Employee.ProjectsAndWorkHours.Keys.Count == 0)
            {
                MessageBox.Show("Cannot edit employee's work hours because employee does not work on any projects",
                    "Employee has no active projects",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var editEmployeeHours = new EditEmployeeHoursForm(EmployeeRepository, Employee, ProjectRepository);
            editEmployeeHours.ShowDialog();
            Employee.ProjectsAndWorkHours = editEmployeeHours.ProjectsAndWorkHours;
            UpdateForm();
        }

        public void UpdateForm()
        {
            EmployeeInfo();
            ProjectInfo();
            IndicatorSetup();
            }

        private void EmployeeInfo()
        {
            FirstNameLabel.Text = $@"First name: {Employee.FirstName}";
            LastNameLabel.Text = $@"Last name: {Employee.LastName}";
            DateofBirthLabel.Text = $@"Date of birth: {Employee.DateOfBirth.ToShortDateString()}";
            OibLabel.Text = $@"Oib: {Employee.Oib}";
            PostitonLabel.Text = $@"Position: {Employee.Job.ToString()}";
        }

        private void IndicatorSetup()
        {
            Indicator.Location = new Point(FirstNameLabel.Width + 38, 110);

            if (WeeklyWorkHours < 30)
            {
                Indicator.BackColor = Color.Yellow;
            }
            else if (WeeklyWorkHours <= 40)
            {
                Indicator.BackColor = Color.Green;
            }
            else
            {
                Indicator.BackColor = Color.Red;
            }

        }

        private void ProjectInfo()
        {
            var numberOfFinishedProjects = 0;
            var numberOfActiveProjects = 0;
            var numberOfPlannedProjects = 0;
            WeeklyWorkHours = 0;
            foreach (var project in Employee.ProjectsAndWorkHours.Keys)
            {
                if (project.ProjectFinish.AddDays(1) < DateTime.Now)
                {
                    numberOfFinishedProjects++;
                }
                else if (project.ProjectStart < DateTime.Now && project.ProjectFinish > DateTime.Now)
                {
                    numberOfActiveProjects++;
                    WeeklyWorkHours += Employee.ProjectsAndWorkHours[project];
                }
                else if (project.ProjectStart > DateTime.Now)
                {
                    numberOfPlannedProjects++;
                }

            }

            FinishedProjectsLabel.Text = $@"Finished projects: {numberOfFinishedProjects}";
            ActiveProjectsLabel.Text = $@"Active projects: {numberOfActiveProjects}";
            PlannedProjectsLabel.Text = $@"Planned projects: {numberOfPlannedProjects}";
            TotalnumberOfProjectsLabel.Text = $@"Total number of projects: {numberOfFinishedProjects + numberOfActiveProjects+numberOfPlannedProjects}";
            WeeklyWorkHoursLabel.Text = $@"Number of work hours this week: {WeeklyWorkHours}";
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
