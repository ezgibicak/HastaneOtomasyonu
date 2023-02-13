using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Entity
{
    public class KullaniciPersonel
    {
        public int KullaniciID { get; set; }
        public int PersonelID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public int? Aktiflik { get; set; }
    }
}
