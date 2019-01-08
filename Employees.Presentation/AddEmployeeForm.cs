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
    public partial class AddEmployeeForm : Form
    {
        public EmployeeRepository EmployeeRepository { get; set; }
        public Employee Employee { get; set; }

        public AddEmployeeForm(EmployeeRepository employeeRepository)
        {
            InitializeComponent();
            EmployeeRepository = employeeRepository;
            employeeJobComboBox.SelectedIndex = 0;
        }

        private void SaveEmployee(object sender, EventArgs e)
        {
            CreateEmployee();
            EmployeeRepository.Employees.Add(Employee);
            Close();
        }

        private void CreateEmployee()
        {
            Employee = new Employee(
                employeeFirstNameTextBox.Text,
                employeeLastNameTextBox.Text,
                employeeDateTimePicker.Value,
                employeeOibTextBox.Text,
                (Jobs)employeeJobComboBox.SelectedIndex
            );
        }
    }
}
