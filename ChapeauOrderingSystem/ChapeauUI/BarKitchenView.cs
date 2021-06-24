using ChapeauLogic;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class BarKitchenView : Form
    {
        public Employee employee;

        public BarKitchenView(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;

            Refresh("Running Orders");   //Orders are displayed upon logging in
        }

        //This method determines which orders should be displayed and refreshes the display
        private void Refresh(string menu) //The menu string is which menu or page is currently selected
        {
            OrderService orderService = new OrderService();

            ResetBarKitchenDisplay();

            //Display the orders based on the selected "menu" in the aplication.
            if (menu == "All Active Orders")
            {
                List<Order> activeOrders = orderService.GetAllActiveOrders();

                if (activeOrders.Count > 0)
                    DisplayOrders(activeOrders);
                else
                    MessageBox.Show("No active orders at the moment...");
            }
            else if (menu == "Running Orders")
            {
                List<Order> runningOrders = orderService.GetAllRunningOrders();

                if (runningOrders.Count > 0)
                    DisplayOrders(runningOrders);
                else
                    MessageBox.Show("No running orders at the moment... ");
            }
            else if (menu == "Finished Orders")
            {
                DisplayFinishedOrders();
            }
        }

        //Checks how many orders should be displayed and calls the methods to display them
        private void DisplayOrders(List<Order> orders)
        {
            if (orders.Count > 1)    //If there are more than one orders, the second one is displayed, but if not, the panel for order 2 stays hidden, because it would be an empty pannel
            {
                DisplayOrder(orders[0], lblOrderID1, lblOrderStartTime1, lblTablenumber1, lblEmployeeID1, lstbStarters1, lstbMains1, lstbDesserts1, lstbDrinks1, pnlOrder1, btnChangeOrderState);
                DisplayOrder(orders[1], lblOrderId2, lblOrderStartTime2, lblTableNumber2, lblEmployeeID2, lstbStarters2, lstbMains2, lstbDesserts2, lstbDrinks2, pnlOrder2, btnChangeOrderState2);
            }
            else if (orders.Count == 1)
                DisplayOrder(orders[0], lblOrderID1, lblOrderStartTime1, lblTablenumber1, lblEmployeeID1, lstbStarters1, lstbMains1, lstbDesserts1, lstbDrinks1, pnlOrder1, btnChangeOrderState);
        }

        //This method makes sure the order displays have the correct information in them
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

            //Adding each ordered item to the listboxes
            foreach (OrderItem orderedItem in order.orderedItems)
            {
                if (orderedItem.Item.SubCategory == SubCategory.Starters || orderedItem.Item.SubCategory == SubCategory.Bites)
                    AddItem(starters, orderedItem);
                else if (orderedItem.Item.SubCategory == SubCategory.Mains || orderedItem.Item.SubCategory == SubCategory.LunchMain || orderedItem.Item.SubCategory == SubCategory.Specials)
                    AddItem(mains, orderedItem);
                else if (orderedItem.Item.SubCategory == SubCategory.Desserts)
                    AddItem(desserts, orderedItem);
                else if (orderedItem.Item.Category == Category.Drinks)
                    AddItem(drinks, orderedItem);
            }

            ChangeOrderDisplay(order, orderPanel, changeOrderState);
        }

        //Finished orders are displayed in a listview instead of a listbox and requires a sepperate method because of this
        private void DisplayFinishedOrders()
        {
            OrderService orderService = new OrderService();
            List<Order> finishedOrders = orderService.GetFinishedOrders();
            //Clear the listView items
            lstFinishedOrders.Items.Clear();
            pnlFinishedOrders.Show();
            if (finishedOrders != null)
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
                        items += $"[{orderedItem.Item.ItemName} (x{orderedItem.Quantity})] ";

                    li.SubItems.Add(items);

                    lstFinishedOrders.Items.Add(li);
                }
            }
            else
                MessageBox.Show("No finished orders at the moment...");
        }

        //Refresh button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh(lblDisplayingThis.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        //This is the prepare/ ready button for order 1
        private void btnChangeOrderState_Click(object sender, EventArgs e)
        {
            List<ListBox> boxes = new List<ListBox>();
            boxes.Add(lstbStarters1);
            boxes.Add(lstbMains1);
            boxes.Add(lstbDesserts1);
            boxes.Add(lstbDrinks1);

            Button button = (Button)sender;

            int orderID = int.Parse(lblOrderID1.Text);
            ChangeOrderState(button.Text, orderID, boxes);
        }

        //The different menu options for the bar/kitchen view, all active- runnung- and finished orders
        private void tsmiAllOrders_Click(object sender, EventArgs e)
        {
            lblDisplayingThis.Text = "All Active Orders";
            Refresh("All Active Orders");
        }
        private void tsmiRunningOrders_Click(object sender, EventArgs e)
        {
            lblDisplayingThis.Text = "Running Orders";
            Refresh("Running Orders");
        }
        private void tsmiFinishedOrders_Click(object sender, EventArgs e)
        {
            lblDisplayingThis.Text = "Finished Orders";
            Refresh("Finished Orders");
        }

        //Resets all panels and buttons to their 'default' state
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

        //Changes the prepare/ ready button to its 'default'state
        private void ResetButton(Button btn)
        {
            btn.Text = "Prepare";
            btn.BackColor = Color.DarkOrange;
            btn.Show();
        }

        //The undo button for order 1
        private void btnUndoOrder1_Click(object sender, EventArgs e)
        {
            List<ListBox> boxes = new List<ListBox>();
            boxes.Add(lstbStarters1);
            boxes.Add(lstbMains1);
            boxes.Add(lstbDesserts1);
            boxes.Add(lstbDrinks1);

            Button button = (Button)sender;

            UndoChangeToState(boxes, int.Parse(lblOrderID1.Text), button.Text);
        }

        //The prepare/ ready button for order 2
        private void btnChangeOrderState2_Click(object sender, EventArgs e)
        {
            List<ListBox> boxes = new List<ListBox>();
            boxes.Add(lstbStarters2);
            boxes.Add(lstbMains2);
            boxes.Add(lstbDesserts2);
            boxes.Add(lstbDrinks2);

            Button button = (Button)sender;

            int orderID = int.Parse(lblOrderId2.Text);
            ChangeOrderState(button.Text, orderID, boxes);
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

        //Checks if at least one item is being prepared
        private bool CheckIfOnePreparing(Order order)
        {
            foreach (OrderItem orderedItem in order.orderedItems)
            {
                if ((int)orderedItem.State == 2 || (int)orderedItem.State == 3)
                    return true;
            }

            return false;
        }

        //Undo button for order 2
        private void btnUndoOrder2_Click(object sender, EventArgs e)
        {
            List<ListBox> boxes = new List<ListBox>();
            boxes.Add(lstbStarters2);
            boxes.Add(lstbMains2);
            boxes.Add(lstbDesserts2);
            boxes.Add(lstbDrinks2);

            Button button = (Button)sender;

            UndoChangeToState(boxes, int.Parse(lblOrderId2.Text), button.Text);
        }

        //The method that changes the state of the order. Depending on which of the two 
        //buttons is clicked, it receives the listboxes from order 1 or 2 as objects to use 
        //and change their contents in the database
        private void ChangeOrderState(string buttonName, int orderID, List<ListBox> boxes)
        {
            //Depending on the state of the dishes in the order, the button changes text and
            //appearance.
            if (buttonName == "Prepare" && boxes[0].SelectedIndex == -1 && boxes[1].SelectedIndex == -1 && boxes[2].SelectedIndex == -1 && boxes[3].SelectedIndex == -1)   
                UpdateAllItemStates(orderID, State.Preparing);
            else if(buttonName == "Prepare")
                UpdateSelectedItemStates(orderID, boxes, buttonName);
            else if ((buttonName == "Prepare/ Ready" || buttonName == "Ready") && boxes[0].SelectedIndex == -1 && boxes[1].SelectedIndex == -1 && boxes[2].SelectedIndex == -1 && boxes[3].SelectedIndex == -1)
                UpdateAllItemStates(orderID, State.Done);
            else if(buttonName == "Prepare/ Ready" || buttonName == "Ready")
                UpdateSelectedItemStates(orderID, boxes, buttonName);

            Refresh(lblDisplayingThis.Text);
        }

        //This method adds the ordereditems to the correct listbox
        private void AddItem(ListBox listbox, OrderItem orderedItem)
        {
            listbox.Items.Add($"{orderedItem.Item.ItemID}-{orderedItem.Item.ItemName}-{orderedItem.State}- x{orderedItem.Quantity}");

            if (orderedItem.Comment != "")
                listbox.Items.Add(orderedItem.Comment);
            else
                listbox.Items.Add("...");
        }

        //Used to change the state of a selected order item to one state lower (or all items if none are selected)
        private void UndoChangeToState(List<ListBox> boxes, int orderID, string buttonName)
        {
            //If no dishes have been selected, the user can change the state of all dishes at once
            if (boxes[0].SelectedIndex == -1 && boxes[1].SelectedIndex == -1 && boxes[2].SelectedIndex == -1 && boxes[3].SelectedIndex == -1)
                MessageBox.Show("Please select an item to undo");
            else
                UpdateSelectedItemStates(orderID, boxes, buttonName);

            Refresh(lblDisplayingThis.Text);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            this.Hide();
        }

        //Based on the state of the ordered items, the panel and button for the order will change
        private void ChangeOrderDisplay(Order order, Panel orderPanel, Button changeOrderState)
        {
            if (CheckIfFinished(order))
            {
                orderPanel.BackColor = Color.Green;
                changeOrderState.Hide();
            }
            else if (CheckIfAllPreparing(order))
            {
                orderPanel.BackColor = Color.DarkOrange;
                changeOrderState.BackColor = Color.Green;
                changeOrderState.Text = "Ready";
            }
            else if (CheckIfOnePreparing(order))
            {
                orderPanel.BackColor = Color.DarkOrange;
                changeOrderState.BackColor = Color.DarkOrange;
                changeOrderState.Text = "Prepare/ Ready";
            }
        }

        //Changes the state of all items of a specified order to the value passed to it. Used by both the Update- and UndoOrderState methods
        private void UpdateAllItemStates(int orderID, State itemState)
        {
            string message = "Click OK to change the state of all dishes in this order. Click cancel and select a dish to only mark that dish as ready.";
            string title = "Change state of all dishes?";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.OK)
            {
                OrderService orderService = new OrderService();
                OrderItemService orderItemService = new OrderItemService();
                Order order = orderService.GetOrderByOrderID(orderID);

                if (order != null)
                    orderItemService.UpdateOrderState(itemState, orderID);
                else
                    MessageBox.Show("The order could not be found in the database, it may have been removed. Please refresh the page and notify someone about this issue.", "Error, order not found");
            }
        }

        //Loops through the selected order items in the listboxes passed to it and calls the method to update their state
        private void UpdateSelectedItemStates(int orderID, List<ListBox> boxes, string buttonName)
        {
            OrderItemService orderItemService = new OrderItemService();

            foreach (ListBox listBox in boxes)
            {
                for (int i = 0; i < listBox.SelectedItems.Count; i++)   //Check all selected items for every listbox
                {
                    string selectedItem = listBox.SelectedItems[i].ToString();
                    string[] currentItem = selectedItem.Split('-');
                    //currentItem now contains the items name ([1]), ID ([0]) and state ([2]).

                    State currentItemState = ConvertToState(currentItem[2]);
                    
                    UpdateState(orderID, currentItem[1], currentItem[0], currentItemState, buttonName, orderItemService);
                }
            }
        }


        private void UpdateState(int orderID, string itemName, string itemID, State itemState, string buttonName, OrderItemService orderItemService)
        {
            //If called by the change method, changes the states of the selected items to one higher from its current state.
            if (buttonName == "Prepare" || buttonName == "Prepare/ Ready" || buttonName == "Ready")
            {
                if (itemState== State.NotStarted)
                    orderItemService.UpdateOrderState(int.Parse(itemID), State.Preparing, orderID);
                else if (itemState == State.Preparing)
                    orderItemService.UpdateOrderState(int.Parse(itemID), State.Done, orderID);
                else
                    MessageBox.Show($"You cannot change the state of this item: {itemName}");
            }
            //If called by the undo method, one lower.
            else
            {
                if (itemState == State.Preparing)
                    orderItemService.UpdateOrderState(int.Parse(itemID), State.NotStarted, orderID);
                else if (itemState == State.Done)
                    orderItemService.UpdateOrderState(int.Parse(itemID), State.Preparing, orderID);
                else
                    MessageBox.Show($"You cannot change the state of this item: {itemName}");
            }
        }

        //Converts the te given string to an object of the State class
        private State ConvertToState(string itemState)
        {
            switch (itemState)
            {
                case "NotStarted":
                    return State.NotStarted;
                case "Preparing":
                    return State.Preparing;
                case "Done":
                    return State.Done;
            }

            return State.Served;
        }
    }
}