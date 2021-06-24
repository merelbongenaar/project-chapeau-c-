using ChapeauDAL;
using ChapeauModel;
using System.Collections.Generic;

namespace ChapeauLogic
{
    public class TableService
    {
        TableDao tabledb;

        public TableService()
        {
            tabledb = new TableDao();
        }

        public List<Table> GetAllTables()
        {
            List<Table> tables = tabledb.GetAllTables();
            return tables;
        }

        public Table GetTableByTableNR(int tableNr)
        {
            Table table = tabledb.GetTableByTableNr(tableNr);
            return table;

        }

        public void UpdateStateTableToTrue(int tableNR)
        {
            tabledb.UpdateStateTableToTrue(tableNR);
        }
    }
}
