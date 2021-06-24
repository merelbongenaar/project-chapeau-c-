using ChapeauDAL;
using ChapeauModel;
using System.Collections.Generic;

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

        public Item GetItemByName(string itemName)
        {
            return itemdb.GetItemByName(itemName);
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

        public void UpdateStock(Item item)
        {
            itemdb.UpdateStock(item);
        }
    }
}
