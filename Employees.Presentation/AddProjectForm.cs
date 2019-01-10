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
    public partial class AddProjectForm : Form
    {
        public ProjectRepository ProjectRepository { get; set; }
        public Project Project { get; set; }
        public EmployeeRepository EmployeeRepository { get; set; }
        public Dictionary<Employee, int> EmployeesOnProjectAndWorkHours { get; set; }
        public List<Employee> Employees { get; set; }

        public AddProjectForm(ProjectRepository projectRepository, EmployeeRepository employeeRepository)
        {
            InitializeComponent();
            ProjectRepository = projectRepository;
            EmployeeRepository = employeeRepository;
            EmployeesOnProjectAndWorkHours = new Dictionary<Employee, int>();
            FillCheckedListBox();
        }

        private void SaveProject(object sender, EventArgs e)
        {
            EmployeesAndWorkHoursCalculator();
            Project = new Project(addProjectNameTextBox.Text, EmployeesOnProjectAndWorkHours, AddProjectStartDateTimePicker.Value, addProjectFinishDateTimePicker.Value);
            ProjectRepository.Projects.Add(Project);
            MessageBox.Show(@"Project successfully added.");
            Close();
        }

        private void EmployeesAndWorkHoursCalculator()
        {
            var employeesOnProject = addProjectEmployeeListCheckedListBox.CheckedItems.OfType<Employee>().ToList();
            foreach (var employee in employeesOnProject)
            {
                var employeeHoursOnProject = new EmployeeHoursOnProjectForm(employee);
                employeeHoursOnProject.ShowDialog();
                EmployeesOnProjectAndWorkHours.Add(employee, employeeHoursOnProject.HoursOnProject);
            }
        }

        private void FillCheckedListBox()
        {
            addProjectEmployeeListCheckedListBox.Items.Clear();
            Employees = EmployeeRepository.GetAllItems();
            foreach (var employee in Employees)
            {
                addProjectEmployeeListCheckedListBox.Items.Add(employee);
            }
        }
    }
}
