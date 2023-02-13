using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Entity.Dto
{
    public class SigortaBilgileri
    {
        public string HastaAdi { get; set; }
        public string HastaSoyadi { get; set; }
        public int Tc { get; set; }
        public int? SigortaNo { get; set; }
        public string SigortaAdi { get; set; }
    }
}
