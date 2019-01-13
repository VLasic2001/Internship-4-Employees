using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Employees.Data.Classes;
using Employees.Domain.Repositories;

namespace Employees.Presentation.EmployeeForms
{
    public partial class EditEmployeeHoursForm : Form
    {
        public EmployeeRepository EmployeeRepository { get; set; }
        public Employee Employee { get; set; }
        public ProjectRepository ProjectRepository { get; set; }
        public List<Project> Projects { get; set; }
        public Dictionary<Project, int> ProjectsAndWorkHours { get; set; }

        public EditEmployeeHoursForm(EmployeeRepository employeeRepository, Employee employee, ProjectRepository projectRepository)
        {
            InitializeComponent();
            EmployeeRepository = employeeRepository;
            Employee = employee;
            ProjectRepository = projectRepository;
            ProjectsAndWorkHours = new Dictionary<Project, int>(Employee.ProjectsAndWorkHours);
            FillUpList();
        }

        private void FillUpList()
        {
            ProjectsListBox.Items.Clear();
            Projects = ProjectRepository.GetAllItems();
            foreach (var project in Employee.ProjectsAndWorkHours.Keys.ToList())
            {
                ProjectsListBox.Items.Add(project);
            }
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void EditHours(object sender, EventArgs e)
        {
            if (ProjectsListBox.SelectedItem == null)
            {
                MessageBox.Show(@"Select the project you want to edit the hours of and try again", @"No Project selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EmployeesAndWorkHoursCalculator(Employee.FirstName, Employee.LastName);
            FillUpList();
        }

        private void EmployeesAndWorkHoursCalculator(string firstName, string lastName)
        {
            var projectToEdit = (Project)ProjectsListBox.SelectedItem;
            var employeeHoursOnProject =
                new EmployeeHoursOnProjectForm(firstName, lastName, projectToEdit);
            employeeHoursOnProject.ShowDialog();
            if (employeeHoursOnProject.WasSomethingInput)
            {
                foreach (var project in Projects)
                {
                    if (project == ProjectsListBox.SelectedItem)
                    {
                        projectToEdit = project;
                    }
                }
                ProjectsAndWorkHours.Remove(projectToEdit);
                ProjectsAndWorkHours.Add(projectToEdit, employeeHoursOnProject.HoursOnProject);
                foreach (var employeeToDelete in projectToEdit.EmployeesOnProjectAndWorkHours.Keys.ToList())
                {
                    if (employeeToDelete.Oib == Employee.Oib)
                    {
                        RemoveEmployeeFromProject(employeeToDelete, projectToEdit);
                    }
                }
                AddEmployeeToProject(Employee, projectToEdit, employeeHoursOnProject.HoursOnProject);
            }
            else
            {
                MessageBox.Show(@"Nothing was input so the employee was not added to the project",
                    @"Input error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddEmployeeToProject(Employee employeeToAdd, Project project, int numberOfHours)
        {
            project.AddEmployee(employeeToAdd, numberOfHours);
        }

        private void RemoveEmployeeFromProject(Employee employeeToRemove, Project project)
        {
            project.RemoveEmployee(employeeToRemove);
        }
    }
}
