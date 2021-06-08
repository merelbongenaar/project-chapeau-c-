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
        private Order order;
        private ListViewItem selectedItem;

        public Ordering(int tableNr, Employee employee)
        {
            InitializeComponent();

            order = new Order();
            order.EmployeeID = employee.EmployeeID;
            order.StartTime = DateTime.Now;
            order.TableID = tableNr;
            order.EndTime = null;

            lblEmployeeName.Text = employee.Name.ToString();
            lblTableNr.Text = tableNr.ToString();
        }

        void itemButten_Click(object sender, EventArgs e)
        {
            Button bttn = (Button)sender;
            Item selectedMenuItem = (Item)bttn.Tag;

            if (selectedMenuItem.Stock <= 0)
            {
                MessageBox.Show($"{selectedMenuItem.ItemName} is out of stock");
            }
            else
            {
                //method create new orderItem?
                OrderItem orderItem = new OrderItem();        //check if an order item is already there, ++;
                orderItem.Item = selectedMenuItem;
                //orderItem.OrderID = order.OrderNr; //hmmmmm
                orderItem.OrderTime = DateTime.Now;
                orderItem.Quantity = 1;
                orderItem.State = State.NotStarted;
                //decrease the stock everytime an item is ordered 
                orderItem.Item.Stock--;

                order.orderedItems.Add(orderItem);

                DisplayRunningOrders();
            }  
        }

        private void bttnSend_Click(object sender, EventArgs e)
        {
            //send order to kitchen/bar
            OrderService orderService = new OrderService();
            orderService.AddDataToOrder(order); //does not work yet
        }

        private void listViewOrderOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrderOrder.SelectedItems.Count > 0)
            {
                selectedItem = listViewOrderOrder.SelectedItems[0];
            }
            
        }

        /////////////////////////////////////////////////////////////buttons for changing the order
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
            //order.orderedItems[selectedItem].Quantity++;
        }


        /////////////////////////////////////////////////////////////////////methods 
        private void DisplayRunningOrders()
        {
            foreach (OrderItem orderItem in order.orderedItems)
            {
                ListViewItem li = new ListViewItem(orderItem.Item.ItemID.ToString());
                li.SubItems.Add(orderItem.Item.ItemName);
                li.SubItems.Add(orderItem.Quantity.ToString());

                listViewOrderOrder.Items.Add(li);
            }
            

        }

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

        /////////////////////////////////////////////////////////////////buttons category 
        private void bttnMenuCategory_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int category = Convert.ToInt32(button.Tag);
            button.Tag = category;

            flowPnlItems.Controls.Clear();

            List<Item> menuItems = new List<Item>();
            if (menuItems.Count <= 0)
            {
                menuItems = ListOfMenuItemsByCategory(category);
            }

            CreateMenuButtons(menuItems);
        }

        /////////////////////////////////////////////////////////////////buttons Subcategorys
        private void bttnMenuSubCatgory_Click(object sender, EventArgs e)
        {
            //
            Button button = (Button)sender;

            int subCategory = Convert.ToInt32(button.Tag);
            button.Tag = subCategory;

            //make this button for all sub categorys 
            flowPnlItems.Controls.Clear();

            List<Item> menuItems = new List<Item>();
            if (menuItems.Count <= 0)
            {
                menuItems = ListOfMenuItemsBySubCategory(subCategory);
            }

            CreateMenuButtons(menuItems);
        }
    }
}
