using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees.Domain;

namespace Employees.Presentation
{
    public partial class MenuForm : Form
    {
        public EmployeeRepository EmployeeRepository { get; set; }

        public MenuForm()
        {
            InitializeComponent();
            EmployeeRepository = new EmployeeRepository();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            var addEmployee = new AddEmployeeForm(EmployeeRepository);
            addEmployee.ShowDialog();
            EmployeeRepository.Employees.Add(
            addEmployee.EmployeeRepository.Employees[addEmployee.EmployeeRepository.Employees.Count - 1]);
        }
    }
}
