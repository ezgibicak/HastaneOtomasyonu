using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Entity.Domain
{
   public class Personel
    {

        public int PersonelID { get; set; }
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        public int? MeslekID { get; set; }
        public int TcNo { get; set; }
        public int? EvTelefonu { get; set; }
        public int? CepTelefonu { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public int? AdresID { get; set; }
        public int? CinsiyetID { get; set; }
        public DateTime? İseBaslamaTarihi { get; set; }
        public string FotografYolu { get; set; }
        public byte[] Fotograf { get; set; }

        public string Adres { get; set; }
        public string Cinsiyet { get; set; }
        public string Meslek { get; set; }

    }
}
