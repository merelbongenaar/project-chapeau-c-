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
    }
}
