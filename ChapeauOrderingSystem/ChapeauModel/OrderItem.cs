using System;

namespace ChapeauModel
{
    public enum State
    {
        NotStarted = 1, Preparing, Done, Served
    }

    public class OrderItem
    {
        public Item Item { get; set; }

        public int OrderID { get; set; }

        public int Quantity { get; set; }

        public State State { get; set; }

        public DateTime OrderTime { get; set; }

        public string Comment { get; set; }
    }
}
