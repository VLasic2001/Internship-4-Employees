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
        public List<Project> Projects { get; set; }

        public ListOfProjectsForm(ProjectRepository projectRepository)
        {
            InitializeComponent();
            ProjectRepository = projectRepository;
            ListOfProjectsListBox.Items.Clear();
            Projects = ProjectRepository.GetAllItems();
            foreach (var project in Projects)
            {
                ListOfProjectsListBox.Items.Add(project);
            }
        }
    }
}
