using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees.Data.Classes;
using Employees.Domain.Repositories;

namespace Employees.Presentation.ProjectForms
{
    public partial class EditProjectHoursForm : Form
    {
        public EmployeeRepository EmployeeRepository { get; set; }
        public Project Project { get; set; }
        public ProjectRepository ProjectRepository { get; set; }
        public List<Employee> Employees { get; set; }
        public Dictionary<Employee, int> EmployeesOnProjectAndWorkHours { get; set; }

        public EditProjectHoursForm(EmployeeRepository employeeRepository, Project project, ProjectRepository projectRepository)
        {
            InitializeComponent();
            EmployeeRepository = employeeRepository;
            Project = project;
            ProjectRepository = projectRepository;
            EmployeesOnProjectAndWorkHours = new Dictionary<Employee, int>(Project.EmployeesOnProjectAndWorkHours);
            FillUpList();
        }

        private void FillUpList()
        {
            EmployeesListBox.Items.Clear();
            Employees = EmployeeRepository.GetAllItems();
            foreach (var employee in Project.EmployeesOnProjectAndWorkHours.Keys.ToList())
            {
                EmployeesListBox.Items.Add(employee);
            }
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void EditHours(object sender, EventArgs e)
        {
            if (EmployeesListBox.SelectedItem == null)
            {
                MessageBox.Show("Select the employee you want to edit the hours of and try again", "No employee selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var employee = (Employee) EmployeesListBox.SelectedItem;
            EmployeesAndWorkHoursCalculator(employee.FirstName, employee.LastName);
            FillUpList();
        }

        private void EmployeesAndWorkHoursCalculator(string firstName, string lastName)
        {
            var employeeToEdit = (Employee)EmployeesListBox.SelectedItem;
            var employeeHoursOnProject =
                new EmployeeHoursOnProjectForm(firstName, lastName, Project);
            employeeHoursOnProject.ShowDialog();
            if (employeeHoursOnProject.WasSomethingInput)
            {
                foreach (var employee in Employees)
                {
                    if (employee.Oib == employeeToEdit.Oib)
                    {
                        employeeToEdit = employee;
                    }
                }
                EmployeesOnProjectAndWorkHours.Remove(employeeToEdit);
                EmployeesOnProjectAndWorkHours.Add(employeeToEdit, employeeHoursOnProject.HoursOnProject);
                RemoveProjectFromEmployee(Project, employeeToEdit);
                AddProjectToEmployee(Project, employeeToEdit, employeeHoursOnProject.HoursOnProject);
            }
            else
            {
                MessageBox.Show("Nothing was input so the employee was not added to the project",
                    "Input error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RemoveProjectFromEmployee(Project projectToRemove, Employee employee)
        {
            employee.RemoveProject(projectToRemove);
        }

        private void AddProjectToEmployee(Project projectToAdd, Employee employee, int numberOfHours)
        {
            employee.AddProject(projectToAdd, numberOfHours);
        }
    }
}
