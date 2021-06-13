using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;
using ChapeauUI;

namespace ChapeauUI
{
    public partial class BarKitchenView : Form
    {
        public Employee employee;


        public BarKitchenView(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;

            DisplayOrders("All Active Orders");
        }

        //This method checks determines which orders should be displayed
        public void DisplayOrders(string menu) //The menu string is which menu or page is currently selected
        {
            OrderService orderService = new OrderService();

            HideOrders();

            //Resetting the displays of the prepare and ready button. 
            //This is necessary because they are the same button and change 
            //while using the application.
            btnChangeOrderState.Text = "Prepare";
            btnChangeOrderState.BackColor = Color.DarkOrange;
            btnChangeOrderState.Show();

            btnChangeOrderState2.Text = "Prepare";
            btnChangeOrderState2.BackColor = Color.DarkOrange;
            btnChangeOrderState2.Show();

            //Same thing for the pannels containing the orders.
            pnlOrder1.BackColor = Color.DarkGray;
            pnlOrder2.BackColor = Color.DarkGray;

            //Display the orders based on the selected "menu" in the aplication.
            if (menu == "All Active Orders")
            {
                List<Order> activeOrders = orderService.GetAllRunningOrders();

                if (activeOrders.Count > 1)    //If there are more than one orders, the second one is displayed, but if not, the panel for order 2 stays hidden, because it would be an empty pannel
                {
                    DisplayOrder(activeOrders[0], lblOrderID1, lblOrderStartTime1, lblTablenumber1, lstbStarters1, lstbMains1, lstbDesserts1, lstbDrinks1, pnlOrder1, btnChangeOrderState);
                    DisplayOrder(activeOrders[1], lblOrderId2, lblOrderStartTime2, lblTableNumber2, lstbStarters2, lstbMains2, lstbDesserts2, lstbDrinks2, pnlOrder2, btnChangeOrderState2);
                }
                else if (activeOrders.Count == 1)
                    DisplayOrder(activeOrders[0], lblOrderID1, lblOrderStartTime1, lblTablenumber1, lstbStarters1, lstbMains1, lstbDesserts1, lstbDrinks1, pnlOrder1, btnChangeOrderState);
                else
                    MessageBox.Show("No active orders at the moment...");
            }
            else if (menu == "Running Orders")
            {
                List<Order> orders = orderService.GetAllRunningOrders();
                List<Order> runningOrders = new List<Order>();

                foreach (Order order in orders)
                {
                    if (!CheckIfFinished(order))
                        runningOrders.Add(order);
                }

                if(runningOrders.Count > 1)
                {
                    DisplayOrder(runningOrders[0], lblOrderID1, lblOrderStartTime1, lblTablenumber1, lstbStarters1, lstbMains1, lstbDesserts1, lstbDrinks1, pnlOrder1, btnChangeOrderState);
                    DisplayOrder(runningOrders[1], lblOrderId2, lblOrderStartTime2, lblTableNumber2, lstbStarters2, lstbMains2, lstbDesserts2, lstbDrinks2, pnlOrder2, btnChangeOrderState2);
                }
                if (runningOrders.Count > 0)
                    DisplayOrder(runningOrders[0], lblOrderID1, lblOrderStartTime1, lblTablenumber1, lstbStarters1, lstbMains1, lstbDesserts1, lstbDrinks1, pnlOrder1, btnChangeOrderState);
                else
                    MessageBox.Show("No running orders at the moment... ");
            }
            else if(menu == "Finished Orders")
            {
                DisplayFinishedOrders();
            }
        }

        //This one makes sure the order displays have the correct information on display
        public void DisplayOrder(Order order, Label orderID, Label startTime, Label tableNumber, ListBox starters, ListBox mains, ListBox desserts, ListBox drinks, Panel orderPanel, Button changeOrderState)
        {
            orderPanel.Show();

            //Make the labels on the order displays show the right information
            orderID.Text = $"{order.OrderNr}";
            startTime.Text = $"{order.StartTime: hh:mm}";
            tableNumber.Text = $"Table {order.TableID}";

            //Clear out the listbox items
            starters.Items.Clear();
            mains.Items.Clear();
            desserts.Items.Clear();
            drinks.Items.Clear();

            //This value is used to check if the order is being prepared
            bool oneItemPreparing = false;

            //Adding each ordered item to the listviews 
            foreach (OrderItem orderedItem in order.orderedItems)
            {
                if (orderedItem.Item.SubCategory == SubCategory.Starters || orderedItem.Item.SubCategory == SubCategory.Bites)
                {
                    AddItem(starters, orderedItem);
                }
                else if (orderedItem.Item.SubCategory == SubCategory.Mains || orderedItem.Item.SubCategory == SubCategory.LunchMain || orderedItem.Item.SubCategory == SubCategory.Specials)
                {
                    AddItem(mains, orderedItem);
                }
                else if (orderedItem.Item.SubCategory == SubCategory.Desserts)
                {
                    AddItem(desserts, orderedItem);
                }
                else if (orderedItem.Item.Category == Category.Drinks)
                {
                    AddItem(drinks, orderedItem);
                }

                if (!oneItemPreparing) //If one item is being prepared you do not need to check the rest of the items
                    if(orderedItem.State == (State)2)
                        oneItemPreparing = true;
            }

            if (CheckIfFinished(order))
            {
                orderPanel.BackColor = Color.Green;
                changeOrderState.Hide();
            }
            else if (oneItemPreparing)
            {
                orderPanel.BackColor = Color.DarkOrange;
                changeOrderState.BackColor = Color.Green;
                changeOrderState.Text = "Ready";
            }
        }

        //-----------------------------------------------------------------------------------------------mark item as served----------------------------------------------------------------------------------------------------------------------------

        public void DisplayFinishedOrders()
        {
            OrderService orderService = new OrderService();

            List<Order> allOrders = orderService.GetAllOrders();
            List<Order> finishedOrders = new List<Order>();

            //Clear the listView items
            lstFinishedOrders.Items.Clear();

            pnlFinishedOrders.Show();
            if (finishedOrders.Count > 0)
            {
                foreach (Order order in finishedOrders)
                {
                    //Add all the orders to the list
                    ListViewItem li = new ListViewItem(order.OrderNr.ToString());
                    li.SubItems.Add(order.TableID.ToString());
                    li.SubItems.Add(order.StartTime.ToString());
                    li.SubItems.Add(order.EndTime.ToString());
                    li.SubItems.Add(order.EmployeeID.ToString());

                    string items = "";

                    foreach (OrderItem orderedItem in order.orderedItems)
                    {
                        items += $"[{orderedItem.Item.ItemName} (x{orderedItem.Quantity})] ";
                    }

                    li.SubItems.Add(items);
                }
            }
            else
                MessageBox.Show("No finished orders at the moment...");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayOrders(lblDisplayingThis.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnChangeOrderState_Click(object sender, EventArgs e)
        {
            int orderID = int.Parse(lblOrderID1.Text);
            ChangeOrderState((Button)sender, orderID, lstbStarters1, lstbMains1, lstbDesserts1, lstbDrinks1);
        }

        private void tsmiAllOrders_Click(object sender, EventArgs e)
        {
            lblDisplayingThis.Text = "All Active Orders";
            DisplayOrders("All Active Orders");
        }

        private void tsmiRunningOrders_Click(object sender, EventArgs e)
        {
            lblDisplayingThis.Text = "Running Orders";
            DisplayOrders("Running Orders");
        }

        private void tsmiFinishedOrders_Click(object sender, EventArgs e)
        {
            lblDisplayingThis.Text = "Finished Orders";
            DisplayOrders("Finished Orders");
        }

        //The panels for the orders are hidden so no "Empty Orders" appear on the screen
        private void HideOrders()
        {
            pnlOrder1.Hide();
            pnlOrder2.Hide();
            pnlFinishedOrders.Hide();
        }

        private void btnUndoOrder1_Click(object sender, EventArgs e)
        {
            UndoChangeToState(lstbStarters1, lstbMains1, lstbDesserts1, lstbDrinks1, int.Parse(lblOrderID1.Text));
        }
        private void btnChangeOrderState2_Click(object sender, EventArgs e)
        {
            int orderID = int.Parse(lblOrderId2.Text);
            ChangeOrderState((Button)sender, orderID, lstbStarters2, lstbMains2, lstbDesserts2, lstbDrinks2);
        }
        //This method checks all the dishes in the order passed to it to see
        //if the whole order is ready. If it is not, it returns false, otherwise true
        public bool CheckIfFinished(Order order)
        {
            foreach (OrderItem orderedItem in order.orderedItems)
            {
                if (orderedItem.State != (State)3 && orderedItem.State != (State)4) //If one dish is not ready, the order is not finished
                    return false;
            }

            return true; //If all dishes have the ready or served state, the order is Done
        }

        private void btnUndoOrder2_Click(object sender, EventArgs e)
        {
            UndoChangeToState(lstbStarters2, lstbMains2, lstbDesserts2, lstbDrinks2, int.Parse(lblOrderId2.Text));
        }

        

        //This method was created to avoid duplicate code in the ChangeOrderState method
        private void UpdateListBoxContent(ListBox listBox, int orderID)
        {
            ItemService itemService = new ItemService();
            OrderItemService orderItemService = new OrderItemService();

            for (int i = 0; i < listBox.SelectedItems.Count; i++)
            {
                string selectedItem = listBox.SelectedItems[i].ToString();
                string[] itemName = selectedItem.Split('-');
                Item item = itemService.GetItemByName(itemName[0]);

                if (item != null)
                    orderItemService.UpdateOrderState(item.ItemID, 3, orderID);
                else
                    MessageBox.Show("One or more selected items could not be found in the database, did you perhaps select the wrong item?", "Error, Item not found");
            }
        }

        //The method that changes the state of the order. Depending on which of the two 
        //buttons is clicked, it receives the listboxes from order 1 or 2 as objects to use 
        //and change their contents
        private void ChangeOrderState(Button button, int orderID, ListBox starters, ListBox mains, ListBox desserts, ListBox drinks)
        {
            OrderService orderService = new OrderService();
            OrderItemService orderItemService = new OrderItemService();

            //Depending on the state of the dishes in the order, the button changes text and
            //appearance.
            if (button.Text == "Prepare")  //Clicking on the prepare button changes the state
            {                              //of all dishes to "being prepared"
                Order order = orderService.GetOrderByOrderID(orderID);
                if (order != null)
                {
                    foreach (OrderItem item in order.orderedItems)
                        orderItemService.UpdateOrderState(2, orderID);

                    button.BackColor = Color.Green;     //The button is changed from a 
                    button.Text = "Ready";              //'prepare' button to a ready button
                }
                else
                    MessageBox.Show("The order could not be found in the database, it may have been removed. Please refresh the page and notify someone about this issue.", "Error, order not found");
            }
            else if (button.Text == "Ready")
            {
                //If no dishes have been selected, the user can change the state of all dishes at once
                if (starters.SelectedItems.Count == 0 && mains.SelectedItems.Count == 0 && desserts.SelectedItems.Count == 0 && drinks.SelectedItems.Count == 0)
                {
                    string message = "Click OK to change the state of all dishes in this order to ready. Click cancel and select a dish to only mark that dish as ready.";
                    string title = "Mark Order as Ready?";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons);

                    if (result == DialogResult.OK)
                    {
                        Order order = orderService.GetOrderByOrderID(orderID);
                        if (order != null)
                        {
                            foreach (OrderItem item in order.orderedItems)
                                orderItemService.UpdateOrderState(3, orderID);
                                //Update to orderstate 3 because it equals the 'done' state
                        }   
                    }
                    else
                        MessageBox.Show("The order could not be found in the database, it may have been removed. Please refresh the page and notify someone about this issue.", "Error, order not found");
                }
                else
                {
                    string message = "Are you sure you want to mark these items as ready?";
                    string title = "Mark Items as Ready?";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);

                    if (result == DialogResult.Yes)
                    {
                        UpdateListBoxContent(starters, orderID);
                        UpdateListBoxContent(mains, orderID);
                        UpdateListBoxContent(desserts, orderID);
                        UpdateListBoxContent(drinks, orderID);
                    }
                }
            }

            DisplayOrders(lblDisplayingThis.Text);
        }

        //This method adds the ordereditems to the correct listbox
        private void AddItem(ListBox listbox, OrderItem orderedItem)
        {
            listbox.Items.Add($"{orderedItem.Item.ItemName}-{orderedItem.State}- x{orderedItem.Quantity}");
            if (orderedItem.Comment != "")
                listbox.Items.Add(orderedItem.Comment);
            else
                listbox.Items.Add("...");
        }


        private void UndoChangeToState(ListBox starters, ListBox mains, ListBox desserts, ListBox drinks, int orderID)
        {
            OrderItemService orderItemService = new OrderItemService();
            OrderService orderService = new OrderService();
            ItemService itemService = new ItemService();

            List<ListBox> boxes = new List<ListBox>();
            boxes.Add(starters);
            boxes.Add(mains);
            boxes.Add(desserts);
            boxes.Add(drinks);
            List<string> selectedOrderItems = CreateOrderedItemsList(boxes);

            if(selectedOrderItems.Count == 0)
            {
                string message = "Click OK to undo changes to the state of all dishes in this ordery. Click cancel and select a dish to only undo the changes to that dish.";
                string title = "Undo entire order?";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.OK)
                {
                    Order order = orderService.GetOrderByOrderID(orderID);
                    foreach(OrderItem orderedItem in order.orderedItems)
                        orderItemService.UpdateOrderState(orderedItem.Item.ItemID, ((int)orderedItem.State - 1), orderID);
                }
            }
            else
            {
                string message = "Undo changes to the selected items? ";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, "", buttons);

                if (result == DialogResult.Yes)
                {
                    foreach(string selectedItem in selectedOrderItems)
                    {
                        string[] tempString = selectedItem.Split('-');
                        Item item = itemService.GetItemByName(tempString[0]);

                        if (item != null)
                        {
                            OrderItem selectedOrderItem = orderItemService.GetOrderItem(tempString[0], orderID);

                            orderItemService.UpdateOrderState(item.ItemID, ((int)selectedOrderItem.State - 1), orderID);
                        }
                        else
                            MessageBox.Show("The item could not be found in the database, it may have been removed. Please refresh the page and notify someone about this issue.", "Error, item not found");
                    }
                }
            }
        }

        private List<string> CreateOrderedItemsList(List<ListBox> boxes)
        {
            List<string> selectedOrderItems = new List<string>();

            foreach(ListBox box in boxes)
            {
                for (int i = 0; i < box.SelectedItems.Count; i++)
                    selectedOrderItems.Add(box.SelectedItems[i].ToString());
            }
            
            return selectedOrderItems;
        }
    }
}