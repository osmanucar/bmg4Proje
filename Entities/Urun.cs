using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Urun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string ResimUrl { get; set; }
        public decimal Fiyat { get; set; }

        public List<UrunKategori> UrunKategoriler { get; set; }
    }
}
