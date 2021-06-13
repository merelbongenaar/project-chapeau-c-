using ChapeauDAL;
using System;
using System.Collections.Generic;
using System.Text;
using ChapeauModel;

namespace ChapeauLogic
{
    public class OrderItemService
    {
        OrderItemDao orderItemdb;

        public OrderItemService()
        {
            orderItemdb = new OrderItemDao();
        }

        public void UpdateOrderState(int orderState, int orderID)
        {
            orderItemdb.UpdateOrderState(orderState, orderID);
        }

        public void UpdateOrderState(int itemID, int orderState, int orderID)
        {
            orderItemdb.UpdateOrderState(itemID, orderState, orderID);
        }

        public OrderItem GetOrderItem(string itemName, int orderID)
        {
            return orderItemdb.GetOrderItem(itemName, orderID);
        }
    }
}
