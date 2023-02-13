using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneOtomasyonu.DAL;
using System.Data;
using HastaneOtomasyonu.Entity;
using HastaneOtomasyonu.Entity.Domain;



namespace HastaneOtomasyonu.BL
{
    public class KullaniciBL
    {

        public KullaniciPersonel PersonelKullaniciGiris(string kullaniciadi,string sifre)
        {

           string sorgu = "sp_PersonelKullaniciGiris";
            KullaniciPersonel kp = null;
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            vt.ParametreEkle("@kullaniciadi", DbType.String, kullaniciadi);
            vt.ParametreEkle("@sifre", DbType.String, sifre);
            IDataReader dr =vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);

            if (dr.Read())
            {
                kp = new KullaniciPersonel();
                kp.KullaniciAdi = dr["KullanıcıAdi"].ToString();
                kp.Sifre = dr["Sifre"].ToString();
                kp.KullaniciID = (int)dr["KullanıcıID"];
                kp.PersonelID = (int)dr["PersonelID"];
                kp.Aktiflik = dr["Aktiflik"]==DBNull.Value?null: (int?)dr["Aktiflik"];

            }
            dr.Dispose();
                return kp;
            

        }

        public KullaniciHasta HastaKullaniciGiris(string kullaniciadi,string sifre)
        {
           
                VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
                KullaniciHasta kullanici = null;
                vt.ParametreEkle("@kullaniciadi", DbType.String, kullaniciadi);
                vt.ParametreEkle("@sifre", DbType.String, sifre);
                string sorgu = "sp_kullanicihastagiris";
                IDataReader dr = vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);
                if (dr.Read())
                {
                    kullanici = new KullaniciHasta();
                    kullanici.KullaniciAdi = dr["KullaniciAdi"].ToString();
                    kullanici.KullaniciSifre = dr["KullaniciSifre"].ToString();
                    kullanici.KullaniciID = (int)dr["KullaniciID"];
                    kullanici.HastaID = (int)dr["HastaID"];


                }
                dr.Dispose();
                return kullanici;
           
        }
        bool durum;
        public bool AynıKayıt(string kullaniciadi,string sifre,int id)
        {
            string sorgu = "sp_KullaniciKayıtVar";
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            vt.ParametreEkle("@kullanici", DbType.String, kullaniciadi);
            vt.ParametreEkle("@sifre", DbType.String, sifre);
            vt.ParametreEkle("@id", DbType.Int32, id);
            IDataReader dr = vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);
            if (dr.Read())
            {
                durum = false;

            }
            else
            {
                durum = true;
            }
            dr.Dispose();
            return durum;
            

        }



        public bool AynıKayıt(string kullaniciadi, string sifre)
        {
            string sorgu = "[sp_KullaniciKayıtVarPersonel]";
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            vt.ParametreEkle("@kullanici", DbType.String, kullaniciadi);
            vt.ParametreEkle("@sifre", DbType.String, sifre);

            IDataReader dr = vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);
            if (dr.Read())
            {
                durum = false;

            }
            else
            {
                durum = true;
            }
            dr.Dispose();
            return durum;


        }
    }
}
