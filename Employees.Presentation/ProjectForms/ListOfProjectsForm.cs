using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Employees.Data.Classes;
using Employees.Domain.Repositories;

namespace Employees.Presentation.ProjectForms
{
    public partial class ListOfProjectsForm : Form
    {
        public ProjectRepository ProjectRepository { get; set; }
        public EmployeeRepository EmployeeRepository { get; set; }
        public List<Project> Projects { get; set; }

        public ListOfProjectsForm(ProjectRepository projectRepository, EmployeeRepository employeeRepository)
        {
            InitializeComponent();
            ProjectRepository = projectRepository;
            EmployeeRepository = employeeRepository;
            UpdateForm();
        }

        private void EditProject(object sender, EventArgs e)
        {
            if (ListOfProjectsListBox.SelectedItem == null)
            {
                MessageBox.Show(@"Select the project you want to edit", @"No project selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var editProject = new EditProjectForm(ProjectRepository, (Project)ListOfProjectsListBox.SelectedItem, EmployeeRepository);
            editProject.ShowDialog();
            UpdateForm();
        }

        private void Detalis(object sender, EventArgs e)
        {
            if (ListOfProjectsListBox.SelectedItem == null)
            {
                MessageBox.Show(@"Select the project you want to see the details of", @"No project selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var details = new ProjectDetailsForm(EmployeeRepository, (Project) ListOfProjectsListBox.SelectedItem, ProjectRepository);
            details.ShowDialog();
            UpdateForm();
        }

        public void NumberOfProjects()
        {
            var numberOfFinishedProjects = 0;
            var numberOfActiveProjects = 0;
            var numberOfPlannedProjects = 0;
            foreach (var project in ProjectRepository.Projects)
            {
                if (project.ProjectFinish < DateTime.Now)
                {
                    numberOfFinishedProjects++;
                }
                else if (project.ProjectStart < DateTime.Now && project.ProjectFinish > DateTime.Now)
                {
                    numberOfActiveProjects++;
                }
                else if (project.ProjectStart > DateTime.Now)
                {
                    numberOfPlannedProjects++;
                }
            }
            FinishedProjectsLabel.Text = $@"Finished projects: {numberOfFinishedProjects}";
            ActiveProjectsLabel.Text = $@"Active projects: {numberOfActiveProjects}";
            PlannedProjectsLabel.Text = $@"Planned projects: {numberOfPlannedProjects}";
        }

        private void UpdateForm()
        {
            ListOfProjectsListBox.Items.Clear();
            Projects = ProjectRepository.GetAllItems();
            foreach (var project in Projects)
            {
                ListOfProjectsListBox.Items.Add(project);
            }
            NumberOfProjects();
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
