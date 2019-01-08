using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Data;
using Employees.Domain;
using System.Windows.Forms;

namespace Employees.Presentation
{
    public partial class DeleteEmployeeForm : Form
    {
        public EmployeeRepository EmployeeRepository { get; set; }
        public List<Employee> Employees { get; set; }

        public DeleteEmployeeForm(EmployeeRepository employeeRepository)
        {
            InitializeComponent();
            EmployeeRepository = employeeRepository;
            deleteEmployeeCheckedListBox.Items.Clear();
            Employees = EmployeeRepository.GetAllItems();
            foreach (var employee in Employees)
            {
                deleteEmployeeCheckedListBox.Items.Add(employee);
            }
        }

        private void DeleteEmployee(object sender, EventArgs e)
        {
            if (deleteEmployeeCheckedListBox.SelectedItem == null) Close();
            var employeeToDelete = deleteEmployeeCheckedListBox.SelectedItem as Employee;
            EmployeeRepository.RemoveEmployee(employeeToDelete);
            Close();
        }
    }
}
