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
        private Table table;

        public TableOverview(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            lblEmployeeInfo.Text = $"{employee.EmployeeID}: {employee.Name}";

            btnAddItem.Hide();
            btnPayForOrder.Hide();

            RefreshTables();

            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 15000; // specify interval time as you want
            t.Tick += new EventHandler(timer_Tick);
            t.Start();

        }

        void timer_Tick(object sender, EventArgs e)
        {
            RefreshTables();
        }



        //----------------------------------------------------------------------------------TABLE BUTTONS-----------------------------------------------------------------------------------------------------------
        private void btnTable1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int tableNr = Convert.ToInt32(button.Tag);

            lblTableNR.Text = $"Table {tableNr}";

            TableService tableService = new TableService();
            OrderService orderService = new OrderService();

            if (btnTable1.BackColor == Color.Gainsboro)
            {
                DialogResult dialogResult = MessageBox.Show("occupy table", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    tableService.UpdateStateTableToTrue(tableNr);
                    button.BackColor = Color.Green;
                }
                else if (dialogResult == DialogResult.No)
                {
                    button.BackColor = Color.Gainsboro;
                }
            }

            else if (btnTable1.BackColor == Color.LightGreen)
            {
                btnAddItem.Show();
                btnPayForOrder.Show();

                listViewOrderTableOverview.Items.Clear();

                Order order = new Order();
                order = orderService.GetOrderByTableNR(tableNr);

                if (order != null)
                {
                    foreach (OrderItem orderItem in order.orderedItems)
                    {
                        ListViewItem li = new ListViewItem(orderItem.Item.ItemName);
                        li.SubItems.Add(orderItem.Quantity.ToString());

                        listViewOrderTableOverview.Items.Add(li);
                    }
                }


                //now table name should show up on the right and also a + sign that will link to the order part
                //maybe also and unoccupy bttn and update state back to unoccupied

            }

          

        }



        //-------------------------------------------------------------------BUTTON ADD ITEM--------------------------------------------------------------------------------------------------------------------------
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //open new form yeraz
            Form formOrder = new Ordering(table);
            formOrder.Show();
           
        }

        //-------------------------------------------------------------------BUTTON PAY FOR ORDER---------------------------------------------------------------------------------------------------------------------
        private void btnPayForOrder_Click(object sender, EventArgs e)
        {
            //open new form mohammed
        }




        //---------------------------------------------------------------i dont knwo what this is---------------------------------------------------------------------------------------------------------------------
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTables();
        }

        private void RefreshTables()
        {
            //List<Table> tables = new List<Table>();
            TableService tableService = new TableService();

            List<Table> tables = tableService.GetAllTables();

            if (tables[0].IsOccupied)
            {
                btnTable1.BackColor = Color.LightGreen;
            }
            else
            {
                btnTable1.BackColor = Color.Gainsboro;
            }

            if (tables[1].IsOccupied)
            {
                btnTable2.BackColor = Color.LightGreen;
            }
            else
            {
                btnTable2.BackColor = Color.Gainsboro;
            }

            if (tables[2].IsOccupied)
            {
                btnTable3.BackColor = Color.LightGreen;
            }
            else
            {
                btnTable3.BackColor = Color.Gainsboro;
            }

            if (tables[3].IsOccupied)
            {
                btnTable4.BackColor = Color.LightGreen;
            }
            else
            {
                btnTable4.BackColor = Color.Gainsboro;
            }

            if (tables[4].IsOccupied)
            {
                btnTable5.BackColor = Color.LightGreen;
            }
            else
            {
                btnTable5.BackColor = Color.Gainsboro;
            }

            if (tables[5].IsOccupied)
            {
                btnTable6.BackColor = Color.LightGreen;
            }
            else
            {
                btnTable6.BackColor = Color.Gainsboro;
            }

            if (tables[6].IsOccupied)
            {
                btnTable7.BackColor = Color.LightGreen;
            }
            else
            {
                btnTable7.BackColor = Color.Gainsboro;
            }

            if (tables[7].IsOccupied)
            {
                btnTable8.BackColor = Color.LightGreen;
            }
            else
            {
                btnTable8.BackColor = Color.Gainsboro;
            }

            if (tables[8].IsOccupied)
            {
                btnTable9.BackColor = Color.LightGreen;
            }
            else
            {
                btnTable9.BackColor = Color.Gainsboro;
            }


            if (tables[9].IsOccupied)
            {
                btnTable10.BackColor = Color.LightGreen;
            }
            else
            {
                btnTable10.BackColor = Color.Gainsboro;
            }
        }


        private void listViewOrderTableOverview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
