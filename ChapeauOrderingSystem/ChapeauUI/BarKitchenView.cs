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

        //This method determines which orders should be displayed
        private void DisplayOrders(string menu) //The menu string is which menu or page is currently selected
        {
            OrderService orderService = new OrderService();

            ResetBarKitchenDisplay();

            //Display the orders based on the selected "menu" in the aplication.
            if (menu == "All Active Orders")
            {
                List<Order> activeOrders = orderService.GetAllRunningOrders();

                if (activeOrders.Count > 1)    //If there are more than one orders, the second one is displayed, but if not, the panel for order 2 stays hidden, because it would be an empty pannel
                {
                    DisplayOrder(activeOrders[0], lblOrderID1, lblOrderStartTime1, lblTablenumber1, lblEmployeeID1, lstbStarters1, lstbMains1, lstbDesserts1, lstbDrinks1, pnlOrder1, btnChangeOrderState);
                    DisplayOrder(activeOrders[1], lblOrderId2, lblOrderStartTime2, lblTableNumber2, lblEmployeeID2, lstbStarters2, lstbMains2, lstbDesserts2, lstbDrinks2, pnlOrder2, btnChangeOrderState2);
                }
                else if (activeOrders.Count == 1)
                    DisplayOrder(activeOrders[0], lblOrderID1, lblOrderStartTime1, lblTablenumber1, lblEmployeeID1, lstbStarters1, lstbMains1, lstbDesserts1, lstbDrinks1, pnlOrder1, btnChangeOrderState);
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
                    DisplayOrder(runningOrders[0], lblOrderID1, lblOrderStartTime1, lblTablenumber1, lblEmployeeID1, lstbStarters1, lstbMains1, lstbDesserts1, lstbDrinks1, pnlOrder1, btnChangeOrderState);
                    DisplayOrder(runningOrders[1], lblOrderId2, lblOrderStartTime2, lblTableNumber2, lblEmployeeID2, lstbStarters2, lstbMains2, lstbDesserts2, lstbDrinks2, pnlOrder2, btnChangeOrderState2);
                }
                if (runningOrders.Count > 0)
                    DisplayOrder(runningOrders[0], lblOrderID1, lblOrderStartTime1, lblTablenumber1, lblEmployeeID1, lstbStarters1, lstbMains1, lstbDesserts1, lstbDrinks1, pnlOrder1, btnChangeOrderState);
                else
                    MessageBox.Show("No running orders at the moment... ");
            }
            else if(menu == "Finished Orders")
            {
                DisplayFinishedOrders();
            }
        }

        //This one makes sure the order displays have the correct information on display
        private void DisplayOrder(Order order, Label orderID, Label startTime, Label tableNumber, Label employeeID, ListBox starters, ListBox mains, ListBox desserts, ListBox drinks, Panel orderPanel, Button changeOrderState)
        {
            orderPanel.Show();

            //Make the labels on the order displays show the right information
            orderID.Text = $"{order.OrderNr}";
            startTime.Text = $"{order.StartTime: hh:mm}";
            tableNumber.Text = $"Table {order.TableID}";
            employeeID.Text = $"EmployeeID: {order.EmployeeID}";
            

            //Clear out the listbox items
            starters.Items.Clear();
            mains.Items.Clear();
            desserts.Items.Clear();
            drinks.Items.Clear();

            //This value is used to check if only a part of the order is being prepared
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

                if (!oneItemPreparing) //If one item is being prepared you do not need to check the rest of the items for bool oneItemPreparing
                {
                    if ((int)orderedItem.State == 2 || (int)orderedItem.State == 3)
                    {
                        oneItemPreparing = true;
                    }  
                }
            }

            if (CheckIfFinished(order))
            {
                orderPanel.BackColor = Color.Green;
                changeOrderState.Hide();
            }
            else if(CheckIfAllPreparing(order))
            {
                orderPanel.BackColor = Color.DarkOrange;
                changeOrderState.BackColor = Color.Green;
                changeOrderState.Text = "Ready";
            }
            else if (oneItemPreparing)
            {
                orderPanel.BackColor = Color.DarkOrange;
                changeOrderState.BackColor = Color.DarkOrange;
                changeOrderState.Text = "Prepare/ Ready";
            }
        }

        //-----------------------------------------------------------------------------------------------mark item as served----------------------------------------------------------------------------------------------------------------------------

        private void DisplayFinishedOrders()
        {
            OrderService orderService = new OrderService();

            List<Order> allOrders = orderService.GetAllOrders();
            List<Order> finishedOrders = new List<Order>();

            foreach(Order order in allOrders)
            {
                string orderEndTime = $"{order.EndTime: dd/MM/yyyy}";
                string today = $"{DateTime.Today: dd/MM/yyyy}";
                if (CheckIfFinished(order) && orderEndTime == today)
                    finishedOrders.Add(order);
            }

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

                    lstFinishedOrders.Items.Add(li);
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

        private void ResetBarKitchenDisplay()
        {
            //The panels for the orders are hidden so no "Empty Orders" appear on the screen
            pnlOrder1.Hide();
            pnlOrder2.Hide();
            pnlFinishedOrders.Hide();

            //Resetting the displays of the prepare and ready button. 
            //This is necessary because they are the same button and change 
            //while using the application.
            ResetButton(btnChangeOrderState);
            ResetButton(btnChangeOrderState2);

            //Same thing for the pannels containing the orders.
            pnlOrder1.BackColor = Color.DarkGray;
            pnlOrder2.BackColor = Color.DarkGray;
        }

        private void ResetButton(Button btn)
        {
            btn.Text = "Prepare";
            btn.BackColor = Color.DarkOrange;
            btn.Show();
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
        private bool CheckIfFinished(Order order)
        {
            foreach (OrderItem orderedItem in order.orderedItems)
            {
                if (orderedItem.State != State.Done && orderedItem.State != State.Served) //If one dish is not ready, the order is not finished
                    return false;
            }

            return true; //If all dishes have the ready or served state, the order is Done
        }

        //Checks if all the dishes in the order are being prepared or have already been prepared, similair to CheckIfFinished()
        private bool CheckIfAllPreparing(Order order)
        {
            foreach (OrderItem orderedItem in order.orderedItems)
            {
                if (orderedItem.State == (State)1)  //If an item is done or served the color of the panel shoud be orange, so only not started dishes cause a false to be returned 
                    return false;
            }

            return true;
        }

        private void btnUndoOrder2_Click(object sender, EventArgs e)
        {
            UndoChangeToState(lstbStarters2, lstbMains2, lstbDesserts2, lstbDrinks2, int.Parse(lblOrderId2.Text));
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
            {                              //of all dishes
                                           //If no dishes have been selected, the user can change the state of all dishes at once
                if (starters.SelectedItems.Count == 0 && mains.SelectedItems.Count == 0 && desserts.SelectedItems.Count == 0 && drinks.SelectedItems.Count == 0)
                {
                    string message = "Click OK to change the state of all dishes in this order. Click cancel and select a dish to only mark that dish as ready.";
                    string title = "Change state of all dishes?";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons);

                    if(result == DialogResult.OK)
                    {
                        Order order = orderService.GetOrderByOrderID(orderID);

                        if (order != null)
                        {
                            foreach (OrderItem item in order.orderedItems)
                                orderItemService.UpdateOrderState(2, orderID);

                            MessageBox.Show("The state of the dish(es) has been updated");
                        }  
                        else
                            MessageBox.Show("The order could not be found in the database, it may have been removed. Please refresh the page and notify someone about this issue.", "Error, order not found");
                    }
                }
                else
                {
                    string message = "Are you sure you want to change the state of these dishes?";
                    string title = "Change state of selected dishes?";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);

                    if (result == DialogResult.Yes)
                    {
                        //Passing the listboxes to the method in a list makes the method require less duplicate code
                        List<ListBox> boxes = new List<ListBox>();
                        boxes.Add(starters);
                        boxes.Add(mains);
                        boxes.Add(desserts);
                        boxes.Add(drinks);

                        UpdateListBoxContent(boxes, orderID);

                        MessageBox.Show("The state of the dish(es) has been updated");
                    }
                }
            }
            else if (button.Text == "Prepare/ Ready" || button.Text == "Ready")
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
                            
                            MessageBox.Show("The state of the dish(es) has been updated");
                        }
                        else
                            MessageBox.Show("The order could not be found in the database, it may have been removed. Please refresh the page and notify someone about this issue.", "Error, order not found");
                    }
                }
                else
                {
                    string message = "Are you sure you want to change the state of these items?";
                    string title = "Change state of selected dishes?";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);

                    if (result == DialogResult.Yes)
                    {
                        //Passing the listboxes to the method in a list makes the method require less duplicate code
                        List<ListBox> boxes = new List<ListBox>();
                        boxes.Add(starters);
                        boxes.Add(mains);
                        boxes.Add(desserts);
                        boxes.Add(drinks);

                        UpdateListBoxContent(boxes, orderID);

                        MessageBox.Show("The state of the dish(es) has been updated");
                    }
                }
            }

            DisplayOrders(lblDisplayingThis.Text);
        }

        //This method was created to avoid duplicate code in the ChangeOrderState method
        //It changes the state of the selected items in the listboxes passed onto it to 
        //the given state
        private void UpdateListBoxContent(List<ListBox> boxes, int orderID)
        {
            ItemService itemService = new ItemService();
            OrderItemService orderItemService = new OrderItemService();
            OrderService orderService = new OrderService();
            Order order = orderService.GetOrderByOrderID(orderID);

            foreach (ListBox listBox in boxes)
            {
                for (int i = 0; i < listBox.SelectedItems.Count; i++)
                {
                    string selectedItem = listBox.SelectedItems[i].ToString();
                    string[] itemName = selectedItem.Split('-');
                    Item item = itemService.GetItemByName(itemName[0]);

                    int orderState = 0;

                    foreach (OrderItem orderedItem in order.orderedItems)
                    {
                        if (orderedItem.Item.ItemName == itemName[0])
                        {
                            if(orderedItem.State != State.Done)
                                orderState = (int)orderedItem.State + 1;
                            else
                            {
                                MessageBox.Show($"Cannot change the state of this dish: {orderedItem.Item.ItemName}");
                            }    
                        }
                            
                    }

                    if (item != null)
                        orderItemService.UpdateOrderState(item.ItemID, orderState, orderID);
                    else
                        MessageBox.Show("One or more selected items could not be found in the database, did you perhaps select the wrong item?", "Error, Item not found");
                }
            }
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

            //Passing the listboxes to the method in a list makes the method require less duplicate code
            List<ListBox> boxes = new List<ListBox>();
            boxes.Add(starters);
            boxes.Add(mains);
            boxes.Add(desserts);
            boxes.Add(drinks);
            List<string> selectedOrderItems = CreateOrderedItemsList(boxes);

            //If no dishes have been selected, the user can change the state of all dishes at once
            if (selectedOrderItems.Count == 0)
            {
                string message = "Click OK to undo changes to the state of all dishes in this ordery. Click cancel and select a dish to only undo the changes to that dish.";
                string title = "Undo entire order?";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.OK)
                {
                    Order order = orderService.GetOrderByOrderID(orderID);

                    foreach (OrderItem orderedItem in order.orderedItems)
                    {
                        if ((int)orderedItem.State == 2 || (int)orderedItem.State == 3)      //Only states 2 and 3 can be changed because a 'Not started' or 'Served' order can not be undone
                            orderItemService.UpdateOrderState(orderedItem.Item.ItemID, ((int)orderedItem.State - 1), orderID);
                        else
                            MessageBox.Show($"Cannot change the state of this dish: {orderedItem.Item.ItemName}");
                    }      
                    MessageBox.Show("The state of the dish(es) has been updated");
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
                            if (tempString[1] == "Done")
                                orderItemService.UpdateOrderState(item.ItemID, 2, orderID);
                            else if (tempString[1] == "Preparing")
                                orderItemService.UpdateOrderState(item.ItemID, 1, orderID);
                            else
                            {
                                MessageBox.Show($"Cannot change the state of this dish: {item.ItemName}");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("One or more items could not be found in the database, perhaps you selected the wrong item?.", "Error, item not found");
                            return;
                        }
                    }

                    MessageBox.Show("The state of the dish(es) has been updated");
                }
            }

            DisplayOrders(lblDisplayingThis.Text);
        }

        //This method takes the items from all the listbox in the List and adds them to a list 
        //of strings
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            this.Hide();
        }
    }
}