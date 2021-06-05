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
        //
        ListViewItem selectedLI;

        //for entering the database
        
        private OrderService orderService;

        private Order order;

        public Ordering(int tableNr, Employee employee)
        {
            InitializeComponent();

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
            
            List<Item> menuItems = ListOfMenuItemsByCategory(1); //if null then fill else get from the list

            CreateMenuButtons(menuItems);
        }

        private void bttnDiner_Click(object sender, EventArgs e)
        {
            flowPnlItems.Controls.Clear();
            List<Item> menuItems = ListOfMenuItemsByCategory(2);

            CreateMenuButtons(menuItems);
        }

        private void bttnDrinks_Click(object sender, EventArgs e)
        {
            flowPnlItems.Controls.Clear();
            List<Item> menuItems = ListOfMenuItemsByCategory(3);

            CreateMenuButtons(menuItems);
        }

        void itemButten_Click(object sender, EventArgs e)
        {
            Button bttn = (Button)sender;
            Item selectedItem = (Item)bttn.Tag;

            //check if order is already there ++ 
            OrderItem orderItem = new OrderItem();
            orderItem.Item = selectedItem;
            //orderItem.OrderID = order.OrderNr; //hmmmmm
            orderItem.OrderTime = DateTime.Now;
            orderItem.Quantity = 1;
            orderItem.State = State.NotStarted;
            //decrease stock

            order.orderedItems.Add(orderItem);

            //method display order running
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
            if (listViewOrderOrder.SelectedItems.Count > 0)
            {
                selectedLI = listViewOrderOrder.SelectedItems[0];
            }
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
            //order.orderedItems[].Quantity++;
        }


        //methods 
        private List<Item> ListOfMenuItemsByCategory(int categoryNr)
        {
            ItemService itemService = new ItemService();

            List<Item> menuItems = new List<Item>();
            menuItems = itemService.GetItemsByCategory(categoryNr);

            return menuItems;
        }

        private List<Item> ListOfMenuItemsBySubCategory(int subCategoryNr)
        {
            ItemService itemService = new ItemService();

            List<Item> menuItems = new List<Item>();
            menuItems = itemService.GetItemsBySubCategory(subCategoryNr);

            return menuItems;
        }

        private void CreateMenuButtons(List<Item> menuItems)
        {
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

    }
}
