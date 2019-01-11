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
    public partial class EmployeeDetailsForm : Form
    {
        public EmployeeRepository EmployeeRepository { get; set; }
        public List<Employee> Employees { get; set; }
        public ProjectRepository ProjectRepository { get; set; }
        public Employee Employee { get; set; }

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

        public void UpdateForm()
        {
            EmployeeInfo();
            IndicatorSetup();
            ProjectInfo();
        }

        private void EmployeeInfo()
        {
            EmployeeDetailsFirstNameLabel.Text = $@"First name: {Employee.FirstName}";
            EmployeeDetailsLastNameLabel.Text = $@"Last name: {Employee.LastName}";
            EmployeeDetailsDateofBirthLabel.Text = $@"Date of birth: {Employee.DateOfBirth.ToShortDateString()}";
            EmployeeDetailsOibLabel.Text = $@"Oib: {Employee.Oib}";
            EmployeeDetailsPostitonLabel.Text = $@"Position: {Employee.Job.ToString()}";
        }

        private void IndicatorSetup()
        {
            Indicator.Location = new Point(EmployeeDetailsFirstNameLabel.Width + 38, 110);
            var hoursPerWeek = 0;
            foreach (var project in ProjectRepository.Projects)
            {
                foreach (var employee in project.EmployeesOnProjectAndWorkHours.Keys)
                {
                    if (employee == Employee)
                    {
                        hoursPerWeek += project.EmployeesOnProjectAndWorkHours[employee];
                    }
                }
            }

            if (hoursPerWeek >= 0)
            {
                if (hoursPerWeek < 30)
                {
                    Indicator.BackColor = Color.Yellow;
                }
                else if (hoursPerWeek <= 40)
                {
                    Indicator.BackColor = Color.Green;
                }
                else
                {
                    Indicator.BackColor = Color.Red;
                }
            }
        }

        private void ProjectInfo()
        {
            var numberOfFinishedProjects = 0;
            var numberOfActiveProjects = 0;
            var numberOfPlannedProjects = 0;
            foreach (var project in ProjectRepository.Projects)
            {
                foreach (var employee in project.EmployeesOnProjectAndWorkHours.Keys)
                {
                    if (employee == Employee)
                    {
                        if (project.ProjectFinish < DateTime.Now)
                        {
                            numberOfFinishedProjects++;
                        }
                        else if (project.ProjectStart < DateTime.Now && project.ProjectFinish > DateTime.Now)
                        {
                            numberOfActiveProjects++;
                        }
                        else if (project.ProjectStart > DateTime.Now)
                        {
                            numberOfPlannedProjects++;
                        }
                    }
                }
            }

            FinishedProjectsLabel.Text = $@"Finished projects: {numberOfFinishedProjects}";
            ActiveProjectsLabel.Text = $@"Active projects: {numberOfActiveProjects}";
            PlannedProjectsLabel.Text = $@"Planned projects: {numberOfPlannedProjects}";
            WeeklyWorkHoursLabel.Text = $@"Number of work hours per week: {numberOfFinishedProjects+ numberOfActiveProjects+numberOfPlannedProjects}";
        }
    }
}
