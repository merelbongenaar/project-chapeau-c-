using ChapeauLogic;
using ChapeauModel;
using System;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class BillForm : Form
    {
        public Order Order { get; set; }
        public BillForm(Order order)
        {
            InitializeComponent();
            this.Order = order;
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            ShowPanel("BillPanel");
            radioBtnPin.Checked = true;
        }

        private void ShowPanel(string name)
        {
            try
            {
                // display table number and waiter id
                lblTableID.Text = Order.TableID.ToString();
                lblWaiterID.Text = Order.EmployeeID.ToString();

                // clear the listview before filling it again
                listViewOrderItems.Items.Clear();

                //display the orderd items in a list view
                foreach (OrderItem orderitem in Order.orderedItems)
                {

                    ListViewItem li = new ListViewItem(orderitem.Item.ItemID.ToString());
                    li.SubItems.Add(orderitem.Item.ItemName);
                    li.SubItems.Add(orderitem.Item.Price.ToString("€0.00"));
                    li.SubItems.Add(orderitem.Quantity.ToString());
                    li.SubItems.Add(orderitem.Item.Category.ToString());
                    li.SubItems.Add(orderitem.Item.SubCategory.ToString());
                    li.SubItems.Add(orderitem.Comment);
                    listViewOrderItems.Items.Add(li);
                }

                // display total amount and VAT
                lblTotalAmount.Text = (Order.TotalPrice + Order.Vat).ToString("€ 0.00");
                lblTotalAmount.Tag = Order.TotalPrice + Order.Vat;
                lblVAT.Text = Order.Vat.ToString("€ 0.00");


            }
            catch (Exception r)
            {
                MessageBox.Show("Something went wrong while loading the bills: " + r.Message);
            }
        }

        private void txtBoxTip_TextChanged(object sender, EventArgs e)
        {
            // get the tip amount that the user will enter     
            decimal tip = 0;
            try
            {
                if (txtBoxTip.Text.Length > 0 && TxtBoxDigitsFilter(txtBoxTip.Text))
                {
                    tip = decimal.Parse(txtBoxTip.Text);
                }
                else if (!TxtBoxDigitsFilter(txtBoxTip.Text) && txtBoxTip.Text.Length > 0)
                {
                    MessageBox.Show("Invalid tip amount, please enter only digits!");
                    txtBoxTip.Text = "";
                }
                else
                {
                    tip = 0;
                }
            }
            catch (Exception t)
            {

                MessageBox.Show("Something went wrong with the tip: " + t.Message);
            }

            // store the tip amount to the new bill object
            Order.Bill.Tip = tip;

            // display the new total amount 
            lblTotalAmount.Text = (Order.TotalPrice + Order.Bill.Tip + Order.Vat).ToString("€ 0.00");
            lblTotalAmount.Tag = Order.TotalPrice + Order.Bill.Tip + Order.Vat;
        }

        // method to filter the txtbox to accept int only
        private bool TxtBoxDigitsFilter(string txt)
        {
            foreach (char c in txt)
            {
                if (c == '.')
                {
                    return true;
                }
                else if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }

        private void BtnFinishPayment_Click(object sender, EventArgs e)
        {
            // store the paymenet type to the new bill object using radio button
            if (radioBtnCredit.Checked)
            {
                Order.Bill.TypeOfPayment = ChapeauModel.typeOfPayment.creditCard;
            }
            else if (radioBtnCash.Checked)
            {
                Order.Bill.TypeOfPayment = ChapeauModel.typeOfPayment.cash;
            }
            else if (radioBtnPin.Checked)
            {
                Order.Bill.TypeOfPayment = ChapeauModel.typeOfPayment.pin;
            }

            // store the final total amount, the feedback, orderID and VAT to the new bill object
            Order.Bill.TotalPrice = (decimal)lblTotalAmount.Tag;
            Order.Bill.Feedback = txtBoxFeedback.Text;
            Order.Bill.OrderID = Order.OrderNr;
            Order.Bill.Tax = Order.Vat;
            Order.EndTime = DateTime.Now;

            // add the new bill to the databse and update order status to Paid. also, update table status to Not Occupied 
            BillService billService = new BillService();
            billService.AddBill(Order);

            // diaplay a message to the user that the order has been paid for
            MessageBox.Show("order has been paid");

            // close the form and return to table overview
            this.Close();
        }
    }
}
