using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Entity.Domain
{
    public class HastaOda
    {
        public int HastaID { get; set; }
        public int OdaID { get; set; }
        public DateTime GirişTarihi { get; set; }
        public DateTime CıkısTarihi { get; set; }
    }
}
