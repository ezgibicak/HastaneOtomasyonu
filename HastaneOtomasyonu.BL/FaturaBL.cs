using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneOtomasyonu.Entity.Domain;
using HastaneOtomasyonu.DAL;
using System.Data;

namespace HastaneOtomasyonu.BL
{
    public class FaturaBL
    {
        public int YeniFaturaEkle(int id,int faturadurumid,int odemeid,decimal fatura)
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            vt.ParametreEkle("@id", DbType.Int32, id);
            vt.ParametreEkle("@faturadurumid", DbType.Int32, faturadurumid);
            vt.ParametreEkle("@odemeid", DbType.Int32, odemeid);
            vt.ParametreEkle("@fatura", DbType.Decimal, fatura);
            string sorgu = "sp_FaturaEkle";
            int sonuc=vt.ExecuteNonQueryYap(sorgu, CommandType.StoredProcedure);

            return sonuc;


        }
        List<FaturaDurum> liste=new List<FaturaDurum>();
        public List<FaturaDurum> DurumTablosu()
        {

            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            string sorgu = "sp_FaturaDurumGetir";
            IDataReader dr = vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);

            while (dr.Read())
            {
                FaturaDurum ftd = new FaturaDurum();
                ftd.FaturaDurumID = (int)dr["FaturaDurumID"];
                ftd.FaturaDurum2= dr["FaturaDurum"].ToString();
                liste.Add(ftd);
            }

            dr.Dispose();
            return liste;
        }

        List<OdemeTürü> odm = new List<OdemeTürü>();

        public List<OdemeTürü> OdemeTablosu()
        {

            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            string sorgu = "sp_OdemeSekli";
            IDataReader dr = vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);

            while (dr.Read())
            {
                OdemeTürü ot = new OdemeTürü();
                ot.OdemeID = (int)dr["OdemeID"];
                ot.OdemeTürü2 = dr["OdemeTürü"].ToString();
                odm.Add(ot);
            }

            dr.Dispose();
            return odm;
        }
    }
}
