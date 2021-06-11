﻿using System;
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

        //the joins in this one dont really work
        public List<Order> GetAllRunningOrders()
        {
            string query = "select OrderItem.orderID, employeeID, tableID, startTime, endTime, isPaid, Items.itemID, [count], [state], orderTime, comment, itemName, stock, price, itemType, itemSubType FROM[Order] JOIN OrderItem ON[Order].orderID = OrderItem.orderID JOIN Items ON[Items].itemID = OrderItem.itemID WHERE isPaid = 0";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Order> orders = ReadOrders(ExecuteSelectQuery(query, sqlParameters));
            return orders;
        }

        public void AddOrderOrderItems(Order order)// this method adds all the orderItems from the list in Order to the database
        {
            foreach (OrderItem orderItem in order.orderedItems)
            {
                int state = (int)orderItem.State;
                string query = $"INSERT INTO [OrderItem] (orderID, itemID, count, state, orderTime, comment) Values ({orderItem.OrderID}, {orderItem.Item.ItemID}, {orderItem.Quantity}, {state}, '{orderItem.OrderTime.Year}-{orderItem.OrderTime.Month}-{orderItem.OrderTime.Day} {orderItem.OrderTime.Hour}:{orderItem.OrderTime.Minute}:{orderItem.OrderTime.Second}', '' );";

                SqlParameter[] sqlParameters = new SqlParameter[0];

                ExecuteEditQuery(query, sqlParameters);
            }
        }


        public List<Order> GetAllOrders()
        {
            string query = $"select OrderItem.orderID, employeeID, tableID, startTime, endTime, isPaid, Items.itemID, [count], [state], orderTime, comment, itemName, stock, price, itemType, itemSubType FROM[Order] JOIN OrderItem ON[Order].orderID = OrderItem.orderID JOIN Items ON[Items].itemID = OrderItem.itemID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Order> orders = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            return orders;
        }

        public Order GetOrderByOrderID(int orderID)
        {
            string query = $"select OrderItem.orderID, employeeID, tableID, startTime, endTime, isPaid, Items.itemID, [count], [state], orderTime, comment, itemName, stock, price, itemType, itemSubType FROM[Order] JOIN OrderItem ON[Order].orderID = OrderItem.orderID JOIN Items ON[Items].itemID = OrderItem.itemID WHERE orderID = {orderID} ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Order> orders = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            Order order = orders[1];

            return order;
        }

        public void UpdateOrderState(int orderState, int orderID)
        {
            string query = $"UPDATE table OrderItem SET state = {orderState} WHERE orderID = {orderID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        

        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
            Order order = new Order();

            int currentOrderId = 0;

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

        public List<Order> GetAllRunningOrders1()
        {
            string query = "select orderID, employeeID, tableID, startTime, endTime, isPaid from [Order] where isPaid = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Order> orders = ReadOrders(ExecuteSelectQuery(query, sqlParameters));

            //GetOrderItems(orders);

            return orders;

        }

        //public List<OrderItem> GetOrderItems(List<Order> orders)
        //{
        //    foreach (Order runningorder in orders)
        //    {
        //        string query = $"SELECT orderID, itemID, [count], [state], orderTIme, comment FROM OrderItem WHERE orderID = {runningorder.OrderNr}";
        //        SqlParameter[] sqlParameters = new SqlParameter[0];
        //        List<Order> orders = ReadOrders(ExecuteSelectQuery(query, sqlParameters));

        //    }
        //}

        private List<Order> ReadOrders(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
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


                orders.Add(order);
            }

            return orders;
        }

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
