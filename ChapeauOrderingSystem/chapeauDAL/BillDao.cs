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
            SqlParameter[] sqlParameters = new SqlParameter[0];

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


        public Order GetOrderByTableID(int tableID)
        {
            string query = "SELECT orderID, employeeID FROM [Order] WHERE tableID = @tableID AND ispaid = 0";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("tableID", tableID);

            return ReadOrderByTableID(ExecuteSelectQuery(query, sqlParameters));
        }

        private Order ReadOrderByTableID(DataTable dataTable)
        {
            Order order = null;
            foreach (DataRow dr in dataTable.Rows)
            {
                order = new Order()
                {
                    OrderNr = Convert.ToInt32(dr["orderID"]),
                    EmployeeID = Convert.ToInt32(dr["employeeID"]),
                };
            }
            return order;
        }

        public List<OrderItem> GetOrderItemForOrderID(int orderID)
        {
            List<OrderItem> orderItems = new List<OrderItem>();


            string query = "SELECT I.itemID, I.count, I.orderTime, I.state, I.comment, M.itemName, M.price, M.itemType, M.itemSubType FROM [OrderItem] AS I JOIN [Items] AS M on I.itemID = M.itemID WHERE I.orderID = @orderID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@orderID", orderID);


            return ReadOrderItem(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderItem> ReadOrderItem(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Item item = new Item()
                {
                    ItemID = Convert.ToInt32(dr["itemID"]),
                    ItemName = Convert.ToString(dr["itemName"]),
                    Price = Convert.ToDecimal(dr["price"]),
                    Category = (Category)dr["itemType"],
                    SubCategory = (SubCategory)dr["itemSubType"]
                };
                OrderItem orderItem = new OrderItem()
                {
                    Item = item,
                    Quantity = Convert.ToInt32(dr["count"]),
                    State = (State)dr["state"],
                    OrderTime = (DateTime)dr["orderTime"],
                    Comment = Convert.ToString(dr["comment"]),
                };
                orderItems.Add(orderItem);
            }
            return orderItems;
        }

        public void UpdateOrderStatus(Order order)
        {
            string query = $"UPDATE [order] SET isPaid=@isPaid WHERE orderID=@orderID";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("orderID", order.OrderNr);
            sqlParameters[1] = new SqlParameter("isPaid", 1);

            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateTableStatus(int tableID)
        {
            string query = $"UPDATE [Table] SET isOccupied=@isOccupied WHERE tableID=@tableID";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("tableID", tableID);
            sqlParameters[1] = new SqlParameter("isOccupied", Convert.ToBoolean(0));

            ExecuteEditQuery(query, sqlParameters);
        }



    }
}
