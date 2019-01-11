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
    public partial class AddEmployeeForm : Form
    {
        public EmployeeRepository EmployeeRepository { get; set; }
        public Employee Employee { get; set; }
        public ProjectRepository ProjectRepository { get; set; }
        public List<Project> Projects { get; set; }

        public AddEmployeeForm(EmployeeRepository employeeRepository, ProjectRepository projectRepository)
        {
            InitializeComponent();
            EmployeeRepository = employeeRepository;
            ProjectRepository = projectRepository;
            employeeJobComboBox.SelectedIndex = 0;
            EmployeesProjectsCheckedListBox.Items.Clear();
            Projects = ProjectRepository.GetAllItems();
            foreach (var project in Projects)
            {
                EmployeesProjectsCheckedListBox.Items.Add(project);
            }
        }

        private void SaveEmployee(object sender, EventArgs e)
        {
            CreateEmployee();
            EmployeesAndWorkHoursCalculator();
            EmployeeRepository.Employees.Add(Employee);
            Close();
        }

        private void CreateEmployee()
        {
            Employee = new Employee(
                employeeFirstNameTextBox.Text,
                employeeLastNameTextBox.Text,
                employeeDateTimePicker.Value,
                employeeOibTextBox.Text,
                (Jobs)employeeJobComboBox.SelectedIndex
            );
        }

        private void EmployeesAndWorkHoursCalculator()
        {
            var employeesProject = EmployeesProjectsCheckedListBox.CheckedItems.OfType<Project>().ToList();
            foreach (var project in employeesProject)
            {
                var employeeHoursOnProject = new EmployeeHoursOnProjectForm(Employee);
                employeeHoursOnProject.ShowDialog();
                project.EmployeesOnProjectAndWorkHours.Remove(Employee);
                project.EmployeesOnProjectAndWorkHours.Add(Employee, employeeHoursOnProject.HoursOnProject);
            }
        }
    }
}
