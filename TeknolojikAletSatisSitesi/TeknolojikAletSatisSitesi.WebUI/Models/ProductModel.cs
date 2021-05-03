using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TeknolojikAletSatisSitesi.Entities;

namespace TeknolojikAletSatisSitesi.WebUI.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ürün isim alanı zorunludur.")]
        [StringLength(60, MinimumLength =2, ErrorMessage ="Ürün ismi minumum 2 karakter ve maksimum 60 karakter olmalıdır")]
        public string Name { get; set; }

        [Required(ErrorMessage = "ImageUrl alanı zorunludur.")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Açıklama alanı zorunludur.")]
        [StringLength(10000, MinimumLength = 2, ErrorMessage = "Ürün açıklması minumum 2 karakter ve maksimum 10000 karakter olmalıdır")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Fiyat alanı zorunludur.")]
        [Range(1,20000, ErrorMessage = "Fiyat 1-20000 aralığında olmalıdır")]
        public decimal? Price { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}
