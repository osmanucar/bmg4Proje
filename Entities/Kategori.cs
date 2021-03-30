using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public List<UrunKategori> UrunKategoriler { get; set; }
    }
}
