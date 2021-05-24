using System;
using ChapeauModel;
using ChapeauLogic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChapeauUI
{
    public partial class TableOverview : Form
    {
        private Employee employee;

        public TableOverview(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            lblEmployeeInfo.Text = $"{employee.EmployeeID}: {employee.Name}";

            btnAddItem.Hide();
            btnPayForOrder.Hide();
        }

        //----------------------------------------------------------------------------------TABLE BUTTONS-----------------------------------------------------------------------------------------------------------
        private void btnTable1_Click(object sender, EventArgs e)
        {
            lblTableNR.Text = "Table 1";

            TableService tableService = new TableService();
            OrderService orderService = new OrderService();

            if (btnTable1.BackColor == Color.PaleTurquoise)
            {
                DialogResult dialogResult = MessageBox.Show("occupy table", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    tableService.UpdateStateTableToTrue(1);
                    btnTable1.BackColor = Color.Green;
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
            }

            else if (btnTable1.BackColor == Color.Green)
            {
                btnAddItem.Show();
                btnPayForOrder.Show();
                

                //now table name should show up on the right and also a + sign that will link to the order part
                //maybe also and unoccupy bttn and update state back to unoccupied
                
            }

            else if (btnTable1.BackColor == Color.Yellow)
            {
                listViewOrderTableOverview.Items.Clear();

                Order order = new Order();
                order = orderService.GetOrderByTableNR(1);

                foreach (OrderItem orderItem in order.orderedItems)
                {
                    ListViewItem li = new ListViewItem(orderItem.Item.ItemName);
                    li.SubItems.Add(orderItem.Quantity.ToString());

                    listViewOrderTableOverview.Items.Add(li);
                }
            }

        }

        private void btnTable2_Click(object sender, EventArgs e)
        {

        }
        private void btnTable3_Click(object sender, EventArgs e)
        {

        }

        private void btnTable4_Click(object sender, EventArgs e)
        {

        }

        private void btnTable5_Click(object sender, EventArgs e)
        {

        }

        private void btnTable6_Click(object sender, EventArgs e)
        {

        }

        private void btnTable7_Click(object sender, EventArgs e)
        {

        }

        private void bntTable8_Click(object sender, EventArgs e)
        {

        }

        private void btnTable9_Click(object sender, EventArgs e)
        {

        }

        private void btnTable10_Click(object sender, EventArgs e)
        {

        }



        //-------------------------------------------------------------------BUTTON ADD ITEM--------------------------------------------------------------------------------------------------------------------------
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //open new form yeraz
        }

        //-------------------------------------------------------------------BUTTON PAY FOR ORDER---------------------------------------------------------------------------------------------------------------------
        private void btnPayForOrder_Click(object sender, EventArgs e)
        {
            //open new form mohammed
        }




        //---------------------------------------------------------------i dont knwo what this is---------------------------------------------------------------------------------------------------------------------
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //List<Table> tables = new List<Table>();
            TableService tableService = new TableService();

            List<Table> tables = tableService.GetAllTables();

            if (tables[0].IsOccupied)
            {
                btnTable1.BackColor = Color.Red;
            }
            else
            {
                btnTable1.BackColor = Color.Green;
            }

            if (tables[1].IsOccupied)
            {
                btnTable2.BackColor = Color.Red;
            }
            else
            {
                btnTable2.BackColor = Color.Green;
            }

            if (tables[2].IsOccupied)
            {
                btnTable3.BackColor = Color.Red;
            }
            else
            {
                btnTable3.BackColor = Color.Green;
            }

            if (tables[3].IsOccupied)
            {
                btnTable4.BackColor = Color.Red;
            }
            else
            {
                btnTable4.BackColor = Color.Green;
            }


        }


        private void listViewOrderTableOverview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
