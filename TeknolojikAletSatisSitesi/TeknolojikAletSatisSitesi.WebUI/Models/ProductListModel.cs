using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeknolojikAletSatisSitesi.Entities;

namespace TeknolojikAletSatisSitesi.WebUI.Models
{
    public class PageInfo
    {
        public int TotalItems { get; set; } // toplam ürün sayısı
        public int ItemsPerPage { get; set; } // her sayfada kaç ürün göstermek istiyoruz
        public int CurrentPage { get; set; } // o anki sayfa
        public string CurrentCategory { get; set; } // o anki kategori

        public int TotalPages()
        {
            return (int)Math.Ceiling((decimal)TotalItems/ItemsPerPage);
        }
    }
    public class ProductListModel
    {
        public PageInfo PageInfo { get; set; }
        public List<Product> Products { get; set; }
    }
}
