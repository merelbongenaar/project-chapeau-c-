using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace ChapeauDAL
{
    public class OrderItemDao : BaseDao
    {
        public List<OrderItem> GetAllOrderItems() //add a category to filter? and a where statement maybe? 
        {
            string query = $"SELECT orderID, item, quantity, state, orderTime, comment FROM OrderItem";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<OrderItem> orderItems = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            return orderItems;
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
