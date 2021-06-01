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
        Order order;

        public Ordering(Table table)
        {
            InitializeComponent();
            order = new Order();

            //lblTableNr.Text = table.TableNumber.ToString();
        }

        /// <summary>
        /// buttons for the menu items
        /// </summary>
        private void bttnLunch_Click(object sender, EventArgs e)
        {
            //clear all items
            flowPnlItems.Controls.Clear();

            List<Item> lunchItems = new List<Item>();
            lunchItems = itemService.GetItemsByCategory(1);

            foreach (Item item in lunchItems)
            {
                //127, 104
                Button itemButten = new Button();
                itemButten.Text = item.ItemName;
                itemButten.Size = new Size(90, 90);

                flowPnlItems.Controls.Add(itemButten);
            }
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

            List<Item> lunchItems = new List<Item>();
            lunchItems = itemService.GetItemsByCategory(3);

            foreach (Item item in lunchItems)
            {
                Button itemButten = new Button();
                itemButten.Text = item.ItemName;
                itemButten.Size = new Size(90, 90);

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
    }
}
