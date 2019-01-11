using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees.Domain;

namespace Employees.Presentation
{
    public partial class MenuForm : Form
    {
        public EmployeeRepository EmployeeRepository { get; set; }
        public ProjectRepository ProjectRepository { get; set; }

        public MenuForm()
        {
            InitializeComponent();
            EmployeeRepository = new EmployeeRepository();
            ProjectRepository = new ProjectRepository();
        }

        private void AddEmployee(object sender, EventArgs e)
        {
            var addEmployee = new AddEmployeeForm(EmployeeRepository);
            addEmployee.ShowDialog();
        }

        private void ListEmployees(object sender, EventArgs e)
        {
            var listEmployees =  new ListOfEmployeesForm(EmployeeRepository, ProjectRepository);
            listEmployees.ShowDialog();
        }

        private void DeleteEmployee(object sender, EventArgs e)
        {
            var deleteEmployees = new DeleteEmployeeForm(EmployeeRepository);
            deleteEmployees.ShowDialog();
        }

        private void AddProject(object sender, EventArgs e)
        {
            var addProject = new AddProjectForm(ProjectRepository, EmployeeRepository);
            addProject.ShowDialog();
        }

        private void ListProjects(object sender, EventArgs e)
        {
            var listOfProjects = new ListOfProjectsForm(ProjectRepository, EmployeeRepository);
            listOfProjects.ShowDialog();
        }

        private void DeleteProject(object sender, EventArgs e)
        {
            var deleteProject = new DeleteProjectForm(ProjectRepository);
            deleteProject.ShowDialog();
        }
    }
}
