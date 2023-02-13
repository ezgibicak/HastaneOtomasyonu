using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; 

namespace HastaneOtomasyonu.DAL
{
    class VeritabaniException:ApplicationException
    {
        public VeritabaniException (string mesaj) : base(mesaj)
        {
            if (!EventLog.SourceExists("HastaneOtomasyonu"))
            {
                EventLog.CreateEventSource("HastaneOtomasyonu","Vektörel");

            }

            EventLog log = new EventLog();
            log.Source = "HastaneOtomasyonu";
            log.WriteEntry(mesaj,EventLogEntryType.Error);
        }

    }
}
