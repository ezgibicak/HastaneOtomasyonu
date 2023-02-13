using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Entity.Domain
{
   public class Fatura
    {

        public int FaturaDurumID { get; set; }
        public int HastaID { get; set; }
        public int OdemeID { get; set; }
        public decimal Faturası { get; set; }
        public int FaturaID { get; set; }
    }
}
