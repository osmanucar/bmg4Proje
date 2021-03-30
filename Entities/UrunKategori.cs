using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class UrunKategori
    {
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }

        public int UrunId { get; set; }
        public Urun Urun { get; set; }
    }
}
