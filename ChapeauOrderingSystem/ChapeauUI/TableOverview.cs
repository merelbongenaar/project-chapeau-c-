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
        private Order order;

        public TableOverview(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            lblEmployeeInfo.Text = $"{employee.EmployeeID}: {employee.Name}";

            //hide buttons order view 
            btnAddItem.Hide();
            btnPayForOrder.Hide();

            //refresh all table states and icons when the form opens
            RefreshTables();
            RefreshIcons();

            //create timer 
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 15000; // specify interval time as you want
            t.Tick += new EventHandler(timer_Tick);
            t.Start();

        }

        void timer_Tick(object sender, EventArgs e)
        {
            RefreshTables();
            RefreshIcons();
        }

        //------------------------------------------------------------------------------------LOG OUT------------------------------------------------------------------------------------------------------
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form loginForm = new Login();
            loginForm.Show();
        }

        //----------------------------------------------------------------------------------TABLE BUTTONS-----------------------------------------------------------------------------------------------------------
        private void btnTable1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int tableNr = Convert.ToInt32(button.Tag);
            btnAddItem.Tag = tableNr; //assign clicked tablenr to addbtn

            lblTableNR.Text = $"Table {tableNr}";

            TableService tableService = new TableService();
            OrderService orderService = new OrderService();

            Table selectedTable = tableService.GetTableByTableNR(tableNr);

            if (!selectedTable.IsOccupied)
            {
                DialogResult dialogResult = MessageBox.Show("occupy table", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    tableService.UpdateStateTableToTrue(tableNr);
                    button.BackColor = Color.Green;
                    RefreshTables();
                }
                else if (dialogResult == DialogResult.No)
                {
                    button.BackColor = Color.Gainsboro;
                }
            }
            else
            {
                btnAddItem.Show();
                btnPayForOrder.Show();

                listViewOrderTableOverview.Items.Clear();

                order = new Order();

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
            }

        }

        private void RefreshIcons()
        {
            PictureBox[] readyIcons = new PictureBox[] { readyTable1, readyTable2, readyTable3, readyTable4, readyTable5, readyTable6, readyTable7, readyTable8, readyTable9, readyTable10 };
            PictureBox[] preparingIcons = new PictureBox[] { preparingTable1, preparingTable2, preparingTable3, preparingTable4, preparingTable5, preparingTable6, preparingTable7, preparingTable8, preparingTable9, preparingTable10 };

            for (int j = 0; j < 10; j++)
            {
                readyIcons[j].Hide();
                preparingIcons[j].Hide();
            }


            OrderService orderService = new OrderService();
            List<Order> runningOrders = orderService.GetAllRunningOrders();

            Order currentOrder = runningOrders[0];

            int i = 0;
            foreach (Order o in runningOrders)
            {

                foreach (OrderItem item in o.orderedItems)
                {
                    if (item.State == State.Preparing)
                    {
                        preparingIcons[o.TableID - 1].Show();
                    }

                    //this should be removed i think
                    //else
                    //{
                    //    preparingIcons[i].Hide();
                    //}

                    if (item.State == State.Done)
                    {
                        readyIcons[o.TableID - 1].Show();
                    }

                    //this one as well
                    //else
                    //{
                    //    readyIcons[i].Hide();
                    //}
                }

                i++;
            }
        }

        private void RefreshTables()
        {
            TableService tableService = new TableService();
            List<Table> tables = tableService.GetAllTables();
            Button[] buttons = new Button[] { btnTable1, btnTable2, btnTable3, btnTable4, btnTable5, btnTable6, btnTable7, btnTable8, btnTable9, btnTable10 };

            int i = 0;
            foreach (Table table in tables)
            {
                if (table.IsOccupied)
                {
                    buttons[i].BackColor = Color.LightGreen;
                }
                else
                {
                    buttons[i].BackColor = Color.Gainsboro;
                }

                i++;
            }
        }


        //-------------------------------------------------------------------BUTTON ADD ITEM--------------------------------------------------------------------------------------------------------------------------
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //open new form yeraz
            Button btn = (Button)sender;
            int tableNr = (int)btn.Tag;

            Form formOrder = new Ordering(tableNr, employee);
            formOrder.Show();
           
        }

        //-------------------------------------------------------------------BUTTON PAY FOR ORDER---------------------------------------------------------------------------------------------------------------------
        private void btnPayForOrder_Click(object sender, EventArgs e)
        {
            Form formPayment = new BillForm(order);
            formPayment.Show();
        }




        //---------------------------------------------------------------i dont knwo what this is---------------------------------------------------------------------------------------------------------------------


        private void listViewOrderTableOverview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
