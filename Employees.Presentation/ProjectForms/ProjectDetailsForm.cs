using System;
using System.Linq;
using System.Windows.Forms;
using Employees.Data;
using Employees.Data.Classes;
using Employees.Data.Enums;
using Employees.Domain;
using Employees.Domain.Repositories;

namespace Employees.Presentation.ProjectForms
{
    public partial class ProjectDetailsForm : Form
    {
        public EmployeeRepository EmployeeRepository { get; set; }
        public ProjectRepository ProjectRepository { get; set; }
        public Project Project { get; set; }

        public ProjectDetailsForm(EmployeeRepository employeeRepository, Project project, ProjectRepository projectRepository)
        {
            InitializeComponent();
            EmployeeRepository = employeeRepository;
            ProjectRepository = projectRepository;
            Project = project;
            UpdateForm();
        }

        private void UpdateForm()
        {
            ProjectNameLabel.Text = Project.ProjectName;
            ProjectDatesLabel.Text = $@"{Project.ProjectStart} - {Project.ProjectFinish}";
            NumberOfEmployeesInPositions();
            foreach (var employee in Project.EmployeesOnProjectAndWorkHours.Keys)
            {
                switch (employee.Job)
                {
                    case Jobs.Designer:
                        ProjectDesignersLabel.Text += Environment.NewLine +
                                                      $@"{employee.FirstName} {employee.LastName} ({Project.EmployeesOnProjectAndWorkHours[employee]} hours)";
                        break;
                    case Jobs.Programmer:
                        ProjectProgrammersLabel.Text += Environment.NewLine +
                                                        $@"{employee.FirstName} {employee.LastName} ({Project.EmployeesOnProjectAndWorkHours[employee]} hours)";
                        break;
                    default:
                        ProjectAccountantsLabel.Text += Environment.NewLine +
                                                        $@"{employee.FirstName} {employee.LastName} ({Project.EmployeesOnProjectAndWorkHours[employee]} hours)";
                        break;
                }
            }
        }

        private void NumberOfEmployeesInPositions()
        {
            var listOfDesigners = Project.EmployeesOnProjectAndWorkHours.Keys.ToList();
            ProjectDesignersLabel.Text = $@"Designers ({listOfDesigners.Count(employee => employee.Job == Jobs.Designer)})";
            var listOfProgrammers = Project.EmployeesOnProjectAndWorkHours.Keys.ToList();
            ProjectProgrammersLabel.Text = $@"Programmers ({listOfProgrammers.Count(employee => employee.Job == Jobs.Programmer)})";
            var listOfAccountants = Project.EmployeesOnProjectAndWorkHours.Keys.ToList();
            ProjectAccountantsLabel.Text = $@"Accountants ({listOfAccountants.Count(employee => employee.Job == Jobs.Accountant)})"; 
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void EditProject(object sender, EventArgs e)
        {
            var editProject = new EditProjectForm(ProjectRepository, Project, EmployeeRepository);
            editProject.ShowDialog();
            Project = editProject.EditedProject;
            UpdateForm();
        }

        private void EditHours(object sender, EventArgs e)
        { 
            var editProjectHours = new EditProjectHoursForm(EmployeeRepository, Project, ProjectRepository);
            editProjectHours.ShowDialog();
            Project.EmployeesOnProjectAndWorkHours = editProjectHours.EmployeesOnProjectAndWorkHours;
            UpdateForm();
        }
    }
}