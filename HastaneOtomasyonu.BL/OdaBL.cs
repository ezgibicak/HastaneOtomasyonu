using HastaneOtomasyonu.Entity.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneOtomasyonu.DAL;
using System.Data;
using HastaneOtomasyonu.Entity.Dto;

namespace HastaneOtomasyonu.BL
{
    public class OdaBL
    {
        public OdaDurum OdaDurumu(int no)
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            OdaDurum od = new OdaDurum();
            vt.ParametreEkle("@odano", DbType.Int32, no);
            string sorgu = "sp_Oda";
            IDataReader dr = vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);
            while (dr.Read())
            {

                od.DurumID = (int)dr["DurumID"];
                od.OdaNo = (int)dr["OdaNo"];
                od.OdaID = (int)dr["OdaID"];


            }
            dr.Dispose();
            return od;


        }
            public int HastaOdaKayıt(int id,int odaid,DateTime gtarih,DateTime ctarih)
            {
                VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
                vt.ParametreEkle("@hastaid", DbType.Int32, id);
                vt.ParametreEkle("@odaid", DbType.Int32, odaid);
                vt.ParametreEkle("@giristarihi", DbType.DateTime, gtarih);
                vt.ParametreEkle("@çıkıştarihi", DbType.DateTime, ctarih);
                string sorgu = "sp_HastaOdaKayıt";
                int sonuc=vt.ExecuteNonQueryYap(sorgu,CommandType.StoredProcedure);
                return sonuc;
               

            }

        public int HastaOdaDurumuDeğiştir(int odano,int durumid)
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            vt.ParametreEkle("@odano", DbType.Int32, odano);
            vt.ParametreEkle("@durumid", DbType.Int32, durumid);
            string sorgu = "sp_OdaDurumDeğiştir";
            int sonuc = vt.ExecuteNonQueryYap(sorgu, CommandType.StoredProcedure);
            return sonuc;


        }
        public HastaOdaBilgileri OdaBilgileriGetir(int no)
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            HastaOdaBilgileri hod = new HastaOdaBilgileri();
            vt.ParametreEkle("@odano", DbType.Int32, no);
            string sorgu = "[sp_HastaOda]";
            IDataReader dr = vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);
            if (dr.Read())
            {

                hod.HastaID = (int)dr["HastaID"];
                hod.HastaAdi = dr["HastaAdi"].ToString();
                hod.HastaSoyadi = dr["HastaSoyadi"].ToString();
                hod.TC = (int)dr["TCNO"];
                hod.OdaNo=(int)dr["OdaNo"];
                hod.GirişTarihi = (DateTime)dr["GirişTarihi"];
                hod.CıkısTarihi= (DateTime)dr["ÇıkışTarihi"];

            }
            dr.Dispose();
            return hod;


        }



    }
}
