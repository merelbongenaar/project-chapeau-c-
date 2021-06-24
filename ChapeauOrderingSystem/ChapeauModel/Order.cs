using System;
using System.Collections.Generic;

namespace ChapeauModel
{
    public class Order
    {
        public List<OrderItem> orderedItems { get; set; }

        public int OrderNr { get; set; }

        public int TableID { get; set; }
        public int EmployeeID { get; set; }

        //nullable datetimes
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public Bill Bill { get; set; }

        public decimal TotalPrice
        {
            get
            {
                Bill.TotalPrice = 0;
                foreach (OrderItem orderItem in orderedItems)
                {
                    // Bill.TotalPrice
                    Bill.TotalPrice += orderItem.Item.Price * orderItem.Quantity;
                }
                return Bill.TotalPrice;
            }
        }
        public decimal Vat
        {
            get
            {
                Bill.Tax = 0;
                foreach (OrderItem orderItem in orderedItems)
                {

                    if (orderItem.Item.SubCategory == SubCategory.Beers || orderItem.Item.SubCategory == SubCategory.Wines)
                    {
                        Bill.Tax += orderItem.Item.Price * orderItem.Quantity * (decimal)0.21;
                    }
                    else
                    {
                        Bill.Tax += orderItem.Item.Price * orderItem.Quantity * (decimal)0.06;
                    }
                }
                return Bill.Tax;
            }
        }

        public Order()
        {
            orderedItems = new List<OrderItem>();
            Bill = new Bill();
        }
    }
}
