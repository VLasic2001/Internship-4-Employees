using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Employees.Data.Classes;
using Employees.Domain.Repositories;

namespace Employees.Presentation.ProjectForms
{
    public partial class DeleteProjectForm : Form
    {
        public ProjectRepository ProjectRepository { get; set; }
        public List<Project> Projects { get; set; }

        public DeleteProjectForm(ProjectRepository projectRepository)
        {
            InitializeComponent();
            ProjectRepository = projectRepository;
            UpdateList();
        }

        private void DeleteProject(object sender, EventArgs e)
        {
            if (ProjectListBox.SelectedItem == null)
            {
                MessageBox.Show(@"Select the project you want to delete", @"No project selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var projectToDelete = ProjectListBox.SelectedItem as Project;
            if (MessageBox.Show($"Are you sure you want to delete {projectToDelete.ProjectName}?", @"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            DeleteProject(projectToDelete);
            UpdateList();
        }

        private void UpdateList()
        {
            ProjectListBox.Items.Clear();
            Projects = ProjectRepository.GetAllItems();
            foreach (var project in Projects)
            {
                ProjectListBox.Items.Add(project);
            }
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteProject(Project projectToDelete)
        {
            ProjectRepository.RemoveProjectFromRepository(projectToDelete);
        }
    }
}
