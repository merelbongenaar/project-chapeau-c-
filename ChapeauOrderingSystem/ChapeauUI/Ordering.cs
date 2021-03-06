using ChapeauLogic;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace ChapeauUI
{
    public partial class Ordering : Form
    {
        private Employee employee;
        private Order currentOrder;
        private OrderItem selectedOrderItem;
        private int nrOfItemsInRunningOrder;

        public Ordering(int tableNr, Employee employee)
        {
            InitializeComponent();

            this.employee = employee;


            OrderService orderService = new OrderService();
            Order order = orderService.GetOrderByTableNR(tableNr);

            //check if order is already running
            if (order == null)
            {
                //orderID
                int orderID = orderService.GetLastOrder();
                orderID++;

                currentOrder = new Order();
                currentOrder.EmployeeID = employee.EmployeeID;
                currentOrder.StartTime = DateTime.Now;
                currentOrder.TableID = tableNr;
                currentOrder.OrderNr = orderID;
                currentOrder.EndTime = null;

                orderService.AddOrder(currentOrder);
            }
            else
            {
                currentOrder = order;
                nrOfItemsInRunningOrder = currentOrder.orderedItems.Count;
            }

            //lables 
            lblEmployeeName.Text = $"Employee: {employee.Name} ({employee.EmployeeID})";
            lblTableNr.Text = tableNr.ToString();
        }

        private void listViewOrderOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrderOrder.SelectedItems.Count > 0)
            {
                ListViewItem li = listViewOrderOrder.SelectedItems[0];

                Item item = new Item();
                selectedOrderItem = new OrderItem();
                selectedOrderItem.Quantity = int.Parse(li.SubItems[0].Text);
                item.ItemName = li.SubItems[1].Text;

                selectedOrderItem.Item = item;
            }
        }

        //sending order to the database
        private void bttnSend_Click(object sender, EventArgs e)
        {
            //inserting the orderItems to the database
            OrderService orderService = new OrderService();

            for (int i = nrOfItemsInRunningOrder; i < currentOrder.orderedItems.Count; i++)
            {
                orderService.AddOrderItems(currentOrder.orderedItems[i]);
            }

            //open new tableOverview form 
            Form formTableOverview = new TableOverview(employee);

            formTableOverview.StartPosition = FormStartPosition.Manual;
            formTableOverview.Location = this.Location;
            formTableOverview.Size = this.Size;

            Close();
            formTableOverview.Show();
        }

        //buttons for changing the orderItem
        private void bttnAddComment_Click(object sender, EventArgs e)
        {
            //string comment = ""; 

            //for (int i = 0; i <= currentOrder.orderedItems.Count; i++)
            //{
            //    if (currentOrder.orderedItems[i].Item.ItemName == selectedOrderItem.Item.ItemName)
            //    {
            //        currentOrder.orderedItems[i].Comment = comment;
            //    }
            //}
        }

        private void bttnRemoveItem_Click(object sender, EventArgs e)
        {
            for (int i = nrOfItemsInRunningOrder; i < currentOrder.orderedItems.Count; i++)
            {
                if (currentOrder.orderedItems[i].Item.ItemName == selectedOrderItem.Item.ItemName)
                {
                    if (selectedOrderItem.Quantity > 1)
                    {
                        currentOrder.orderedItems[i].Quantity--;
                    }
                    else
                    {
                        currentOrder.orderedItems.Remove(currentOrder.orderedItems[i]);
                    }

                    //add stock back
                    ItemService itemService = new ItemService();
                    Item item = new Item();
                    item = currentOrder.orderedItems[i].Item;

                    item.Stock++;
                    itemService.UpdateStock(item);

                    DisplayOrders();
                }
            }
        }

        private void bttnAddQNT_Click(object sender, EventArgs e)
        {
            for (int i = nrOfItemsInRunningOrder; i < currentOrder.orderedItems.Count; i++)
            {
                if (currentOrder.orderedItems[i].Item.ItemName == selectedOrderItem.Item.ItemName)
                {
                    currentOrder.orderedItems[i].Quantity++;

                    //decrease stock
                    ItemService itemService = new ItemService();
                    Item item = new Item();
                    item = currentOrder.orderedItems[i].Item;

                    item.Stock--;
                    itemService.UpdateStock(item);

                    DisplayOrders();
                }
            }
        }

        //methods 
        private void DisplayOrders()
        {
            listViewOrderOrder.Items.Clear();

            for (int i = nrOfItemsInRunningOrder; i < currentOrder.orderedItems.Count; i++)
            {
                ListViewItem li = new ListViewItem(currentOrder.orderedItems[i].Quantity.ToString());
                li.SubItems.Add(currentOrder.orderedItems[i].Item.ItemName);

                if (currentOrder.orderedItems[i].Comment != "")
                {
                    li.SubItems.Add(currentOrder.orderedItems[i].Comment);
                }

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

        //methods creating buttons         
        private void CreateMenuButtons(List<Item> menuItems)
        {
            foreach (Item item in menuItems)
            {
                Button itemButten = new Button();
                itemButten.Text = item.ItemName;
                itemButten.Size = new Size(92, 92);
                itemButten.Click += new EventHandler(itemButten_Click);
                itemButten.Tag = item;
                itemButten.BackColor = Color.LightGray;

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
                for (int i = nrOfItemsInRunningOrder; i < currentOrder.orderedItems.Count; i++)
                {
                    if (currentOrder.orderedItems[i].Item.ItemName == selectedMenuItem.ItemName)
                    {
                        currentOrder.orderedItems[i].Quantity++;
                        DisplayOrders();
                        return;
                    }
                }

                //create a new orderItem
                OrderItem orderItem = new OrderItem();
                orderItem.Item = selectedMenuItem;
                orderItem.OrderID = currentOrder.OrderNr;
                orderItem.Quantity = 1;
                orderItem.State = State.NotStarted;
                orderItem.OrderTime = DateTime.Now;

                //adding to the list of orderItems
                currentOrder.orderedItems.Add(orderItem);

                //decrease stock
                ItemService itemService = new ItemService();
                Item item = new Item();
                item = selectedMenuItem;

                item.Stock--;
                itemService.UpdateStock(item);

                //display
                DisplayOrders();
            }
        }

        //buttons category 
        private void bttnMenuCategory_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int category = Convert.ToInt32(button.Tag);
            button.Tag = category;

            flowPnlItems.Controls.Clear();

            List<Item> menuItems = new List<Item>();
            menuItems = ListOfMenuItemsByCategory(category);

            CreateMenuButtons(menuItems);
        }

        //buttons Subcategorys
        private void bttnMenuSubCatgory_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int subCategory = Convert.ToInt32(button.Tag);
            button.Tag = subCategory;

            flowPnlItems.Controls.Clear();

            List<Item> menuItems = new List<Item>();
            menuItems = ListOfMenuItemsBySubCategory(subCategory);

            CreateMenuButtons(menuItems);
        }
    }
}
