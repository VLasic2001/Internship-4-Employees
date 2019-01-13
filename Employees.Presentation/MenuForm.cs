using System;
using System.Windows.Forms;
using Employees.Domain.Repositories;
using Employees.Presentation.EmployeeForms;
using Employees.Presentation.ProjectForms;

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
            LinkEmployeesAndProjects(EmployeeRepository, ProjectRepository);
        }

        private void AddEmployee(object sender, EventArgs e)
        {
            var addEmployee = new AddEmployeeForm(EmployeeRepository, ProjectRepository);
            addEmployee.ShowDialog();
        }

        private void ListEmployees(object sender, EventArgs e)
        {
            if (!DoesAnEmployeeExist())
            {
                MessageBox.Show(@"Employee list is empty", @"Cannot open list of employees", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var listEmployees = new ListOfEmployeesForm(EmployeeRepository, ProjectRepository);
            listEmployees.ShowDialog();
        }

        private void DeleteEmployee(object sender, EventArgs e)
        {
            if (!DoesAnEmployeeExist())
            {
                MessageBox.Show(@"Employee list is empty", @"Cannot delete an employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var deleteEmployees = new DeleteEmployeeForm(EmployeeRepository);
            deleteEmployees.ShowDialog();
        }

        private void AddProject(object sender, EventArgs e)
        {
            if (!DoesAnEmployeeExist())
            {
                MessageBox.Show(@"Cannot create a project without any employees in the database", @"Cannot create project", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var addProject = new AddProjectForm(ProjectRepository, EmployeeRepository);
            addProject.ShowDialog();
        }

        private void ListProjects(object sender, EventArgs e)
        {
            if (!DoesAProjectExist())
            {
                MessageBox.Show(@"Project list is empty", @"Cannot open list of projects", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var listOfProjects = new ListOfProjectsForm(ProjectRepository, EmployeeRepository);
            listOfProjects.ShowDialog();
        }

        private void DeleteProject(object sender, EventArgs e)
        {
            if (!DoesAProjectExist())
            {
                MessageBox.Show(@"Project list is empty", @"Cannot delete list of projects", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var deleteProject = new DeleteProjectForm(ProjectRepository);
            deleteProject.ShowDialog();
        }

        private bool DoesAnEmployeeExist()
        {
            return EmployeeRepository.IsListFilled();
        }

        private bool DoesAProjectExist()
        {
            return ProjectRepository.IsListFilled();
        }

        private void LinkEmployeesAndProjects(EmployeeRepository employeeRepository,
            ProjectRepository projectRepository)
        {
            employeeRepository.GetAllItems()[0].ProjectsAndWorkHours.Add(projectRepository.GetAllItems()[0], 10);
            projectRepository.GetAllItems()[0].EmployeesOnProjectAndWorkHours.Add(employeeRepository.GetAllItems()[0], 10);

            employeeRepository.GetAllItems()[0].ProjectsAndWorkHours.Add(projectRepository.GetAllItems()[1], 10);
            projectRepository.GetAllItems()[1].EmployeesOnProjectAndWorkHours.Add(employeeRepository.GetAllItems()[0], 10);

            employeeRepository.GetAllItems()[0].ProjectsAndWorkHours.Add(projectRepository.GetAllItems()[2], 10);
            projectRepository.GetAllItems()[2].EmployeesOnProjectAndWorkHours.Add(employeeRepository.GetAllItems()[0], 10);

            employeeRepository.GetAllItems()[1].ProjectsAndWorkHours.Add(projectRepository.GetAllItems()[0], 10);
            projectRepository.GetAllItems()[0].EmployeesOnProjectAndWorkHours.Add(employeeRepository.GetAllItems()[1], 10);

            employeeRepository.GetAllItems()[1].ProjectsAndWorkHours.Add(projectRepository.GetAllItems()[2], 10);
            projectRepository.GetAllItems()[2].EmployeesOnProjectAndWorkHours.Add(employeeRepository.GetAllItems()[1], 10);

            employeeRepository.GetAllItems()[2].ProjectsAndWorkHours.Add(projectRepository.GetAllItems()[0], 10);
            projectRepository.GetAllItems()[0].EmployeesOnProjectAndWorkHours.Add(employeeRepository.GetAllItems()[2], 10);
            }
    }
}
