using ChapeauDAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauLogic
{
    public class ItemService
    {
        ItemDao itemDao;

        public ItemService()
        {
            itemDao = new ItemDao();
        }

    }
}
