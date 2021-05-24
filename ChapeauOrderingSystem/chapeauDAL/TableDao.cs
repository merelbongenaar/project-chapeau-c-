using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ChapeauModel;

namespace ChapeauDAL
{
    public class TableDao : BaseDao
    {
        public List<Table> GetAllTables()
        {
            string query = $"SELECT tableID, capacity, tableNumber, isOccupied FROM [Table]";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Table> tables = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            return tables;
        }

        public void UpdateStateTableToTrue(int tableNR)
        {
            string query = $"UPDATE [Table] SET isOccupied=1 WHERE tableID={tableNR}";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(query, sqlParameters);
        }


        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table();

                table.TableID = (int)(dr["tableID"]);
                table.Capacity = (int)(dr["capacity"]);
                table.TableNumber = (int)(dr["tableNumber"]);
                table.IsOccupied = (bool)(dr["isOccupied"]);

                tables.Add(table);
            }

            return tables;
        }
    }
}
