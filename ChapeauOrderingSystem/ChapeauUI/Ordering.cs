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
        //for displaying the menu buttons
        private List<Item> menuItems;

        //for entering the database
        private ItemService itemService;
        private OrderService orderService;

        private Order order;

        public Ordering(int tableNr, Employee employee)
        {
            InitializeComponent();

            menuItems = new List<Item>();
            itemService = new ItemService();
            orderService = new OrderService();

            order = new Order();
            order.EmployeeID = employee.EmployeeID;
            order.StartTime = DateTime.Now;
            order.TableID = tableNr;
            order.EndTime = null;

            lblEmployeeName.Text = employee.Name.ToString();
            lblTableNr.Text = tableNr.ToString();
        }

        private void bttnLunch_Click(object sender, EventArgs e)
        {
            flowPnlItems.Controls.Clear();
            menuItems = itemService.GetItemsByCategory(1);

            foreach (Item item in menuItems)
            {
                Button itemButten = new Button();
                itemButten.Text = item.ItemName;
                itemButten.Size = new Size(90, 90);
                itemButten.Click += new EventHandler(itemButten_Click);
                itemButten.Tag = item;

                flowPnlItems.Controls.Add(itemButten);
            }
        }

        private void bttnDiner_Click(object sender, EventArgs e)
        {
            flowPnlItems.Controls.Clear();
            menuItems = itemService.GetItemsByCategory(2);

            foreach (Item item in menuItems)
            {
                Button itemButten = new Button();
                itemButten.Text = item.ItemName;
                itemButten.Size = new Size(90, 90);
                itemButten.Click += new EventHandler(itemButten_Click);
                itemButten.Tag = item;

                flowPnlItems.Controls.Add(itemButten);
            }
        }

        private void bttnDrinks_Click(object sender, EventArgs e)
        {
            flowPnlItems.Controls.Clear();
            menuItems = itemService.GetItemsByCategory(3);

            foreach (Item item in menuItems)
            {
                Button itemButten = new Button();
                itemButten.Text = item.ItemName;
                itemButten.Size = new Size(90, 90);
                itemButten.Click += new EventHandler(itemButten_Click);
                itemButten.Tag = item;

                flowPnlItems.Controls.Add(itemButten);
            }
        }

        void itemButten_Click(object sender, EventArgs e)
        {
            Button bttn = (Button)sender;
            Item selectedItem = (Item)bttn.Tag;

            OrderItem orderItem = new OrderItem();
            orderItem.Item = selectedItem;
            //orderItem.OrderID = order.OrderNr; //hmmmmm
            orderItem.OrderTime = DateTime.Now;
            orderItem.Quantity = 1;
            orderItem.State = State.NotStarted;

            order.orderedItems.Add(orderItem);

            ListViewItem li = new ListViewItem(orderItem.Item.ItemName);
            li.SubItems.Add(orderItem.Quantity.ToString());

            listViewOrderOrder.Items.Add(li);
        }

        private void bttnSend_Click(object sender, EventArgs e)
        {
            //send order to kitchen/bar
            orderService.AddDataToOrder(order);
        }

        private void listViewOrderOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (listViewDrinks.SelectedItems.Count > 0)
            //{
            //    ListViewItem li = listViewDrinks.SelectedItems[0];
            //    txtBoxDrinkId.Text = li.SubItems[0].Text;
            //    txtBoxDrinkName.Text = li.SubItems[1].Text;
            //    txtBoxPrice.Text = li.SubItems[2].Text;
            //    txtBoxStock.Text = li.SubItems[3].Text;
            //    txtBoxAlcohol.Text = li.SubItems[4].Text;
            //}
        }

        private void bttnAddComment_Click(object sender, EventArgs e)
        {
            //comment button is clicked, open a new form

            //    var formPopup = new Form();
            //    formPopup.Show(this); // if you need non-modal window
        }

        private void bttnRemoveItem_Click(object sender, EventArgs e)
        {

        }

        private void bttnAddQNT_Click(object sender, EventArgs e)
        {
            order.orderedItems[0].Quantity++;
        }
    }
}
