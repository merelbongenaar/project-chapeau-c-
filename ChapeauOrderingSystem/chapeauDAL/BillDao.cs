using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ChapeauDAL
{
    public class BillDao : BaseDao
    {
        public void AddBill(Bill bill)
        {
            string query = $"INSERT INTO [bill] (totalPrice, tip, tax, orderID, typeOfPayment, feedback) VALUES (@totalPrice, @tip, @tax, @orderID, @typeOfPayment, @feedback) ";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("totalPrice", bill.TotalPrice);
            sqlParameters[1] = new SqlParameter("tip", bill.Tip);
            sqlParameters[2] = new SqlParameter("tax", bill.Tax);
            sqlParameters[3] = new SqlParameter("orderID", bill.OrderID);
            sqlParameters[4] = new SqlParameter("typeOfPayment", bill.TypeOfPayment);
            sqlParameters[5] = new SqlParameter("feedback", bill.Feedback);

            ExecuteEditQuery(query, sqlParameters);

        }

        public List<Order> GetOrders()
        {
            string query = "SELECT orderID, employeeID, tableID FROM [Order] WHERE ispaid = 0";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));

        }

        private List<Order> ReadOrders(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderNr = Convert.ToInt32(dr["orderID"]),
                    EmployeeID = Convert.ToInt32(dr["employeeID"]),
                    TableID = Convert.ToInt32(dr["tableID"]),
                };
                orders.Add(order);
            }
            return orders;
        }

        public List<OrderItem> GetOrderItemForOrderID(int orderID)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            string query = "SELECT I.item_id, I.quantity, I.orderTime, I.itemStatus, I.comment, M.item_name, M.item_price FROM ORDER_ITEM AS I JOIN MENU_ITEM AS M on M.item_id = I.item_id WHERE I.orderID = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", orderID);
            return ReadOrderItem(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderItem> ReadOrderItem(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (DataRow dr in dataTable.Rows)
            {

            }
            return orderItems;
        }

        public void UpdateOrderStatus(Order order)
        {
            string query = $"UPDATE [order] SET isPaid=@isPaid, WHERE orderID=@orderID";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("orderID", order.OrderNr);
            sqlParameters[0] = new SqlParameter("isPaid", 1);

            ExecuteEditQuery(query, sqlParameters);
        }





    }
}
