using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Employees.Data;
using Employees.Data.Classes;
using Employees.Data.Enums;
using Employees.Domain;
using Employees.Domain.Repositories;

namespace Employees.Presentation.EmployeeForms
{
    public partial class EditEmployeeForm : Form
    {
        public EmployeeRepository EmployeeRepository { get; set; }
        public Employee Employee { get; set; }
        public ProjectRepository ProjectRepository { get; set; }
        public List<Project> Projects { get; set; }
        public Dictionary<Project, int> ProjectsAndWorkHours { get; set; }

        public EditEmployeeForm(EmployeeRepository employeeRepository, Employee employee, ProjectRepository projectRepository)
        {
            InitializeComponent();
            ProjectsAndWorkHours = new Dictionary<Project, int>(employee.ProjectsAndWorkHours);
            EmployeeRepository = employeeRepository;
            ProjectRepository = projectRepository;
            Employee = employee;
            UpdateForm();
        }

        public void SaveChanges(object sender, EventArgs e)
        {
            if (!IsInputValid()) return;
            EmployeesAndWorkHoursCalculator(FirstNameTextBox.Text, LastNameTextBox.Text);
            var employeeToAdd = CreateEmployee();
            EditEmployee(Employee, employeeToAdd);
            Close();
        }

        private Employee CreateEmployee()
        {
            var upperCaseTextInfo = new CultureInfo("en-US", false).TextInfo;
            return new Employee(
                upperCaseTextInfo.ToTitleCase(FirstNameTextBox.Text.ToLower()),
                upperCaseTextInfo.ToTitleCase(LastNameTextBox.Text.ToLower()),
                DateOfBirthDateTimePicker.Value,
                OibTextBox.Text.Replace(" ", ""),
                (Jobs)JobComboBox.SelectedIndex,
                ProjectsAndWorkHours
            );
        }

        public void UpdateForm()
        {
            Projects = ProjectRepository.Projects;
            FirstNameTextBox.Text = Employee.FirstName;
            LastNameTextBox.Text = Employee.LastName;
            DateOfBirthDateTimePicker.Value = Employee.DateOfBirth;
            OibTextBox.Text = Employee.Oib;
            JobComboBox.SelectedIndex = (int)Employee.Job;

            EmployeesProjectsCheckedListBox.Items.Clear();
            Projects = ProjectRepository.GetAllItems();
            for (var i = 0; i < Projects.Count; i++)
            {
                var project = Projects[i];
                EmployeesProjectsCheckedListBox.Items.Add(project, false);
                if (!Employee.ProjectsAndWorkHours.ContainsKey(project))
                {
                    EmployeesProjectsCheckedListBox.SetItemChecked(i, false);
                }
                else
                {
                    EmployeesProjectsCheckedListBox.SetItemCheckState(i,
                        IsOnlyEmployeeOnAProject(project) ? CheckState.Indeterminate : CheckState.Checked);
                }
            }
        }

        private void EmployeesAndWorkHoursCalculator(string firstName, string lastName)
        {
            var oldListOfEmployeesProjectsAndWorkHours = Employee.ProjectsAndWorkHours;
            var checkedListBoxItems = EmployeesProjectsCheckedListBox.Items.OfType<Project>().ToList();
            for(var i = EmployeesProjectsCheckedListBox.Items.Count-1; i >= 0; i--)
            {

                if (EmployeesProjectsCheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                {
                    if (oldListOfEmployeesProjectsAndWorkHours.ContainsKey(checkedListBoxItems[i])) continue;
                    var employeeHoursOnProject =
                        new EmployeeHoursOnProjectForm(firstName, lastName, Projects[i]);
                    employeeHoursOnProject.ShowDialog();
                    if (employeeHoursOnProject.WasSomethingInput)
                    {
                        ProjectsAndWorkHours.Add(Projects[i], employeeHoursOnProject.HoursOnProject);
                        AddEmployeeToProject(CreateEmployee(), Projects[i], employeeHoursOnProject.HoursOnProject);
                    }
                    else
                    {
                        MessageBox.Show("Nothing was input so the employee was not added to the project",
                            "Input error",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (EmployeesProjectsCheckedListBox.GetItemCheckState(i) == CheckState.Unchecked)
                {
                    if (!oldListOfEmployeesProjectsAndWorkHours.ContainsKey(checkedListBoxItems[i])) continue;
                    ProjectsAndWorkHours.Remove(checkedListBoxItems[i]);
                    foreach (var employeeToDelete in ProjectRepository.Projects[i].EmployeesOnProjectAndWorkHours.Keys.ToList())
                    {
                        if (employeeToDelete.Oib == Employee.Oib)
                        {
                            RemoveEmployeeFromProject(employeeToDelete, Projects[i]);
                        }
                    }
                }
            }
        }

        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text) || string.IsNullOrWhiteSpace(LastNameTextBox.Text) || string.IsNullOrWhiteSpace(OibTextBox.Text))
            {
                MessageBox.Show("Fields cannot be empty", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if ((DateTime.Now - DateOfBirthDateTimePicker.Value).TotalDays / 365 < 18)
            {
                MessageBox.Show("Employee must be over 18 years old", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (EmployeeRepository.Employees.All(employee => employee.Oib != OibTextBox.Text.Replace(" ", "")) || Employee.Oib == OibTextBox.Text) return true;
            MessageBox.Show("An employee with this Oib already exists", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private static bool IsOnlyEmployeeOnAProject(Project project)
        {
            return project.EmployeesOnProjectAndWorkHours.Keys.Count == 1;
        }

        public void EditEmployee(Employee employeeToDelete, Employee employeeToAdd)
        {
            EmployeeRepository.EditEmployeeInRepository(employeeToDelete, employeeToAdd);
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue != CheckState.Indeterminate) return;
            MessageBox.Show("Cannot remove selected employee from project because he is the only employee on that project", "Cannot delete employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.NewValue = CheckState.Indeterminate;
        }

        private void RemoveEmployeeFromProject(Employee employeeToRemove, Project project)
        {
            project.RemoveEmployee(employeeToRemove);
        }

        private void AddEmployeeToProject(Employee employeeToAdd, Project project, int numberOfHours)
        {
            project.AddEmployee(employeeToAdd, numberOfHours);
        }
    }
}
