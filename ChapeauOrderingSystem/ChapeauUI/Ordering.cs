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
        private Order currentOrder;
        private OrderItem selectedOrderItem;

        public Ordering(int tableNr, Employee employee)
        {
            InitializeComponent();

            //creata an order for the table
            currentOrder = new Order();
            currentOrder.EmployeeID = employee.EmployeeID;
            currentOrder.StartTime = DateTime.Now;
            currentOrder.TableID = tableNr;
            currentOrder.EndTime = null;

            //fill the lables with the employee name and the table nr
            lblEmployeeName.Text = employee.Name.ToString();
            lblTableNr.Text = tableNr.ToString();
        }

        private void listViewOrderOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select an item from the listview and add this to a variable
            if (listViewOrderOrder.SelectedItems.Count > 0)
            {


                //ListViewItem selectedItem = listViewOrderOrder.SelectedItems[0];
                //selectedItem.Tag = listViewOrderOrder.SelectedItems;
                //selectedOrderItem.Item = (Item)selectedItem.Tag;
            }
        }

        /////////////////////////////////////////////////////////////sending order to the database
        private void bttnSend_Click(object sender, EventArgs e)
        {
            //send order to the database
            OrderService orderService = new OrderService();
            orderService.AddDataToOrder(currentOrder); //does not work yet
        }

        /////////////////////////////////////////////////////////////buttons for changing the orderItem
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
            listViewOrderOrder.Items.Clear();

            foreach (OrderItem orderItem in currentOrder.orderedItems)
            {
                ListViewItem li = new ListViewItem(orderItem.Quantity.ToString()); ///(orderItem.Item.ItemID.ToString());
                li.SubItems.Add(orderItem.Item.ItemName);
                //li.SubItems.Add(orderItem.Quantity.ToString());

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

        /////////////////////////////////////////////////////////////////////methods creating buttons         
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

                currentOrder.orderedItems.Add(orderItem);

                DisplayRunningOrders();
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

            flowPnlItems.Controls.Clear();

            List<Item> menuItems = new List<Item>();
            if (menuItems.Count == 0)
            {
                MessageBox.Show("test"); //this always shows up :(
                menuItems = ListOfMenuItemsBySubCategory(subCategory);
            }

            CreateMenuButtons(menuItems);
        }
    }
}
