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
        public static bool WasSomethingInput { get; set; }

        public EmployeeHoursOnProjectForm(Employee employee) 
        {
            InitializeComponent();
            WasSomethingInput = false;
            HoursOnProjectLabel.Text = $@"Enter amount of hours {employee} works on this project per week";
        }

        private void Save(object sender, EventArgs e)
        {
            _hoursOnProject = int.Parse(HoursOnProjectTextBox.Text);
            Close();
        }
    }
}

//            if(!string.IsNullOrWhiteSpace(HoursOnProjectTextBox.Text))
