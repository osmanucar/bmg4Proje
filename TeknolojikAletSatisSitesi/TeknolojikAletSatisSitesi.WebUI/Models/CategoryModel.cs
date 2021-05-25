using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TeknolojikAletSatisSitesi.Entities;

namespace TeknolojikAletSatisSitesi.WebUI.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Kategori isim alanı zorunludur.")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Kategori ismi minumum 2 karakter ve maksimum 60 karakter olmalıdır")]
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
