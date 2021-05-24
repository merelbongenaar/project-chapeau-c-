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
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Employee employee = new Employee();
            EmployeeService employeeService = new EmployeeService();

            employee = employeeService.GetEmployee(username, password);

            if (employee != null)
            {
                if (employee.Role == "w")
                {
                    TableOverview tableOverview = new TableOverview(employee);
                    this.Hide();

                    tableOverview.ShowDialog();
                }

                else if (employee.Role == "k" || employee.Role == "b")
                {
                    //open new form ruben and pass employee object
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
            }

        }
    }
}
