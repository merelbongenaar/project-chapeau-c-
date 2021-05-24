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
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal Bill { get; set; }

        public Order()
        {
            orderedItems = new List<OrderItem>();
        }
    }
}
