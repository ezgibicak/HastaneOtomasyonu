using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Entity.Dto
{
   public class RandevuBilgileri
    {
        public int RandevuID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string BolumAdi { get; set; }
        public DateTime RandevuTarihi { get; set; }
        public string Aciklama { get; set; }
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        public string Saat { get; set; }
    }
}
