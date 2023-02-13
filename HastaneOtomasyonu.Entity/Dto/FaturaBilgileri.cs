using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Entity.Dto
{
    public class FaturaBilgileri
    {


        public int HastaID { get; set; }
        public string HastaAdi { get; set; }
        public string HastaSoyadi { get; set; }
        public DateTime? dogumtarihi { get; set; }
        public int? CepNo { get; set; }
        public int TC { get; set; }
        public int? SigortaNo { get; set; }
        public string SigortaAdi { get; set; }
        public decimal Fatura { get; set; }
        public string FaturaDurum { get; set; }
        public  string OdemeSekli { get; set; }
        public int FaturaDurumID { get; set; }
        public int OdemeID { get; set; }

    }

}
