using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    //Class OrderItem can contain a MenuItem instead of (int) MenuItemId


    public enum State
    {
        NotStarted=1, Preparing, Done
    }

    public class OrderItem
    {
        public Item Item { get; set; }

        //public int ItemID { get; set; }

        public int OrderID { get; set; }

        public int Quantity { get; set; }

        public State State { get; set; }

        public DateTime OrderTime { get; set; }

        public string Comment { get; set; }
    }
}
