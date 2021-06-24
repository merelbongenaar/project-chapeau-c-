using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class OrderItemDao : BaseDao
    {
        public List<OrderItem> GetAllOrderItems()
        {
            string query = $"SELECT orderID, item, quantity, state, orderTime, comment FROM OrderItem";

            SqlParameter[] sqlParameters = new SqlParameter[0];

            List<OrderItem> orderItems = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            return orderItems;
        }

        public void UpdateOrderState(State orderState, int orderID)
        {
            string query = $"UPDATE OrderItem SET state = @state WHERE orderID = @orderID";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("state", orderState);
            sqlParameters[1] = new SqlParameter("orderID", orderID);

            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateOrderState(int itemID, State orderState, int orderID)
        {
            string query = $"UPDATE OrderItem SET [state] = @state WHERE orderID = @orderID AND itemID = @itemID ";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("state", orderState);
            sqlParameters[1] = new SqlParameter("orderID", orderID);
            sqlParameters[2] = new SqlParameter("itemID", itemID);

            ExecuteEditQuery(query, sqlParameters);
        }

        //This method retrieves an OrderItem based on the provided name, state and orderID of the order it belongs to
        public OrderItem GetOrderItem(int itemID, int orderID)
        {
            string query = $"SELECT orderID, OrderItem.itemID, [count], state, orderTime, comment FROM OrderItem JOIN Items ON[Items].itemID = OrderItem.itemID WHERE OrderItem.orderID = @orderID AND Items.itemID = @itemID ";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("orderID", orderID);
            sqlParameters[1] = new SqlParameter("itemID", itemID);

            List<OrderItem> items = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            if (items.Count > 0)
                return items[0];
            else
                return null;
        }

        private List<OrderItem> ReadTables(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();


            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem();

                orderItem.OrderID = (int)(dr["orderID"]);
                orderItem.Item = (Item)(dr["item"]);
                orderItem.Quantity = (int)(dr["quantity"]);
                orderItem.State = (State)(dr["state"]);
                orderItem.OrderTime = (DateTime)(dr["orderTime"]);
                orderItem.Comment = (string)(dr["comment"]);

                orderItems.Add(orderItem);
            }

            return orderItems;
        }
    }
}
