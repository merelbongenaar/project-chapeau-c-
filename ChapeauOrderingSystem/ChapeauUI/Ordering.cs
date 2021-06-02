using ChapeauLogic;
using ChapeauModel;
using System;
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
    public partial class Ordering : Form
    { 
        ItemService itemService = new ItemService();
        //private Table table;
        int tablenr; 

        public Ordering(int tablenr)
        {
            InitializeComponent();
            this.tablenr = tablenr;

            lblTableNr.Text = tablenr.ToString();
        }

        /// <summary>
        /// buttons for the menu items
        /// </summary>
        private void bttnLunch_Click(object sender, EventArgs e)
        {
            Button[] buttons = new Button[50];
            int i = 0;

            //clear all items
            flowPnlItems.Controls.Clear();

            List<Item> lunchItems = new List<Item>();
            lunchItems = itemService.GetItemsByCategory(1);

            foreach (Item item in lunchItems)
            {
                Button itemButten = new Button();
                itemButten.Text = item.ItemName;
                itemButten.Size = new Size(90, 90);
                itemButten.Click += new EventHandler(itemButten_Click);

                flowPnlItems.Controls.Add(itemButten);
                buttons[i] = itemButten;
                i++;
            }
        }

        void itemButten_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

        }

        private void bttnDiner_Click(object sender, EventArgs e)
        {
            //clear all items
            flowPnlItems.Controls.Clear();

            List<Item> lunchItems = new List<Item>();
            lunchItems = itemService.GetItemsByCategory(2);

            foreach (Item item in lunchItems)
            {
                Button itemButten = new Button();
                itemButten.Text = item.ItemName;
                itemButten.Size = new Size(90, 90);

                flowPnlItems.Controls.Add(itemButten);
            }
        }

        private void bttnDrinks_Click(object sender, EventArgs e)
        {
            //clear all items
            flowPnlItems.Controls.Clear();

            //should be class level i think
            List<Item> lunchItems = new List<Item>();
            lunchItems = itemService.GetItemsByCategory(3);

            foreach (Item item in lunchItems)
            {
                Button itemButten = new Button();
                itemButten.Text = item.ItemName;
                itemButten.Size = new Size(90, 90);

                itemButten.Tag = item.ItemID; //or should this be the item name?

                flowPnlItems.Controls.Add(itemButten);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void bttnSend_Click(object sender, EventArgs e)
        {
            //send order to kitchen/bar
        }

        private void listViewOrderOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order order = new Order();
            
            //comment button is clicked, open a new form
            if (true)
            {
                var formPopup = new Form();
                formPopup.Show(this); // if you need non-modal window
            }

           
        }


        //                  listViewOrderTableOverview.Items.Clear();

        //                Order order = new Order();
        //        order = orderService.GetOrderByTableNR(tableNr);

        //                if (order != null)
        //                {
        //                    foreach (OrderItem orderItem in order.orderedItems)
        //                    {
        //                        ListViewItem li = new ListViewItem(orderItem.Item.ItemName);
        //        li.SubItems.Add(orderItem.Quantity.ToString());

        //                        listViewOrderTableOverview.Items.Add(li);
        //                    }
        //}
    }
}
