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

        public Order GetOrderByTableNr(int tableNr)
        {
            string query = $"select OrderItem.orderID, employeeID, tableID, startTime, endTime, isPaid, Items.itemID, [count], [state], orderTime, comment, itemName, stock, price, itemType, itemSubType FROM[Order] JOIN OrderItem ON[Order].orderID = OrderItem.orderID JOIN Items ON[Items].itemID = OrderItem.itemID WHERE tableID=@tableID AND isPaid = 0";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("tableID", tableNr);

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

        //the joins in this one dont really work
        public List<Order> GetAllRunningOrders()
        {
            string query = "select OrderItem.orderID, employeeID, tableID, startTime, endTime, isPaid, Items.itemID, [count], [state], orderTime, comment, itemName, stock, price, itemType, itemSubType FROM[Order] JOIN OrderItem ON[Order].orderID = OrderItem.orderID JOIN Items ON[Items].itemID = OrderItem.itemID WHERE isPaid = 0 ORDER BY orderTime ";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Order> orders = ReadTablesTest2(ExecuteSelectQuery(query, sqlParameters));

            return orders;
        }

        public void AddOrder(Order order)
        {
            string query = $"INSERT INTO [Order] (orderID, employeeID, tableID, startTime, isPaid) Values (@orderID, @employeeID, @tableID, '@startTime', 0);";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("orderID", order.OrderNr);
            sqlParameters[1] = new SqlParameter("employeeID", order.EmployeeID);
            sqlParameters[2] = new SqlParameter("tableID", order.TableID);
            sqlParameters[3] = new SqlParameter("startTime", DateTime.Now);


            ExecuteEditQuery(query, sqlParameters);
        }

        public Order GetLastOrder()
        {
            string query = $"select top 1 orderID, employeeID, tableID, startTime, endTime, isPaid FROM [Order] ORDER BY orderID DESC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            
            Order order = ReadTable(ExecuteSelectQuery(query, sqlParameters));

            return order;
        }

        public List<Order> GetAllOrders()
        {
            string query = $"select OrderItem.orderID, employeeID, tableID, startTime, endTime, isPaid, Items.itemID, [count], [state], orderTime, comment, itemName, stock, price, itemType, itemSubType FROM[Order] JOIN OrderItem ON[Order].orderID = OrderItem.orderID JOIN Items ON[Items].itemID = OrderItem.itemID ORDER BY orderTime";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Order> orders = ReadTablesTest2(ExecuteSelectQuery(query, sqlParameters));

            return orders;
        }

        public void AddOrderedItems(OrderItem orderItem)
        {
            int state = (int)orderItem.State;
            orderItem.OrderTime = DateTime.Now;
            string query = $"INSERT INTO [OrderItem] (orderID, itemID, count, state, orderTime, comment) Values (@orderID, @itemID, @count, @state, @orderTime, @comment );";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("orderID", orderItem.OrderID);
            sqlParameters[1] = new SqlParameter("itemID", orderItem.Item.ItemID);
            sqlParameters[2] = new SqlParameter("count", orderItem.Quantity);
            sqlParameters[3] = new SqlParameter("state", state);
            sqlParameters[4] = new SqlParameter("orderTime", orderItem.OrderTime);
            sqlParameters[5] = new SqlParameter("comment", orderItem.Comment);

            ExecuteEditQuery(query, sqlParameters);
        }

        public Order GetOrderByOrderID(int orderID)
        {
            string query = $"select OrderItem.orderID, employeeID, tableID, startTime, endTime, isPaid, Items.itemID, [count], [state], orderTime, comment, itemName, stock, price, itemType, itemSubType FROM[Order] JOIN OrderItem ON[Order].orderID = OrderItem.orderID JOIN Items ON[Items].itemID = OrderItem.itemID WHERE OrderItem.orderID=@orderID ";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("orderID", orderID);

            List<Order> orders = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            if (orders.Count > 0)
                return orders[0];
            else
                return null;
        }

        private Order ReadTable(DataTable dataTable)
        {
            Order order = new Order();

            foreach (DataRow dr in dataTable.Rows)
            {
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
            }
            return order;
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

        //---------------------------------------------------------------------------------------------------testing------------------------------------------------------------------------------------------------
        private List<Order> ReadTablesTest2(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            Order previousorder = new Order();
            //int previousOrdernr = 0;
            int currentOrdernr = 0;

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem();
                Item item = new Item();

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

                item.ItemID = (int)(dr["itemID"]);
                item.ItemName = (string)(dr["itemName"]);
                item.Stock = (int)(dr["stock"]);
                item.Price = (decimal)(dr["price"]);
                item.Category = (Category)(dr["itemType"]);
                item.SubCategory = (SubCategory)(dr["itemSubType"]);
                orderItem.Item = item;

                if (currentOrdernr != (int)(dr["orderID"]))
                {
                    Order order = new Order();

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
                    currentOrdernr = order.OrderNr;
                    previousorder = order;

                    orders.Add(previousorder);
                }

                else
                {
                    previousorder.orderedItems.Add(orderItem);
                }
            }

            return orders;

        }

        //public List<Order> GetAllRunningOrders1()
        //{
        //    string query = "select orderID, employeeID, tableID, startTime, endTime, isPaid from [Order] where isPaid = 0";
        //    SqlParameter[] sqlParameters = new SqlParameter[0];
        //    List<Order> orders = ReadOrders(ExecuteSelectQuery(query, sqlParameters));

        //    //GetOrderItems(orders);

        //    return orders;

        //}

        //public List<OrderItem> GetOrderItems(List<Order> orders)
        //{
        //    foreach (Order runningorder in orders)
        //    {
        //        string query = $"SELECT orderID, itemID, [count], [state], orderTIme, comment FROM OrderItem WHERE orderID = {runningorder.OrderNr}";
        //        SqlParameter[] sqlParameters = new SqlParameter[0];
        //        List<Order> orders = ReadOrders(ExecuteSelectQuery(query, sqlParameters));

        //    }
        //}

        //private List<Order> ReadOrders(DataTable dataTable)
        //{
        //    List<Order> orders = new List<Order>();

        //    foreach (DataRow dr in dataTable.Rows)
        //    {
        //        Order order = new Order();

        //        order.OrderNr = (int)(dr["orderID"]);
        //        order.EmployeeID = (int)(dr["employeeID"]);
        //        order.TableID = (int)(dr["tableID"]);

        //        if (dr["startTime"] != DBNull.Value)
        //        {
        //            order.StartTime = (DateTime)(dr["startTime"]);
        //        }
        //        else
        //        {
        //            order.StartTime = null;
        //        }

        //        if ((dr["endTime"]) != DBNull.Value)
        //        {
        //            order.EndTime = (DateTime)(dr["endTime"]);
        //        }
        //        else
        //        {
        //            order.EndTime = null;
        //        }


        //        orders.Add(order);
        //    }

        //    return orders;
        //}

        ////private List<OrderItem> ReadOrderItems(DataTable dataTable)
        ////{

        ////}

        //private List<Order> ReadTablesTest(DataTable dataTable)
        //{
        //    List<Order> orders = new List<Order>();



        //    foreach (DataRow dr in dataTable.Rows)
        //    {

        //        OrderItem orderItem = new OrderItem();
        //        Item item = new Item();

        //        item.ItemID = (int)(dr["itemID"]);
        //        item.ItemName = (string)(dr["itemName"]);
        //        item.Stock = (int)(dr["stock"]);
        //        item.Price = (decimal)(dr["price"]);
        //        item.Category = (Category)(dr["itemType"]);
        //        item.SubCategory = (SubCategory)(dr["itemSubType"]);


        //        orderItem.OrderID = (int)(dr["orderID"]);
        //        orderItem.Quantity = (int)(dr["count"]);

        //        if (dr["comment"] == DBNull.Value)
        //        {
        //            orderItem.Comment = "";
        //        }
        //        else
        //        {
        //            orderItem.Comment = (string)(dr["comment"]);
        //        }

        //        orderItem.OrderTime = (DateTime)(dr["orderTime"]);
        //        orderItem.State = (State)(dr["state"]);
        //        orderItem.Item = item;


        //        order.OrderNr = (int)(dr["orderID"]);
        //        order.EmployeeID = (int)(dr["employeeID"]);
        //        order.TableID = (int)(dr["tableID"]);

        //        if (dr["startTime"] != DBNull.Value)
        //        {
        //            order.StartTime = (DateTime)(dr["startTime"]);
        //        }
        //        else
        //        {
        //            order.StartTime = null;
        //        }

        //        if ((dr["endTime"]) != DBNull.Value)
        //        {
        //            order.EndTime = (DateTime)(dr["endTime"]);
        //        }
        //        else
        //        {
        //            order.EndTime = null;
        //        }

        //        order.orderedItems.Add(orderItem);

        //        orders.Add(order);
        //    }

        //    return orders;
        //}


    }
}
