using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class UrunKategorisi
    {
        public int KategoriId { get; set; }
        public Kategoriler Kategoriler { get; set; }

        public int UrunId { get; set; }
        public Urunler Urunler { get; set; }
    }
}
