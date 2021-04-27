using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeknolojikAletSatisSitesi.Entities;

namespace TeknolojikAletSatisSitesi.WebUI.Models
{
    public class ProductDetailsModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}
