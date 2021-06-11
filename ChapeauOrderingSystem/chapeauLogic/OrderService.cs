using System;
using System.Collections.Generic;
using System.Text;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class OrderService
    {
        OrderDao orderdb;

        public OrderService()
        {
            orderdb = new OrderDao();
        }

        public Order GetOrderByTableNR(int tablenr)
        {
            Order order = orderdb.GetOrderByTableNr(tablenr);
            return order;
        }

        public List<Order> GetAllRunningOrders()
        {
            List<Order> runningOrders = orderdb.GetAllRunningOrders();
            return runningOrders;
        }

        public void AddDataToOrder(Order order)
        {
            foreach (OrderItem item in order.orderedItems)
            {
                //orderdb.AddOrder
                //add orderItems to the database
            }
 
            orderdb.AddOrderOrderItems(order); //list
        }

        public List<Order> GetAllOrders()
        {
            return orderdb.GetAllOrders();
        }

        public void UpdateOrderState(int orderState, int orderID)
        {
            orderdb.UpdateOrderState(orderState, orderID);
        }
    }
}
