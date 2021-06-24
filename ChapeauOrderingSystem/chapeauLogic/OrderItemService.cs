using ChapeauDAL;
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

        public void UpdateOrderState(State orderState, int orderID)
        {
            orderItemdb.UpdateOrderState(orderState, orderID);
        }

        public void UpdateOrderState(int itemID, State orderState, int orderID)
        {
            orderItemdb.UpdateOrderState(itemID, orderState, orderID);
        }

        public OrderItem GetOrderItem(int itemID, int orderID)
        {
            return orderItemdb.GetOrderItem(itemID, orderID);
        }
    }
}
