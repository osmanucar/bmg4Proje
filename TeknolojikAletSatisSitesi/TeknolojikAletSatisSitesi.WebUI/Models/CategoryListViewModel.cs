using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeknolojikAletSatisSitesi.Entities;

namespace TeknolojikAletSatisSitesi.WebUI.Models
{
    public class CategoryListViewModel
    {
        public string SelectedCategory { get; set; } //seçilmiş kategori bilgisini tutan yapı
        public List<Category> Categories { get; set; }
    }
}
