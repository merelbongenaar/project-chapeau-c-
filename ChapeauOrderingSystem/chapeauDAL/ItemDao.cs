using ChapeauModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class ItemDao : BaseDao
    {
        public List<Item> GetAllItems()
        {
            string query = $"SELECT itemID, itemName, stock, price, itemType, itemSubType FROM Items";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Item> items = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            return items;
        }

        public Item GetItemByName(string itemName)
        {
            string query = $"SELECT itemID, itemName, stock, price, itemType, itemSubType FROM Items WHERE itemName = @itemName ";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("itemName", itemName);
            List<Item> items = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            if (items.Count > 0)
                return items[0];
            else
                return null;
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

        public List<Item> GetMenuItemByCategory(int category)
        {
            string query = $"SELECT itemID, itemName, stock, price, itemType, itemSubType FROM Items WHERE itemType = @category";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("category", category);

            List<Item> items = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            return items;
        }

        public List<Item> GetMenuItemBySubCategory(int category)
        {
            string query = $"SELECT itemID, itemName, stock, price, itemType, itemSubType FROM Items WHERE itemSubType = @category";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("category", category);

            List<Item> items = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            return items;
        }

        public void UpdateStock(Item item)
        {
            string query = $"UPDATE [Items] SET stock=@stock WHERE itemID=@itemID";

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("stock", item.Stock);//("itemID", item.ItemID);
            sqlParameters[1] = new SqlParameter("itemID", item.ItemID);

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
