using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HastaneOtomasyonu.DAL
{
    public class BaglantiSaglayicisi
    {
        private static SqlConnection BaglantiNesnesi;
        
        public static SqlConnection BaglantıOlustur()
        {
            if (BaglantiNesnesi == null)
            {
                BaglantiNesnesi = new SqlConnection(BaglantiCümlesi);
            }
            
           return BaglantiNesnesi;
        }
        public static string BaglantiCümlesi
        {
            get
            {
                return ConfigurationManager.AppSettings["Veritabani"];
            }

        }


    }
}
