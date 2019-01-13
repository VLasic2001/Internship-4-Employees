using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Employees.Data;
using Employees.Data.Classes;
using Employees.Domain;
using Employees.Domain.Repositories;

namespace Employees.Presentation.EmployeeForms
{
    public partial class DeleteEmployeeForm : Form
    {
        public EmployeeRepository EmployeeRepository { get; set; }
        public List<Employee> Employees { get; set; }

        public DeleteEmployeeForm(EmployeeRepository employeeRepository)
        {
            InitializeComponent();
            EmployeeRepository = employeeRepository;
            UpdateList();
        }

        private void DeleteEmployee(object sender, EventArgs e)
        {

            if (EmployeeListBox.SelectedItem == null)
            {
                MessageBox.Show("You must select the employee you want to delete", "No employee selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selection = (Employee) EmployeeListBox.SelectedItem;
            if (IsOnlyEmployeeOnAnyProject(selection))
            {
                MessageBox.Show("Cannot delete selected employee because he is the only employee a project", "Cannot delete employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show($"Are you sure you want to delete {selection.FirstName} {selection.LastName}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            var employeeToDelete = (Employee) EmployeeListBox.SelectedItem;
            DeleteEmployee(employeeToDelete);
            UpdateList();
        }

        private void UpdateList()
        {
            EmployeeListBox.Items.Clear();
            Employees = EmployeeRepository.GetAllItems();
            foreach (var employee in Employees)
            {
                EmployeeListBox.Items.Add(employee);
            }
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }

        private static bool IsOnlyEmployeeOnAnyProject(Employee employee)
        {
            var isOnlyEmployeeCounter = 0;
            if (employee.ProjectsAndWorkHours.Count == 0) return false;
            foreach (var project in employee.ProjectsAndWorkHours.Keys)
            {
                if (project.EmployeesOnProjectAndWorkHours.Keys.Count == 1)
                {
                    isOnlyEmployeeCounter++;
                }
            }

            return isOnlyEmployeeCounter != 0;
        }

        private void DeleteEmployee(Employee employeeToDelete)
        {
            EmployeeRepository.RemoveEmployee(employeeToDelete);
        }
    }
}
