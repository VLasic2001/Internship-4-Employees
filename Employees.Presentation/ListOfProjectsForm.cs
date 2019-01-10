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
        }
    }
}
