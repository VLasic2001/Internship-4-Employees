using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Employees.Data.Classes;
using Employees.Data.Enums;
using Employees.Domain.Repositories;
using Employees.Infrastructure;

namespace Employees.Presentation.EmployeeForms
{
    public partial class AddEmployeeForm : Form
    {
        public EmployeeRepository EmployeeRepository { get; set; }
        public Employee Employee { get; set; }
        public ProjectRepository ProjectRepository { get; set; }
        public List<Project> Projects { get; set; }
        public Dictionary<Project, int> ProjectsAndWorkHours { get; set; }

        public AddEmployeeForm(EmployeeRepository employeeRepository, ProjectRepository projectRepository)
        {
            InitializeComponent();
            ProjectsAndWorkHours = new Dictionary<Project, int>();
            EmployeeRepository = employeeRepository;
            ProjectRepository = projectRepository;
            JobComboBox.SelectedIndex = 0;
            UpdateList();
        }

        private void SaveEmployee(object sender, EventArgs e)
        {
            if (!IsInputValid()) return;
            EmployeesAndWorkHoursCalculator(FirstNameTextBox.Text, LastNameTextBox.Text);
            Employee = CreateEmployee();
            AddEmployee(Employee);
            Close();
        }

        private Employee CreateEmployee()
        {
            return new Employee(
                LastNameTextBox.Text.UpperCaseFirstLetters(),
                LastNameTextBox.Text.UpperCaseFirstLetters(),
                DateOfBirthDateTimePicker.Value,
                OibTextBox.Text.RemoveWhiteSpaces(),
                (Jobs)JobComboBox.SelectedIndex,
                ProjectsAndWorkHours
            );
        }

        private void EmployeesAndWorkHoursCalculator(string firstName, string lastName)
        {
            var employeesProject = EmployeesProjectsCheckedListBox.CheckedItems.OfType<Project>().ToList();
            foreach (var project in employeesProject)
            {
                var employeeHoursOnProject = new EmployeeHoursOnProjectForm(firstName, lastName, project);
                employeeHoursOnProject.ShowDialog();
                if (employeeHoursOnProject.WasSomethingInput)
                {
                    ProjectsAndWorkHours.Add(project, employeeHoursOnProject.HoursOnProject);
                    AddEmployeeToProject(CreateEmployee(), project, employeeHoursOnProject.HoursOnProject);
                }
                else
                {
                    MessageBox.Show(@"Nothing was input so the employee was not added to the project", @"Input error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void UpdateList()
        {
            EmployeesProjectsCheckedListBox.Items.Clear();
            Projects = ProjectRepository.GetAllItems();
            foreach (var project in Projects)
            {
                EmployeesProjectsCheckedListBox.Items.Add(project);
            }
        }

        private bool IsInputValid()
        {
            if(string.IsNullOrWhiteSpace(FirstNameTextBox.Text) || string.IsNullOrWhiteSpace(LastNameTextBox.Text) || string.IsNullOrWhiteSpace(OibTextBox.Text))
            {
                MessageBox.Show(@"Fields cannot be empty", @"Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if ((DateTime.Now - DateOfBirthDateTimePicker.Value).TotalDays / 365 < 18)
            {
                MessageBox.Show(@"Employee must be over 18 years old", @"Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(OibTextBox.Text.RemoveWhiteSpaces(), out var Oib))
            {
                MessageBox.Show(@"Oib must be a number", @"Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (EmployeeRepository.Employees.All(employee => employee.Oib != OibTextBox.Text.RemoveWhiteSpaces())) return true;
            MessageBox.Show(@"An employee with this Oib already exists", @"Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void AddEmployee(Employee employee)
        {
            EmployeeRepository.AddEmployeeToRepository(employee);
        }

        private void AddEmployeeToProject(Employee employeeToAdd, Project project, int numberOfHours)
        {
            project.AddEmployee(employeeToAdd, numberOfHours);
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
