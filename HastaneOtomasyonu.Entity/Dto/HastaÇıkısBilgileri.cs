using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Entity.Dto
{
    public class HastaÇıkısBilgileri
    {
        public int HastaID { get; set; }
        public string HastaAdi { get; set; }
        public string HastaSoyadi { get; set; }
        public int? CepTelefonu { get; set; }
        public decimal Fatura { get; set; }
        public int FaturaID { get; set; }
        public DateTime CıkısTarihi { get; set; }
    }
}
