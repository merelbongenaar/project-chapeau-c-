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

        public OrderItem GetOrderItem(string itemName, int orderID, int state)
        {
            return orderItemdb.GetOrderItem(itemName, orderID, state);
        }
    }
}
