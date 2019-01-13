using System;
using System.Windows.Forms;
using Employees.Data.Classes;

namespace Employees.Presentation
{
    public partial class EmployeeHoursOnProjectForm : Form
    {
        private int _hoursOnProject { get; set; }
        public int HoursOnProject
        {
            get => _hoursOnProject;
            set => _hoursOnProject = value;
        }
        public bool WasSomethingInput { get; set; }
        public Project Project { get; set; }


        public EmployeeHoursOnProjectForm(string firstName, string lastName, Project project) 
        {
            InitializeComponent();
            Project = project;
            WasSomethingInput = false;
            HoursOnProjectLabel.Text = $@"Enter amount of hours {firstName} {lastName} works on {Project.ProjectName} per week";
        }

        private void Save(object sender, EventArgs e)
        {
            if (int.TryParse(HoursOnProjectTextBox.Text.Replace(" ",""), out var hoursOnProjectAsInt))
            {
                if (hoursOnProjectAsInt > 0)
                {
                    _hoursOnProject = hoursOnProjectAsInt;
                    WasSomethingInput = true;
                    Close();
                    return;
                }

                MessageBox.Show(@"Weekly hours cannot be 0", @"Invalid weekly hours", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(@"Weekly hours cannot be empty", @"Invalid weekly hours", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}