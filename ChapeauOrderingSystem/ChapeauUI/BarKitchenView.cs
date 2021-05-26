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
using ChapeauUI;

namespace ChapeauUI
{
    public partial class BarKitchenView : Form
    {
        public Employee employee;

        public BarKitchenView(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        public void DisplayOrder(Order order)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void DeleteThisButton_Click(object sender, EventArgs e)
        {
            FoodOrder testorder = new FoodOrder(new Order());
            testorder.Location = new Point(7, 7);
        }
    }
}
