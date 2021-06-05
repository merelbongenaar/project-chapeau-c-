using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //read user input
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Employee employee = new Employee();
            EmployeeService employeeService = new EmployeeService();

            //get employee from database
            employee = employeeService.GetEmployee(username, password);

            //check if input is correct 
            if (employee != null)
            {
                //open different forms according to the role of the employee
                if (employee.Role == Role.Waiter)
                {
                    TableOverview tableOverview = new TableOverview(employee);
                    this.Hide();

                    tableOverview.ShowDialog();
                }

                else if (employee.Role == Role.Kitchen || employee.Role == Role.Bar)
                {
                    //Form kitchenOrBarView = new Form(employee);
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
            }

        }
    }
}
