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
    public partial class EditProjectForm : Form
    {
        public ProjectRepository ProjectRepository { get; set; }
        public Project Project { get; set; }
        public Project EditedProject { get; set; }
        public EmployeeRepository EmployeeRepository { get; set; }
        public Dictionary<Employee, int> EmployeesOnProjectAndWorkHours { get; set; }
        public List<Employee> Employees { get; set; }

        public EditProjectForm(ProjectRepository projectRepository, Project project, EmployeeRepository employeeRepository)
        {
            InitializeComponent();
            ProjectRepository = projectRepository;
            EmployeeRepository = employeeRepository;
            Project = project;
            EmployeesOnProjectAndWorkHours = new Dictionary<Employee, int>();
            SetupForm();
        }

        public void SetupForm()
        {
            EditProjectNameTextBox.Text = Project.ProjectName;
            EditProjectStartDateTimePicker.Value = Project.ProjectStart;
            EditProjectFinishDateTimePicker.Value = Project.ProjectFinish;
            FillCheckedListBox();
        }

        private void FillCheckedListBox()
        {
            EditProjectEmployeeListCheckedListBox.Items.Clear();
            Employees = EmployeeRepository.GetAllItems();
            foreach (var employee in Employees)
            {
                EditProjectEmployeeListCheckedListBox.Items.Add(employee);
            }
        }

        public void SaveChanges(object sender, EventArgs e)
        {
            CreateProject();
            ProjectRepository.Projects.Add(EditedProject);
            ProjectRepository.Projects.Remove(Project);
            MessageBox.Show(@"Project successfully Edited.");
            Close();
        }

        private void CreateProject()
        {
            EmployeesAndWorkHoursCalculator();
            EditedProject = new Project(EditProjectNameTextBox.Text,
                                        EmployeesOnProjectAndWorkHours,
                                        EditProjectStartDateTimePicker.Value,
                                        EditProjectFinishDateTimePicker.Value);
            Close();
        }

        private void EmployeesAndWorkHoursCalculator()
        {
            var employeesOnProject = EditProjectEmployeeListCheckedListBox.CheckedItems.OfType<Employee>().ToList();
            foreach (var employee in employeesOnProject)
            {
                var employeeHoursOnProject = new EmployeeHoursOnProjectForm(employee);
                employeeHoursOnProject.ShowDialog();
                EmployeesOnProjectAndWorkHours.Add(employee, employeeHoursOnProject.HoursOnProject);
            }
        }
    }
}
