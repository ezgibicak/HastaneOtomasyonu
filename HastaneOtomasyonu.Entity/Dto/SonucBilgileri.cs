using HastaneOtomasyonu.Entity.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Entity.Dto
{
   public class SonucBilgileri
    {
        public int SonucID { get; set; }
        public string  Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string Sonuc { get; set; }
        public DateTime SonucTarih { get; set; }
        
        
    }
}
