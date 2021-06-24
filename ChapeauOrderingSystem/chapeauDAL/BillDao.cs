using ChapeauModel;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class BillDao : BaseDao
    {
        public void AddBill(Bill bill)
        {
            string query = $"INSERT INTO [bill] (totalPrice, tip, tax, orderID, typeOfPayment, feedback) VALUES (@totalPrice, @tip, @tax, @orderID, @typeOfPayment, @feedback) ";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("totalPrice", bill.TotalPrice);
            sqlParameters[1] = new SqlParameter("tip", bill.Tip);
            sqlParameters[2] = new SqlParameter("tax", bill.Tax);
            sqlParameters[3] = new SqlParameter("orderID", bill.OrderID);
            sqlParameters[4] = new SqlParameter("typeOfPayment", bill.TypeOfPayment);
            sqlParameters[5] = new SqlParameter("feedback", bill.Feedback);

            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateOrderStatus(Order order)
        {
            string query = $"UPDATE [order] SET isPaid=@isPaid, endTime=@endTime WHERE orderID=@orderID";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("orderID", order.OrderNr);
            sqlParameters[1] = new SqlParameter("isPaid", 1);
            sqlParameters[2] = new SqlParameter("endTime", order.EndTime);

            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateTableStatus(int tableID)
        {
            string query = $"UPDATE [Table] SET isOccupied=0 WHERE tableID=@tableID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("tableID", tableID);

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
