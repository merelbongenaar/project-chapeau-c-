using ChapeauLogic;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            lblEmployeeInfo.Text = $"Employee: {employee.Name} ({employee.EmployeeID})";

            //hide buttons order view 
            btnAddItem.Hide();
            btnPayForOrder.Hide();

            //refresh all table states and icons when the form opens
            RefreshTables();
            RefreshIcons();

            //create timer 
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 15000;
            t.Tick += new EventHandler(timer_Tick);
            t.Start();

        }

        //event which happens each interval
        void timer_Tick(object sender, EventArgs e)
        {
            RefreshTables();
            RefreshIcons();
        }

        //------------------------------------------------------------------------------------LOG OUT------------------------------------------------------------------------------------------------------
        private void btnLogout_Click(object sender, EventArgs e)
        {
            //close tableoverview and open login form
            this.Close();
            Form loginForm = new Login();
            loginForm.Show();
        }

        //----------------------------------------------------------------------------------TABLE BUTTONS-----------------------------------------------------------------------------------------------------------
        private void btnTable1_Click(object sender, EventArgs e)
        {
            //see which table button has been clicked
            Button button = (Button)sender;

            int tableNr = Convert.ToInt32(button.Tag);
            btnAddItem.Tag = tableNr;

            lblTableNR.Text = $"Table {tableNr}";

            TableService tableService = new TableService();
            OrderService orderService = new OrderService();

            //get state table
            Table selectedTable = tableService.GetTableByTableNR(tableNr);

            if (!selectedTable.IsOccupied)
            {
                DialogResult dialogResult = MessageBox.Show($"Do you want to seat guests at table {tableNr}", "Seat guests", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    tableService.UpdateStateTableToTrue(tableNr);
                    button.BackColor = Color.PaleTurquoise;
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



        //-----------------------------------------------------------------------------------------------mark item as served----------------------------------------------------------------------------------------------------------------------------

        private void readyTable1_Click(object sender, EventArgs e)
        {
            //when the readyicon is clicked => update state orderitems to served

            PictureBox icon = (PictureBox)sender;
            int tableNr = Convert.ToInt32(icon.Tag);

            OrderItemService orderItemservice = new OrderItemService();
            OrderService orderservice = new OrderService();

            DialogResult dialogResult = MessageBox.Show($"Do you want to update the food status to served for table {tableNr}?", "Serve food", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Order order = orderservice.GetOrderByTableNR(tableNr);
                orderItemservice.UpdateOrderState(State.Served, order.OrderNr);
                icon.Hide();
            }

        }

        //----------------------------------------------------------------------------------------------icons-------------------------------------------------------------------------------------------------------------------------------------------
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

                    if (item.State == State.Done)
                    {
                        readyIcons[o.TableID - 1].Show();
                    }
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
                    buttons[i].BackColor = Color.PaleTurquoise;
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

            formOrder.StartPosition = FormStartPosition.Manual;
            formOrder.Location = this.Location;
            formOrder.Size = this.Size;

            Close();
            formOrder.Show();

        }

        //-------------------------------------------------------------------BUTTON PAY FOR ORDER---------------------------------------------------------------------------------------------------------------------
        private void btnPayForOrder_Click(object sender, EventArgs e)
        {
            Form formPayment = new BillForm(order);

            formPayment.StartPosition = FormStartPosition.Manual;
            formPayment.Location = this.Location;
            formPayment.Size = this.Size;

            formPayment.Show();

            //refresh table status and icons
            RefreshTables();
            RefreshIcons();
        }
    }
}
