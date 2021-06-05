using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

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
            string query = $"UPDATE [order] SET isPaid=@isPaid WHERE orderID=@orderID";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("orderID", order.OrderNr);
            sqlParameters[1] = new SqlParameter("isPaid", 1);

            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateTableStatus(int tableID)
        {
            string query = $"UPDATE [Table] SET isOccupied=@isOccupied WHERE tableID=@tableID";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("tableID", tableID);
            sqlParameters[1] = new SqlParameter("isOccupied", 0);

            ExecuteEditQuery(query, sqlParameters);
        }



    }
}
