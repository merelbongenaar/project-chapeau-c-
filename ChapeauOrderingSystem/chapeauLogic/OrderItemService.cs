using ChapeauDAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauLogic
{
    public class OrderItemService
    {
        OrderItemDao orderItemdb;

        public OrderItemService()
        {
            orderItemdb = new OrderItemDao();
        }
    }
}
