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

        public void DisplayOrders(string menu)
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

            //Display the orders based on the selected "tab" in the aplication.
            if (menu == "All Active Orders")
            {
                List<Order> activeOrders = orderService.GetAllRunningOrders();

                if (activeOrders.Count > 1)    //If there are more than one orders, the second one is displayed, but if not, the panel for order 2 stays hidden, because it would be an empty pannel
                {
                    DisplayOrder1(activeOrders[0]);
                    DisplayOrder2(activeOrders[1]);
                }
                else if (activeOrders.Count == 1)
                    DisplayOrder1(activeOrders[0]);
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
                    DisplayOrder1(runningOrders[0]);
                    DisplayOrder2(runningOrders[1]);
                }
                if (runningOrders.Count > 0)
                    DisplayOrder1(runningOrders[0]);
                else
                    MessageBox.Show("No running orders at the moment... ");
            }
            else if(menu == "Finished Orders")
            {

            }
        }

        public void DisplayOrder1(Order order)
        {
            pnlOrder1.Show();

            lblOrderID1.Text = $"{order.OrderNr}";
            lblOrderStartTime1.Text = $"{order.StartTime: hh:mm}";
            lblTablenumber1.Text = $"Table {order.TableID}";

            lstbStarters1.Items.Clear();
            lstbMains1.Items.Clear();
            lstbDesserts1.Items.Clear();
            lstbDrinks1.Items.Clear();

            //This value is used to check if the order is being prepared
            bool oneItemPreparing = false;

            foreach (OrderItem orderedItem in order.orderedItems)
            {
                if (orderedItem.Item.SubCategory == SubCategory.Starters || orderedItem.Item.SubCategory == SubCategory.Bites)
                {
                    lstbStarters1.Items.Add($"{orderedItem.Item.ItemName}      X{orderedItem.Quantity}");
                    if (orderedItem.Comment != "")
                        lstbStarters1.Items.Add(orderedItem.Comment);
                    else
                        lstbStarters1.Items.Add("...");
                }
                else if (orderedItem.Item.SubCategory == SubCategory.Mains || orderedItem.Item.SubCategory == SubCategory.LunchMain || orderedItem.Item.SubCategory == SubCategory.Specials)
                {
                    lstbMains1.Items.Add($"{orderedItem.Item.ItemName}      X{orderedItem.Quantity}");
                    if (orderedItem.Comment != "")
                        lstbMains1.Items.Add(orderedItem.Comment);
                    else
                        lstbMains1.Items.Add("...");
                }
                else if (orderedItem.Item.SubCategory == SubCategory.Desserts)
                {
                    lstbDesserts1.Items.Add($"{orderedItem.Item.ItemName}      X{orderedItem.Quantity}");
                    if (orderedItem.Comment != "")
                        lstbDesserts1.Items.Add(orderedItem.Comment);
                    else
                        lstbDesserts1.Items.Add("...");
                }
                else if(orderedItem.Item.Category == Category.Drinks)
                {
                    lstbDrinks1.Items.Add($"{orderedItem.Item.ItemName}      X{orderedItem.Quantity}");
                    if (orderedItem.Comment != "")
                        lstbDrinks1.Items.Add(orderedItem.Comment);
                    else
                        lstbDrinks1.Items.Add("...");
                }

                if(!oneItemPreparing) //If one item is being prepared you do not need to check the rest of the items
                    if(orderedItem.State == (State)2)
                        oneItemPreparing = true;
            }

            if (CheckIfFinished(order))
            {
                pnlOrder1.BackColor = Color.Green;
                btnChangeOrderState.Hide();
            }
            else if (oneItemPreparing)
            {
                pnlOrder1.BackColor = Color.DarkOrange;
                btnChangeOrderState.BackColor = Color.Green;
                btnChangeOrderState.Text = "Ready";
            }
        }

        public void DisplayOrder2(Order order)
        {
            pnlOrder2.Show();

            lblOrderId2.Text = $"{order.OrderNr}";
            lblOrderStartTime2.Text = $"{order.StartTime: hh:mm}";
            lblTableNumber2.Text = $"Table {order.TableID}";

            lstbStarters2.Items.Clear();
            lstbMains2.Items.Clear();
            lstbDesserts2.Items.Clear();
            lstbDrinks2.Items.Clear();

            //This value is used to check if the order is being prepared
            bool oneItemPreparing = false;

            foreach (OrderItem orderedItem in order.orderedItems)
            {
                if (orderedItem.Item.SubCategory == SubCategory.Starters || orderedItem.Item.SubCategory == SubCategory.Bites)
                {
                    lstbStarters2.Items.Add($"{orderedItem.Item.ItemName}      X{orderedItem.Quantity}");
                    if (orderedItem.Comment != "")
                        lstbStarters2.Items.Add(orderedItem.Comment);
                    else
                        lstbStarters2.Items.Add("...");
                }
                else if (orderedItem.Item.SubCategory == SubCategory.Mains || orderedItem.Item.SubCategory == SubCategory.LunchMain || orderedItem.Item.SubCategory == SubCategory.Specials)
                {
                    lstbMains2.Items.Add($"{orderedItem.Item.ItemName}      X{orderedItem.Quantity}");
                    if (orderedItem.Comment != "")
                        lstbMains2.Items.Add(orderedItem.Comment);
                    else
                        lstbMains2.Items.Add("...");
                }
                else if (orderedItem.Item.SubCategory == SubCategory.Desserts)
                {
                    lstbDesserts2.Items.Add($"{orderedItem.Item.ItemName}      X{orderedItem.Quantity}");
                    if (orderedItem.Comment != "")
                        lstbDesserts2.Items.Add(orderedItem.Comment);
                    else
                        lstbDesserts2.Items.Add("...");
                }
                else if (orderedItem.Item.Category == Category.Drinks)
                {
                    lstbDrinks2.Items.Add($"{orderedItem.Item.ItemName}      X{orderedItem.Quantity}");
                    if (orderedItem.Comment != "")
                        lstbDrinks2.Items.Add(orderedItem.Comment);
                    else
                        lstbDrinks2.Items.Add("...");
                }

                if (!oneItemPreparing) //If one item is being prepared you do not need to check the rest of the items
                    if (orderedItem.State == (State)2)
                        oneItemPreparing = true;
            }

            if (CheckIfFinished(order))
            {
                pnlOrder2.BackColor = Color.Green;
                btnChangeOrderState2.Hide();
            }
            else if (oneItemPreparing)
            {
                pnlOrder2.BackColor = Color.DarkOrange;
                btnChangeOrderState2.BackColor = Color.Green;
                btnChangeOrderState2.Text = "Ready";
            }
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
            OrderService orderService = new OrderService();
            OrderItemService orderItemService = new OrderItemService();

            int orderID = int.Parse(lblOrderID1.Text);

            if (btnChangeOrderState.Text == "Prepare")
            {
                Order order = orderService.GetOrderByOrderID(orderID);
                foreach (OrderItem item in order.orderedItems)
                    orderItemService.UpdateOrderState(2, orderID);

                btnChangeOrderState.BackColor = Color.Green;
                btnChangeOrderState.Text = "Ready";
            }
            else if (btnChangeOrderState.Text == "Ready")
            {
                if (lstbStarters1.SelectedItem == null && lstbMains1.SelectedItem == null && lstbDesserts1.SelectedItem == null && lstbDrinks1.SelectedItem == null)
                {
                    string message = "Click OK to change the state of all dishes in this order to ready. Click cancel and select a dish to only mark that dish as ready.";
                    string title = "Mark Order as Ready?";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons);

                    if (result == DialogResult.OK)
                    {
                        Order order = orderService.GetOrderByOrderID(orderID);
                        foreach (OrderItem item in order.orderedItems)
                            orderItemService.UpdateOrderState(3, orderID);
                    }
                }
            }

            DisplayOrders(lblDisplayingThis.Text);
        }

        private void tsmiAllOrders_Click(object sender, EventArgs e)
        {
            DisplayOrders("All Active Orders");
            lblDisplayingThis.Text = "All Active Orders";
        }

        private void tsmiRunningOrders_Click(object sender, EventArgs e)
        {
            DisplayOrders("Running Orders");
            lblDisplayingThis.Text = "Running Orders";
        }

        private void tsmiFinishedOrders_Click(object sender, EventArgs e)
        {
            DisplayOrders("Finished Orders");
            lblDisplayingThis.Text = "Finished Orders";
        }

        //The panels for the orders are hidden so no "Empty Orders" appear on the screen
        private void HideOrders()
        {
            pnlOrder1.Hide();
            pnlOrder2.Hide();
        }

        private void btnUndoOrder1_Click(object sender, EventArgs e)
        {
            
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
    }
}