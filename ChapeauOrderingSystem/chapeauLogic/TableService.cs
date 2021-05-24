using System;
using System.Collections.Generic;
using System.Text;
using ChapeauDAL;
using ChapeauModel;

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

        public void UpdateStateTableToTrue(int tableNR)
        {
            tabledb.UpdateStateTableToTrue(tableNR);
        }
    }
}
