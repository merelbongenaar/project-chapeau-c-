using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ChapeauModel;

namespace ChapeauDAL
{
    public class OrderDao : BaseDao
    {
        //hai 

        //hai hai hai

        public Order GetOrderByTableNr(int tableNr)
        {
            string query = $"select OrderItem.orderID, employeeID, tableID, startTime, endTime, isPaid, Items.itemID, [count], [state], orderTime, comment, itemName, stock, price, itemType, itemSubType FROM[Order] JOIN OrderItem ON[Order].orderID = OrderItem.orderID JOIN Items ON[Items].itemID = OrderItem.itemID WHERE tableID = {tableNr}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Order> orders = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            if (orders.Count == 0)
            {
                return null;
            }
            else
            {
                return orders[0];
            }
        }

        public List<Order> GetAllRunningOrders()
        {
            string query = "select OrderItem.orderID, employeeID, tableID, startTime, endTime, isPaid, Items.itemID, [count], [state], orderTime, comment, itemName, stock, price, itemType, itemSubType" +
            "FROM[Order] JOIN OrderItem ON[Order].orderID = OrderItem.orderID JOIN Items ON[Items].itemID = OrderItem.itemID WHERE isPaid = 0";
            
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Order> orders = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            return orders;
        }

        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            Order order = new Order();

            foreach (DataRow dr in dataTable.Rows)
            {
                
                OrderItem orderItem = new OrderItem();
                Item item = new Item();

                item.ItemID = (int)(dr["itemID"]);
                item.ItemName = (string)(dr["itemName"]);
                item.Stock = (int)(dr["stock"]);
                item.Price = (decimal)(dr["price"]);
                item.Category = (Category)(dr["itemType"]);
                item.SubCategory = (SubCategory)(dr["itemSubType"]);


                orderItem.OrderID = (int)(dr["orderID"]);
                orderItem.Quantity = (int)(dr["count"]);

                if (dr["comment"] == DBNull.Value)
                {
                    orderItem.Comment = "";
                }
                else
                {
                    orderItem.Comment = (string)(dr["comment"]);
                }

                orderItem.OrderTime = (DateTime)(dr["orderTime"]);
                orderItem.State = (State)(dr["state"]);
                orderItem.Item = item;


                order.OrderNr = (int)(dr["orderID"]);
                order.EmployeeID = (int)(dr["employeeID"]);
                order.TableID = (int)(dr["tableID"]);

                if (dr["startTime"] != DBNull.Value)
                {
                    order.StartTime = (DateTime)(dr["startTime"]);
                }
                else
                {
                    order.StartTime = null;
                }

                if ((dr["endTime"]) != DBNull.Value)
                {
                    order.EndTime = (DateTime)(dr["endTime"]);
                }
                else
                {
                    order.EndTime = null;
                }

                order.orderedItems.Add(orderItem);

                orders.Add(order);
            }

            return orders;
        }
    }
}
