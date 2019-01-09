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
    public partial class DeleteProjectForm : Form
    {
        public ProjectRepository ProjectRepository { get; set; }
        public List<Project> Projects { get; set; }

        public DeleteProjectForm(ProjectRepository projectRepository)
        {
            InitializeComponent();
            ProjectRepository = projectRepository;
            DeleteProjectListBox.Items.Clear();
            Projects = ProjectRepository.GetAllItems();
            foreach (var project in Projects)
            {
                DeleteProjectListBox.Items.Add(project);
            }
        }

        private void DeleteProject(object sender, EventArgs e)
        {
            if (DeleteProjectListBox.SelectedItem == null) Close();
            var projectToDelete = DeleteProjectListBox.SelectedItem as Project;
            ProjectRepository.RemoveProject(projectToDelete);
            Close();
        }
    }
}
