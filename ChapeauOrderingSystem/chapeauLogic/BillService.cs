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

        public void AddBill(Order order)
        {
            billDao.AddBill(order.Bill);
            billDao.UpdateOrderStatus(order);
            billDao.UpdateTableStatus(order.TableID);
        }

    }
}
