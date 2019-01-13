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
    public partial class EditProjectForm : Form
    {
        public ProjectRepository ProjectRepository { get; set; }
        public Project Project { get; set; }
        public Project EditedProject { get; set; }
        public EmployeeRepository EmployeeRepository { get; set; }
        public Dictionary<Employee, int> EmployeesOnProjectAndWorkHours { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Project> Projects { get; set; }

        public EditProjectForm(ProjectRepository projectRepository, Project project,
            EmployeeRepository employeeRepository)
        {
            InitializeComponent();
            ProjectRepository = projectRepository;
            EmployeeRepository = employeeRepository;
            Projects = ProjectRepository.Projects;
            Employees = EmployeeRepository.Employees;
            Project = project;
            EmployeesOnProjectAndWorkHours = new Dictionary<Employee, int>(Project.EmployeesOnProjectAndWorkHours);
            SetupForm();
        }

        public void SetupForm()
        {
            ProjectNameTextBox.Text = Project.ProjectName;
            ProjectStartDateTimePicker.Value = Project.ProjectStart;
            ProjectFinishDateTimePicker.Value = Project.ProjectFinish;
            FillCheckedListBox();
        }

        private void FillCheckedListBox()
        {
            EmployeeListCheckedListBox.Items.Clear();
            Employees = EmployeeRepository.GetAllItems();
            for (var i = 0; i < Employees.Count; i++)
            {
                var employee = Employees[i];
                EmployeeListCheckedListBox.Items.Add(employee, false);
                if (!Project.EmployeesOnProjectAndWorkHours.ContainsKey(employee))
                {
                    EmployeeListCheckedListBox.SetItemChecked(i, false);
                }
                else
                {
                    EmployeeListCheckedListBox.SetItemCheckState(i,
                        IsOnlyEmployeeOnAProject(Project) ? CheckState.Indeterminate : CheckState.Checked);
                }
            }
        }

        public void SaveChanges(object sender, EventArgs e)
        {
            if(!IsInputValid()) return;
            EmployeesAndWorkHoursCalculator();
            CreateProject();
            EditProject(Project, EditedProject);
            MessageBox.Show(@"Project successfully Edited.");
            Close();
        }

        private void CreateProject()
        {
            EditedProject = new Project(ProjectNameTextBox.Text,
                EmployeesOnProjectAndWorkHours,
                ProjectStartDateTimePicker.Value,
                ProjectFinishDateTimePicker.Value);
            Close();
        }

        private void EmployeesAndWorkHoursCalculator()
        {
            var oldListOfEmployeesOnProjectAndWorkHours = Project.EmployeesOnProjectAndWorkHours;
            var checkedListBoxItems = EmployeeListCheckedListBox.Items.OfType<Employee>().ToList();
            for (var i = EmployeeListCheckedListBox.Items.Count - 1; i >= 0; i--)
            {

                if (EmployeeListCheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                {
                    if (!oldListOfEmployeesOnProjectAndWorkHours.ContainsKey(checkedListBoxItems[i]))
                    {
                        var employeeHoursOnProject =
                            new EmployeeHoursOnProjectForm(checkedListBoxItems[i].FirstName,
                                checkedListBoxItems[i].LastName, Project);
                        employeeHoursOnProject.ShowDialog();
                        if (employeeHoursOnProject.WasSomethingInput)
                        {
                            EmployeesOnProjectAndWorkHours.Add(checkedListBoxItems[i], employeeHoursOnProject.HoursOnProject);
                            AddProjectToEmployee(Project, checkedListBoxItems[i], employeeHoursOnProject.HoursOnProject);
                        }
                        else
                        {
                            MessageBox.Show("Nothing was input so the employee was not added to the project",
                                "Input error",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else if (EmployeeListCheckedListBox.GetItemCheckState(i) == CheckState.Unchecked)
                {
                    if (!oldListOfEmployeesOnProjectAndWorkHours.ContainsKey(checkedListBoxItems[i])) continue;
                    EmployeesOnProjectAndWorkHours.Remove(checkedListBoxItems[i]);
                    foreach (var projectToDelete in Employees[i].ProjectsAndWorkHours.Keys.ToList())
                    {
                        if (projectToDelete.ProjectName == Project.ProjectName)
                        {
                            RemoveProjectFromEmployee(projectToDelete, Employees[i]);
                        }
                    }
                }
            }

        }

        private static bool IsOnlyEmployeeOnAProject(Project project)
        {
            return project.EmployeesOnProjectAndWorkHours.Keys.Count == 1;
        }

        private void ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Indeterminate)
            {
                MessageBox.Show(
                    "Cannot remove selected employee from project because he is the only employee on that project",
                    "Cannot remove employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.NewValue = CheckState.Indeterminate;
            }
            else if (EmployeeListCheckedListBox.CheckedItems.Count == 1 && e.CurrentValue == CheckState.Checked)
            {
                MessageBox.Show("Cannot remove selected employee from project because he is the only employee on that project",
                "Cannot remove employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.NewValue = CheckState.Indeterminate;
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
            if (EmployeeListCheckedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Cannot create a project without any employees", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ProjectRepository.Projects.All(project => project.ProjectName != ProjectNameTextBox.Text) || ProjectNameTextBox.Text == Project.ProjectName) return true;
            MessageBox.Show("A project with this name already exists", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public void EditProject(Project projectToDelete, Project projectToAdd)
        {
            ProjectRepository.EditProjectInRepository(projectToDelete, projectToAdd);
        }

        private void RemoveProjectFromEmployee(Project projectToRemove, Employee employee)
        {
            employee.RemoveProject(projectToRemove);
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
