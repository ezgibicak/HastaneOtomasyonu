using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Entity.Dto
{
    public class HastaOdaBilgileri
    {

        public int HastaID { get; set; }
        public string HastaAdi { get; set; }
        public string HastaSoyadi { get; set; }
        public int TC { get; set; }
        public int OdaNo { get; set; }
        public DateTime GirişTarihi { get; set; }
        public DateTime CıkısTarihi { get; set; }
    }
}
