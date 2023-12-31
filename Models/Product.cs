﻿using Testing.Models;

namespace asp_net_core_MVC_1.Models
{
    public class Product
    {
        public Product() 
        { 
        }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public int OnSale { get; set; }
        public int StockLevel { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
