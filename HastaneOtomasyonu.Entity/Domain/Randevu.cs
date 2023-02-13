using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Entity.Domain
{
   public class Randevu
    {

        public int PersonelID { get; set; }
        public int BolumID { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public int HastaID { get; set; }
        public string Saat { get; set; }

    }

}
