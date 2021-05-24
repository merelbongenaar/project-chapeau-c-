using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public enum SubCategory
    {
        LunchMain=1, Specials, Bites, Starters, Mains, Desserts, SoftDrinks, HotDrinks, Beers, Wines
    }

    public enum Category
    {
        Lunch=1, Dinner, Drinks
    }

    public class Item
    {
        public int ItemID { get; set; }

        public string ItemName { get; set; }

        public int Stock { get; set; }

        public decimal Price { get; set; }

        public Category Category { get; set; }

        public SubCategory SubCategory { get; set; }


    }
}
