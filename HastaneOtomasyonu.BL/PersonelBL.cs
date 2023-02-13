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
    public class PersonelBL
    {

        
        VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
        public object PersonelKayit(int id,string Adi,string Soyadi,int tc,int cepno,DateTime dogumtarihi,DateTime isebaslama)
        {
            
            string sorgu = "insert Personel(PersonelID,PersonelAdi,PersonelSoyadi,TcNo,CepTelefonu,DogumTarihi,İseBaslamaTarihi) values (@ID,@adi,@soyadi,@tc,@cepno,@dogumtarihi,@isebaslama)";
            vt.ParametreEkle("@adi", DbType.String, Adi);
            vt.ParametreEkle("@ID", DbType.Int32,id);
            vt.ParametreEkle("@soyadi", DbType.String, Soyadi);
            vt.ParametreEkle("@tc", DbType.Int32, tc);
            vt.ParametreEkle("@cepno", DbType.Int32, cepno);
            vt.ParametreEkle("@dogumtarihi", DbType.DateTime, dogumtarihi);
            vt.ParametreEkle("@isebaslama", DbType.DateTime, isebaslama);
            object sonuc = vt.ExecuteNonQueryYap(sorgu);
            return sonuc;
        }

        public object personelkullanıcıkayıt(int id,string kullaniciadi,string sifre,int aktiflik)
        {
            string sorgu= "insert KullanıcıPersonel(KullanıcıAdi,Sifre,Aktiflik,PersonelID) values (@adi,@sifre,@aktif,@id)";
            vt.ParametreEkle("@id", DbType.Int32, id);
            vt.ParametreEkle("@adi", DbType.String, kullaniciadi);
            vt.ParametreEkle("@sifre", DbType.String, sifre);
            vt.ParametreEkle("@aktif", DbType.Int32, aktiflik);
            object sonuc= vt.ExecuteNonQueryYap(sorgu);
            return sonuc;
        }

        List<Personel> personellistesi = new List<Personel>();
        public List<Personel> PersonelGetir()
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            Personel prs = null;
            string sorgu = "sp_PersonelGetirTümü";
            IDataReader dr=vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);
            while (dr.Read())
            {
                prs = new Personel();
                //prs.PersonelAdi = dr["PersonelAdi"].ToString();
                //prs.PersonelSoyadi = dr["PersonelSoyadi"].ToString();
                prs.PersonelAdi = dr["AdSoyad"].ToString();
                prs.PersonelID = (int)dr["PersonelID"];
                prs.MeslekID = dr["MeslekID"]==DBNull.Value?null:(int?) dr["MeslekID"];
                prs.TcNo = (int)dr["TcNo"];
                prs.İseBaslamaTarihi= dr["İseBaslamaTarihi"] == DBNull.Value ? null : (DateTime?)dr["İseBaslamaTarihi"];
                prs.AdresID= dr["AdresID"] == DBNull.Value ? null : (int?)dr["AdresID"];
                prs.CepTelefonu=dr["CepTelefonu"] == DBNull.Value ? null : (int?)dr["CepTelefonu"];
                prs.CinsiyetID= dr["CinsiyetID"] == DBNull.Value ? null : (int?)dr["CinsiyetID"];
                prs.DogumTarihi = dr["DogumTarihi"] == DBNull.Value ? null : (DateTime?)dr["DogumTarihi"];
                prs.EvTelefonu= dr["EvTelefonu"] == DBNull.Value ? null : (int?)dr["EvTelefonu"];
               // prs.Fotograf = (byte[])dr["Fotograf"];
               // prs.FotografYolu = dr["FotografYolu"].ToString();

                personellistesi.Add(prs);
               
            }
            dr.Dispose();
            return personellistesi;
        }


        List<PersonelBilgileri> personelbilgileri = new List<PersonelBilgileri>();
        public List<PersonelBilgileri> PersonelBilgileriGetir(int yıl=0,string adsoyad="")
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            vt.ParametreEkle("@yil", DbType.Int32, yıl);
            vt.ParametreEkle("@adsoyad", DbType.String, adsoyad);
            PersonelBilgileri prs = null;
            string sorgu = "sp_PersonelGetir";
            IDataReader dr = vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);
            while (dr.Read())
            {
                prs = new PersonelBilgileri();
                //prs.PersonelAdi = dr["PersonelAdi"].ToString();
                //prs.PersonelSoyadi = dr["PersonelSoyadi"].ToString();
                prs.PersonelAdi = dr["AdSoyad"].ToString();
                prs.PersonelID = (int)dr["PersonelID"];
                prs.MeslekID = dr["MeslekID"] == DBNull.Value ? null : (int?)dr["MeslekID"];
                prs.TcNo = (int)dr["TcNo"];
                prs.İseBaslamaTarihi = dr["İseBaslamaTarihi"] == DBNull.Value ? null : (DateTime?)dr["İseBaslamaTarihi"];
                prs.AdresID = dr["AdresID"] == DBNull.Value ? null : (int?)dr["AdresID"];
                prs.CepTelefonu = dr["CepTelefonu"] == DBNull.Value ? null : (int?)dr["CepTelefonu"];
                prs.CinsiyetID = dr["CinsiyetID"] == DBNull.Value ? null : (int?)dr["CinsiyetID"];
                prs.DogumTarihi = dr["DogumTarihi"] == DBNull.Value ? null : (DateTime?)dr["DogumTarihi"];
                prs.BolumAdi = dr["BolumAdi"].ToString();
                prs.Meslek = dr["Meslek"].ToString();
                // prs.Fotograf = (byte[])dr["Fotograf"];
                // prs.FotografYolu = dr["FotografYolu"].ToString();

                personelbilgileri.Add(prs);

            }
            dr.Dispose();
            return personelbilgileri;
        }

        public Personel PersonelBilgileriGetir(int perid)
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            vt.ParametreEkle("@personelid", DbType.Int32, perid);
            
            Personel prs = null;
            string sorgu = "sp_PersonelBilgileriGetir";
            IDataReader dr = vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);
            while (dr.Read())
            {
                prs = new Personel();
                prs.PersonelAdi = dr["PersonelAdi"].ToString();
                prs.PersonelSoyadi = dr["PersonelSoyadi"].ToString();
                //prs.PersonelAdi = dr["AdSoyad"].ToString();
                prs.PersonelID = (int)dr["PersonelID"];
                prs.MeslekID = dr["MeslekID"] == DBNull.Value ? null : (int?)dr["MeslekID"];
                prs.TcNo = (int)dr["TcNo"];
                prs.İseBaslamaTarihi = dr["İseBaslamaTarihi"] == DBNull.Value ? null : (DateTime?)dr["İseBaslamaTarihi"];
                prs.AdresID = dr["AdresID"] == DBNull.Value ? null : (int?)dr["AdresID"];
                prs.CepTelefonu = dr["CepTelefonu"] == DBNull.Value ? null : (int?)dr["CepTelefonu"];
                prs.CinsiyetID = dr["CinsiyetID"] == DBNull.Value ? null : (int?)dr["CinsiyetID"];
                prs.DogumTarihi = dr["DogumTarihi"] == DBNull.Value ? null : (DateTime?)dr["DogumTarihi"];
                //prs.BolumAdi = dr["BolumAdi"].ToString();
                prs.Meslek = dr["Meslek"].ToString();
                prs.Cinsiyet = dr["Cinsiyet"].ToString();
                prs.Adres = dr["Adres"].ToString();
                //prs.Fotograf = (byte[])dr["Fotograf"];
                prs.FotografYolu = dr["FotografYolu"].ToString();

               

            }
            dr.Dispose();
            return prs;
        }


        public int PersonelHasta(int hastaid,int personelid)
        {
            string sorgu = "sp_PersonelHasta";
            vt.ParametreEkle("@hastaid", DbType.Int32, hastaid);
            vt.ParametreEkle("@personelid", DbType.Int32, personelid);
            
            int sonuc = vt.ExecuteNonQueryYap(sorgu,CommandType.StoredProcedure);
            return sonuc;
        }


        public object PersonelBilgileriGüncelle(string ad, string soyad, int tc, int id, int cepno, DateTime dt,DateTime tarih, int adresid,int 
            meslekid,int cinsiyetid,string FotografYolu, byte[] Fotograf)
        {

            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            string sorgu = "[sp_PersonelBilgileriGüncelle]";
            vt.ParametreEkle("@ad", DbType.String, ad);
            vt.ParametreEkle("@soyad", DbType.String, soyad);
            vt.ParametreEkle("@tcno", DbType.Int32, tc);
            vt.ParametreEkle("@id", DbType.Int32, id);
            vt.ParametreEkle("@cepno", DbType.Int32, cepno);
            vt.ParametreEkle("@dogumtarihi", DbType.DateTime, dt);
            vt.ParametreEkle("@tarih", DbType.DateTime, tarih);
            vt.ParametreEkle("@adresid", DbType.Int32, adresid);
            vt.ParametreEkle("@meslekid", DbType.Int32, meslekid);
            vt.ParametreEkle("@cinsiyetid", DbType.Int32, cinsiyetid);
            vt.ParametreEkle("@fotografyolu", DbType.String, FotografYolu);
            vt.ParametreEkle("@foto", DbType.Binary, Fotograf);
            return vt.ExecuteNonQueryYap(sorgu, CommandType.StoredProcedure);


        }


        public object PersonelBilgileriGüncelle(string ad, string soyad, int tc, int id, int cepno, DateTime dt, DateTime tarih, int adresid, int
       meslekid, int cinsiyetid, string FotografYolu)
        {

            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            string sorgu = "[sp_PersonelBilgileriGüncelle2]";
            vt.ParametreEkle("@ad", DbType.String, ad);
            vt.ParametreEkle("@soyad", DbType.String, soyad);
            vt.ParametreEkle("@tcno", DbType.Int32, tc);
            vt.ParametreEkle("@id", DbType.Int32, id);
            vt.ParametreEkle("@cepno", DbType.Int32, cepno);
            vt.ParametreEkle("@dogumtarihi", DbType.DateTime, dt);
            vt.ParametreEkle("@tarih", DbType.DateTime, tarih);
            vt.ParametreEkle("@adresid", DbType.Int32, adresid);
            vt.ParametreEkle("@meslekid", DbType.Int32, meslekid);
            vt.ParametreEkle("@cinsiyetid", DbType.Int32, cinsiyetid);
            vt.ParametreEkle("@fotografyolu", DbType.String, FotografYolu);
           // vt.ParametreEkle("@foto", DbType.Binary, Fotograf);
            return vt.ExecuteNonQueryYap(sorgu, CommandType.StoredProcedure);


        }



        //public int PersonelGuncelle(Personel p)
        //{

        //    VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();

        //    string sorgu = "sp_PersonelBilgileriGüncelle";
        //    vt.ParametreEkle("@id", DbType.Int32, p.PersonelID);
        //    vt.ParametreEkle("@cepno", DbType.Int32, p.CepTelefonu);
        //    vt.ParametreEkle("@dogumtarihi", DbType.DateTime, p.DogumTarihi);
        //    vt.ParametreEkle("@ad", DbType.String, p.PersonelAdi);
        //    vt.ParametreEkle("@soyad", DbType.String, p.PersonelSoyadi);
        //    vt.ParametreEkle("@adresid", DbType.Int32, p.AdresID);
        //    vt.ParametreEkle("@meslekid", DbType.Int32, p.MeslekID);
        //    vt.ParametreEkle("@cinsiyetid", DbType.Int32,p.CinsiyetID);
        //    vt.ParametreEkle("@tcno", DbType.Int32, p.TcNo);
        //    vt.ParametreEkle("@tarih", DbType.DateTime, p.İseBaslamaTarihi);
        //    vt.ParametreEkle("@fotografyolu", DbType.String, p.FotografYolu);
        //    vt.ParametreEkle("@fotograf", DbType.Binary, p.Fotograf);


        //    return vt.ExecuteNonQueryYap(sorgu, CommandType.StoredProcedure);

        //}


    }
}

