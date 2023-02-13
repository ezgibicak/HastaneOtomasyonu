using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HastaneOtomasyonu.DAL;
using HastaneOtomasyonu.Entity.Domain;
using HastaneOtomasyonu.Entity;

namespace HastaneOtomasyonu.BL
{
    public class HastaneBL
    {
        public int SiraYazdir(int sırano,int bolumid)
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            vt.ParametreEkle("@sirano", DbType.Int32, sırano);
            vt.ParametreEkle("@bolumid", DbType.Int32, bolumid);
            string sorgu = "sp_SıraYazdır";
            int sonuc=vt.ExecuteNonQueryYap(sorgu, CommandType.StoredProcedure);
            return sonuc;
            
            

        }

        public int HastaIlkKayıt(int id,int siraid,DateTime tarih,string saglıksorunu)
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            vt.ParametreEkle("@id", DbType.Int32, id);
            vt.ParametreEkle("@siraid", DbType.Int32, siraid);
            vt.ParametreEkle("@tarih", DbType.DateTime, tarih);
            vt.ParametreEkle("@saglıksorunu", DbType.String, saglıksorunu);
            string sorgu = "sp_HastaİlkKayıt";
            int sonuc = vt.ExecuteNonQueryYap(sorgu, CommandType.StoredProcedure);
            return sonuc;



        }
        List<KanGrubu> kangrubulistesi = new List<KanGrubu>();
        public List<KanGrubu> KanGrubu()
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            KanGrubu kn;
            string sorgu = "sp_kangrubu";
            IDataReader dr = vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);
            while (dr.Read())
            {
                kn = new KanGrubu();
                kn.KanGrubuAdi = dr["KanGrubuAdi"].ToString();
                kn.KanGrubuID = (int)dr["KanGrubuID"];
                kangrubulistesi.Add(kn);

            }
            dr.Dispose();
            return kangrubulistesi;



        }




        List<Adres> adreslistesi = new List<Adres>();
        public List<Adres> AdresBilgileri()
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            Adres adres;
            string sorgu = "select * from Adres";
            IDataReader dr = vt.ExecuteReaderYap(sorgu);
            while (dr.Read())
            {
                adres = new Adres();
                adres.AdresID = (int)dr["AdresID"];
                adres.Adresi = dr["Adres"].ToString();
                adreslistesi.Add(adres);

            }
            dr.Dispose();
            return adreslistesi;



        }



        List<Cinsiyet> liste = new List<Cinsiyet>();
        public List<Cinsiyet> CinsiyetBilgileri()
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            Cinsiyet cinsiyet;
            string sorgu = "select * from Cinsiyet";
            IDataReader dr = vt.ExecuteReaderYap(sorgu);
            while (dr.Read())
            {
                cinsiyet = new Cinsiyet();
                cinsiyet.CinsiyetID = (int)dr["CinsiyetID"];
                cinsiyet.Cinsiyeti = dr["Cinsiyet"].ToString();
                liste.Add(cinsiyet);

            }
            dr.Dispose();
            return liste;



        }



        List<Meslek> mesleklistesi = new List<Meslek>();
        public List<Meslek> MeslekBilgileri()
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            Meslek meslegi;
            string sorgu = "select * from Meslek";
            IDataReader dr = vt.ExecuteReaderYap(sorgu);
            while (dr.Read())
            {
                meslegi = new Meslek();
                meslegi.MeslekID = (int)dr["MeslekID"];
                meslegi.Meslegi = dr["Meslek"].ToString();
                mesleklistesi.Add(meslegi);

            }
            dr.Dispose();
            return mesleklistesi;



        }
    }
}
