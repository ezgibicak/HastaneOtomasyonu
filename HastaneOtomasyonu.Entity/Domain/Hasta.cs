using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Entity.Domain
{
    public class Hasta
    {
        public int HastaID { get; set; }
        public string HastaAdi { get; set; }
        public string HastaSoyadi { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public  int TC { get; set; }
        public decimal? Boy { get; set; }
        public decimal? Kilo { get; set; }
        public int? KanGrubuID { get; set; }
        public int? CinsiyetID { get; set; }
        public int? EvTelefonu { get; set; }
        public int? CepTelefonu { get; set; }
        public int? IsTelefonu { get; set; }
        public int? FaturaID { get; set; }
        public int? RandevuID { get; set; }
        public int? SonucID { get; set; }
        public int? SigortaID { get; set; }

        public List<HastaOda> HastaOdaListesi { get; set; }
        public List<Sigorta> SigortaListesi { get; set; }

    }
}
