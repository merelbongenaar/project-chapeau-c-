using ChapeauLogic;
using ChapeauModel;
using System;
using System.Windows.Forms;

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
                    Form tableOverview = new TableOverview(employee);
                    this.Hide();

                    //open new form same location and size as login form 
                    tableOverview.StartPosition = FormStartPosition.Manual;
                    tableOverview.Location = this.Location;
                    tableOverview.Size = this.Size;

                    tableOverview.ShowDialog();
                }

                else if (employee.Role == Role.Kitchen || employee.Role == Role.Bar)
                {
                    BarKitchenView barKitchenView = new BarKitchenView(employee);

                    //open new form same location and size as login form
                    barKitchenView.StartPosition = FormStartPosition.Manual;
                    barKitchenView.Location = this.Location;
                    barKitchenView.Size = this.Size;

                    this.Hide();

                    barKitchenView.Show();
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
            }

        }
    }
}
