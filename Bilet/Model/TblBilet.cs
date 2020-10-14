using System;
using System.Collections.Generic;

namespace Bilet.Model
{
    public class TblBilet
    {
        public int BiletId { get; set; }
        public int BiletSayisi { get; set; }
        public string Ad { get; set; }
        public string Soyisim { get; set; }
        public string Aktivite{ get; set; }
        public DateTime BiletTarihi { get; set; }
    }
}
