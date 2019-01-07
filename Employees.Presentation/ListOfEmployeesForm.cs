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
        private EmployeeRepository EmployeeRepository { get; set; }
        public List<Employee> Employees { get; set; }

        public ListOfEmployeesForm(EmployeeRepository employeeRepository)
        {
            InitializeComponent();
            EmployeeRepository = employeeRepository;
            ListOfEmployeesCheckedListBox.Items.Clear();
            Employees = EmployeeRepository.GetAllItems();
            foreach (var employee in Employees)
            {
                ListOfEmployeesCheckedListBox.Items.Add($"{employee.FirstName} {employee.LastName}, {employee.DateOfBirth}, {employee.Oib}, {employee.Job}");
            }
        }
    }
}
