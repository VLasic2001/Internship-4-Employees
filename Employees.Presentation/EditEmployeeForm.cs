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
    public partial class EditEmployeeForm : Form
    {
        public EmployeeRepository EmployeeRepository { get; set; }
        public Employee Employee { get; set; }

        public EditEmployeeForm(EmployeeRepository employeeRepository, Employee employee)
        {
            InitializeComponent();
            EmployeeRepository = employeeRepository;
            Employee = employee;
            SetupForm();
        }

        public void SaveChanges(object sender, EventArgs e)
        {
            EmployeeRepository.Employees.Remove(Employee);
            CreateEmployee();
            EmployeeRepository.Employees.Add(Employee);
            Close();
        }

        private void CreateEmployee()
        {
            Employee = new Employee(
                editEmployeeFirstNameTextBox.Text,
                editEmployeeLastNameTextBox.Text,
                editEmployeeDateTimePicker.Value,
                editEmployeeOibTextBox.Text,
                (Jobs)editEmployeeJobComboBox.SelectedIndex
            );
        }

        public void SetupForm()
        {
            editEmployeeFirstNameTextBox.Text = Employee.FirstName;
            editEmployeeLastNameTextBox.Text = Employee.LastName;
            editEmployeeDateTimePicker.Value = Employee.DateOfBirth;
            editEmployeeOibTextBox.Text = Employee.Oib;
            editEmployeeJobComboBox.SelectedIndex = (int)Employee.Job;
        }
    }
}
