using System;
using System.Collections.Generic;
using System.Text;

namespace TeknolojikAletSatisSitesi.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String ImageUrl { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}
