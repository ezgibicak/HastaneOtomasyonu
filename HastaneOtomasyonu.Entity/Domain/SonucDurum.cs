using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Entity.Domain
{
     public class SonucDurum
    {
        public int SonucID { get; set; }
        public int SoncDurumID { get; set; }
        public string SonucTakip { get; set; }
        public DateTime SonucTakipTarih { get; set; }
        
    }
}
