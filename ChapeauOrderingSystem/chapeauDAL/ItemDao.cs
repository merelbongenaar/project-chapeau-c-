using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ChapeauDAL
{
    public class ItemDao : BaseDao
    {
        public List<Item> GetAllOrderItems()
        {
            List<Item> items = new List<Item>();
            return items;
        }

        private List<Item> ReadTables(DataTable dataTable)
        {
            List<Item> items = new List<Item>();

            foreach (DataRow dr in dataTable.Rows)
            {
                //Item item = new Item();

                //item.OrderID = (int)(dr["orderID"]);
                //item.Item = (Item)(dr["item"]);
                //item.Quantity = (int)(dr["quantity"]);
                //item.State = (State)(dr["state"]);
                //item.OrderTime = (DateTime)(dr["orderTime"]);
                //item.Comment = (string)(dr["comment"]);

                //items.Add(item);
            }

            return items;
        }
    }
}
