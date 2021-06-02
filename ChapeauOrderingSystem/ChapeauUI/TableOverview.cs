﻿using System;
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
            RefreshIcons();

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
            btnAddItem.Tag = tableNr; //assign clicked tablenr to addbtn

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

            int i = 0;
            foreach (Order o in runningOrders)
            {
                foreach (OrderItem item in o.orderedItems)
                {
                    if (item.State == State.Preparing)
                    {
                        preparingIcons[i].Show();
                    }
                    else
                    {
                        preparingIcons[i].Hide();
                    }

                    if (item.State == State.Done)
                    {
                        readyIcons[i].Show();
                    }
                    else
                    {
                        readyIcons[i].Hide();
                    }
                }

                i++;
            }

            //foreach (Order o in runningOrders)
            //{
            //    foreach (OrderItem orderItem in o.orderedItems)
            //    {
            //        if (orderItem.Item.SubCategory == SubCategory.Starters)
            //        {

            //        }
            //    }
            //}
        }

        private void RefreshTables()
        {
            //List<Table> tables = new List<Table>();
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

            Form formOrder = new Ordering(tableNr);
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
            RefreshIcons();
        }

        private void listViewOrderTableOverview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //if (tables[0].IsOccupied)
        //{
        //    btnTable1.BackColor = Color.LightGreen;
        //}
        //else
        //{
        //    btnTable1.BackColor = Color.Gainsboro;
        //}

        //if (tables[1].IsOccupied)
        //{
        //    btnTable2.BackColor = Color.LightGreen;
        //}
        //else
        //{
        //    btnTable2.BackColor = Color.Gainsboro;
        //}

        //if (tables[2].IsOccupied)
        //{
        //    btnTable3.BackColor = Color.LightGreen;
        //}
        //else
        //{
        //    btnTable3.BackColor = Color.Gainsboro;
        //}

        //if (tables[3].IsOccupied)
        //{
        //    btnTable4.BackColor = Color.LightGreen;
        //}
        //else
        //{
        //    btnTable4.BackColor = Color.Gainsboro;
        //}

        //if (tables[4].IsOccupied)
        //{
        //    btnTable5.BackColor = Color.LightGreen;
        //}
        //else
        //{
        //    btnTable5.BackColor = Color.Gainsboro;
        //}

        //if (tables[5].IsOccupied)
        //{
        //    btnTable6.BackColor = Color.LightGreen;
        //}
        //else
        //{
        //    btnTable6.BackColor = Color.Gainsboro;
        //}

        //if (tables[6].IsOccupied)
        //{
        //    btnTable7.BackColor = Color.LightGreen;
        //}
        //else
        //{
        //    btnTable7.BackColor = Color.Gainsboro;
        //}

        //if (tables[7].IsOccupied)
        //{
        //    btnTable8.BackColor = Color.LightGreen;
        //}
        //else
        //{
        //    btnTable8.BackColor = Color.Gainsboro;
        //}

        //if (tables[8].IsOccupied)
        //{
        //    btnTable9.BackColor = Color.LightGreen;
        //}
        //else
        //{
        //    btnTable9.BackColor = Color.Gainsboro;
        //}


        //if (tables[9].IsOccupied)
        //{
        //    btnTable10.BackColor = Color.LightGreen;
        //}
        //else
        //{
        //    btnTable10.BackColor = Color.Gainsboro;
        //}
    }
}
