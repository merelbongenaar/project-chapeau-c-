using System;
using System.Collections.Generic;

namespace ChapeauModel
{
    public class Order
    {
        //Class Order can contain a list of OrderItem-objects(and a Table instead of TableId, and a Employee instead of EmployeeId)
       
        
        public List<OrderItem> orderedItems { get; set; }

        public int OrderNr { get; set; }

        public int TableID { get; set; }
        public int EmployeeID { get; set; }

        //nullable datetimes
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        //public decimal Bill { get; set; }
        public Bill Bill { get; set; }

        public decimal TotalPrice
        {
            get
            {
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
                foreach (OrderItem orderItem in orderedItems)
                {
                    if (orderItem.Item.SubCategory == SubCategory.Beers || orderItem.Item.SubCategory == SubCategory.Wines)
                    {
                        Bill.Tax += orderItem.Item.Price * orderItem.Quantity * 0.21m;
                    }
                    else
                    {
                        Bill.Tax += orderItem.Item.Price * orderItem.Quantity * 0.06m;
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

        //method add order item if 
    }
}
