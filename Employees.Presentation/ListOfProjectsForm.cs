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
            ListOfProjectsListBox.Items.Clear();
            Projects = ProjectRepository.GetAllItems();
            foreach (var project in Projects)
            {
                ListOfProjectsListBox.Items.Add(project);
            }
            NumberOfProjects();
        }

        private void EditProject(object sender, EventArgs e)
        {
            var editProject = new EditProjectForm(ProjectRepository, (Project)ListOfProjectsListBox.SelectedItem, EmployeeRepository);
            editProject.ShowDialog();
            ListOfProjectsListBox.Items.Clear();
            Projects = ProjectRepository.GetAllItems();
            foreach (var project in Projects)
            {
                ListOfProjectsListBox.Items.Add(project);
            }
            NumberOfProjects();
        }

        private void Detalis(object sender, EventArgs e)
        {
            {
                var details = new ProjectDetailsForm(EmployeeRepository, (Project)ListOfProjectsListBox.SelectedItem);
                details.ShowDialog();
            }
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
    }
}
