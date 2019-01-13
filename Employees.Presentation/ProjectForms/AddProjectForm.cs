using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Employees.Data;
using Employees.Data.Classes;
using Employees.Domain;
using Employees.Domain.Repositories;

namespace Employees.Presentation.ProjectForms
{
    public partial class AddProjectForm : Form
    {
        public ProjectRepository ProjectRepository { get; set; }
        public Project Project { get; set; }
        public EmployeeRepository EmployeeRepository { get; set; }
        public Dictionary<Employee, int> EmployeesOnProjectAndWorkHours { get; set; }
        public List<Employee> Employees { get; set; }
        public bool DeleteProject { get; set;  }

        public AddProjectForm(ProjectRepository projectRepository, EmployeeRepository employeeRepository)
        {
            InitializeComponent();
            ProjectRepository = projectRepository;
            EmployeeRepository = employeeRepository;
            EmployeesOnProjectAndWorkHours = new Dictionary<Employee, int>();
            DeleteProject = false;
            UpdateList();
        }

        private void SaveProject(object sender, EventArgs e)
        {
            DeleteProject = false;
            if (!IsInputValid()) return;
            Project = new Project(ProjectNameTextBox.Text, EmployeesOnProjectAndWorkHours, ProjectStartDateTimePicker.Value, ProjectFinishDateTimePicker.Value);
            EmployeesAndWorkHoursCalculator();
            if (DeleteProject) return;
            AddProject(Project);
            MessageBox.Show(@"Project successfully added.");
            Close();
        }

        private void EmployeesAndWorkHoursCalculator()
        {
            var employeesOnProject = EmployeeListCheckedListBox.CheckedItems.OfType<Employee>().ToList();
            var employeeOnProjectCounter = 0;
            for (var i = 0; i < employeesOnProject.Count; i++)
            {
                if (i >= employeesOnProject.Count) continue;
                var employee = employeesOnProject[i];
                var employeeHoursOnProject =
                    new EmployeeHoursOnProjectForm(employee.FirstName, employee.LastName, Project);
                employeeHoursOnProject.ShowDialog();
                if (employeeHoursOnProject.WasSomethingInput)
                {
                    EmployeesOnProjectAndWorkHours.Add(employee, employeeHoursOnProject.HoursOnProject);
                    AddProjectToEmployee(Project, employee, employeeHoursOnProject.HoursOnProject);
                    employeeOnProjectCounter += 1;
                }
                else
                {
                    MessageBox.Show("Nothing was input so the employee was not added to the project", "Input error",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (employeeOnProjectCounter != 0) return;
            MessageBox.Show("Cannot add a project without any employees", "Input error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            DeleteProject = true;
        }

        private void UpdateList()
            {
                EmployeeListCheckedListBox.Items.Clear();
                Employees = EmployeeRepository.GetAllItems();
                foreach (var employee in Employees)
                {
                    EmployeeListCheckedListBox.Items.Add(employee);
                }
            }
        

        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(ProjectNameTextBox.Text))
            {
                MessageBox.Show("Project name cannot be empty", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ProjectFinishDateTimePicker.Value < ProjectStartDateTimePicker.Value)
            {
                MessageBox.Show("Project start date must be before project finish date", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(EmployeeListCheckedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Cannot create a project without any employees", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ProjectRepository.Projects.All(project => project.ProjectName != ProjectNameTextBox.Text)) return true;
            MessageBox.Show("A project with this name already exists", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void AddProject(Project project)
        {
            ProjectRepository.AddProjectToRepository(project);
        }

        private void AddProjectToEmployee(Project projectToAdd, Employee employee, int numberOfHours)
        {
            employee.AddProject(projectToAdd, numberOfHours);
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
