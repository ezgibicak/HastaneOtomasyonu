using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Entity.Dto
{
    public class HastaIdyeGöre
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int? Id { get; set; }
        public DateTime? Dogumtarihi { get; set; }
        public decimal? Kilo { get; set; }
        public decimal? Boy { get; set; }
        public int? TCno { get; set; }
        public int? CepNo { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
