using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauLogic
{
    public class BillService
    {
        BillDao billDao;
        public BillService()
        {
            billDao = new BillDao();
        }
        public void AddBill(Bill bill)
        {
            billDao.AddBill(bill);

        }
        public List<Order> GetOrders()
        {
            return billDao.GetOrders();

        }

        public List<OrderItem> GetOrderItemForOrderID(int orderID)
        {
            return billDao.GetOrderItemForOrderID(orderID);
        }

        public void UpdateOrderStatus(Order order)
        {
            billDao.UpdateOrderStatus(order);
        }

    }
}
