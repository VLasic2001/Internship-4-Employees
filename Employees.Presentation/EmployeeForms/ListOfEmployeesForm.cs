using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Employees.Data;
using Employees.Data.Classes;
using Employees.Domain;
using Employees.Domain.Repositories;

namespace Employees.Presentation.EmployeeForms
{
    public partial class ListOfEmployeesForm : Form
    {
        public EmployeeRepository EmployeeRepository { get; set; }
        public List<Employee> Employees { get; set; }
        public ProjectRepository ProjectRepository { get; set; }

        public ListOfEmployeesForm(EmployeeRepository employeeRepository, ProjectRepository projectRepository)
        {
            InitializeComponent();
            EmployeeRepository = employeeRepository;
            ProjectRepository = projectRepository;
            UpdateForm();
        }

        private void EditEmployee(object sender, EventArgs e)
        {
            if (ListOfEmployeesListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select employee you want to edit", "No employee selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var editEmployee = new EditEmployeeForm(EmployeeRepository, (Employee)ListOfEmployeesListBox.SelectedItem, ProjectRepository);
            editEmployee.ShowDialog();
            UpdateForm();
        }

        private void Details(object sender, EventArgs e)
        {
            if (ListOfEmployeesListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select employee you want to see the details of", "No employee selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var employeeDetails = new  EmployeeDetailsForm(EmployeeRepository, (Employee)ListOfEmployeesListBox.SelectedItem, ProjectRepository);
            employeeDetails.ShowDialog();
            UpdateForm();
        }

        private void UpdateForm()
        {
            ListOfEmployeesListBox.Items.Clear();
            Employees = EmployeeRepository.GetAllItems();
            foreach (var employee in Employees)
            {
                ListOfEmployeesListBox.Items.Add(employee);
            }
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
