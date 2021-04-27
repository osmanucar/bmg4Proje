using System;
using System.Collections.Generic;
using System.Text;

namespace TeknolojikAletSatisSitesi.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}
