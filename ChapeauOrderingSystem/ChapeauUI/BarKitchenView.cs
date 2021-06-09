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
        private OrderService orderService;

        public BarKitchenView(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;

            orderService = new OrderService();
            DisplayOrders("All Active Orders");
        }

        public void DisplayOrders(string menu)
        {
            HideOrders();
            List<Order> allOrders = orderService.GetAllOrders();

            if (menu == "All Active Orders")
            {
                if (allOrders[0] != null)
                {
                    Order order1 = allOrders[0];
                    DisplayOrder(order1);
                }
            }
            else if (menu == "Running Orders")
            {

            }
            else if(menu == "Finished Orders")
            {

            }
        }

        public void DisplayOrder(Order order)
        {
            pnlOrder1.Show();

            lblOrderID1.Text = $"{order.OrderNr}";
            lblOrderStartTime1.Text = $"{order.StartTime: hh:mm}";
            lblTablenumber1.Text = $"Table {order.TableID}";

            lstbStarters1.Items.Clear();
            lstbMains1.Items.Clear();
            lstbDesserts1.Items.Clear();

            foreach (OrderItem orderedItem in order.orderedItems)
            {
                if (orderedItem.Item.SubCategory == SubCategory.Starters || orderedItem.Item.SubCategory == SubCategory.Bites)
                {
                    lstbStarters1.Items.Add($"{orderedItem.Item.ItemName}      X{orderedItem.Quantity}");
                    if (orderedItem.Comment != "")
                        lstbStarters1.Items.Add(orderedItem.Comment);
                }
                else if (orderedItem.Item.SubCategory == SubCategory.Mains || orderedItem.Item.SubCategory == SubCategory.LunchMain || orderedItem.Item.SubCategory == SubCategory.Specials)
                {
                    lstbMains1.Items.Add($"{orderedItem.Item.ItemName}      X{orderedItem.Quantity}");
                    if (orderedItem.Comment != "")
                        lstbMains1.Items.Add(orderedItem.Comment);
                }
                else if (orderedItem.Item.SubCategory == SubCategory.Desserts)
                {
                    lstbDesserts1.Items.Add($"{orderedItem.Item.ItemName}      X{orderedItem.Quantity}");
                    if (orderedItem.Comment != "")
                        lstbDesserts1.Items.Add(orderedItem.Comment);
                }
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
            int orderID = int.Parse(lblOrderID1.Text);
            
            
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
            pnlOrder3.Hide();
        }
    }
}