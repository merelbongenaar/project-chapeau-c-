using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauLogic
{
    public class ItemService
    {
        ItemDao itemdb;

        public ItemService()
        {
            itemdb = new ItemDao();
        }

        public List<Item> GetAllItems()
        {
            List<Item> allItems = itemdb.GetAllItems();
            return allItems;
        }

        public List<Item> GetItemsByCategory(int category)
        {
            List<Item> allItemsOfCategory = itemdb.GetMenuItemByCategory(category);
            return allItemsOfCategory;
        }

        public List<Item> GetItemsBySubCategory(int category)
        {
            List<Item> allItemsOfCategory = itemdb.GetMenuItemBySubCategory(category);
            return allItemsOfCategory;
        }

    }
}
