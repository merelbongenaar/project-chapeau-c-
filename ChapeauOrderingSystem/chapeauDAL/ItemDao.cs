﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ChapeauModel;

namespace ChapeauDAL
{
    public class ItemDao
    {
        public List<Item> GetAllOrderItems()
        {
            string query = $"SELECT itemID, itemName, stock, price, itemType, itemSubType FROM Items";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Item> items = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            return items;
        }

        private List<Item> ReadTables(DataTable dataTable)
        {
            List<Item> items = new List<Item>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Item item = new Item();

                item.ItemID = (int)(dr["itemID"]);
                item.ItemName = (string)(dr["itemName"]);
                item.Stock = (int)(dr["stock"]);
                item.Price = (decimal)(dr["price"]);
                item.Category = (Category)(dr["itemType"]);
                item.SubCategory = (SubCategory)(dr["itemSubType"]);

                items.Add(item);
            }

            return items;
        }


    }
}
