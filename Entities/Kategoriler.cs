using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Kategoriler
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public List<UrunKategorisi> UrunKategorileri { get; set; }
    }
}
