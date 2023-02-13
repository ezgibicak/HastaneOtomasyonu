using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Entity.Domain
{
    public  class KullaniciHasta
    {
        public int KullaniciID { get; set; }
        public int HastaID { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSifre { get; set; }
    }
}
