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
            ListOfEmployeesListBox.Items.Clear();
            Employees = EmployeeRepository.GetAllItems();
            foreach (var employee in Employees)
            {
                ListOfEmployeesListBox.Items.Add(employee);
            }
        }

        private void EditEmployee(object sender, EventArgs e)
        {
            var editEmployee = new EditEmployeeForm(EmployeeRepository, (Employee)ListOfEmployeesListBox.SelectedItem);
            editEmployee.ShowDialog();
            ListOfEmployeesListBox.Items.Clear();
            Employees = EmployeeRepository.GetAllItems();
            foreach (var employee in Employees)
            {
                ListOfEmployeesListBox.Items.Add(employee);
            }
        }

        private void Details(object sender, EventArgs e)
        {
            var employeeDetails = new  EmployeeDetailsForm(EmployeeRepository, (Employee)ListOfEmployeesListBox.SelectedItem, ProjectRepository);
            employeeDetails.ShowDialog();
        }
    }
}
