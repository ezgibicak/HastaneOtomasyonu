using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Utilities
{
   public class RastgeleIsimUret
    {

        public string IsimGetir()
        {
            DateTime dt = DateTime.Now;


            return Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8) + "_" + dt.Ticks;

        }
    }
}
