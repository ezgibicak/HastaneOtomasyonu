using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneOtomasyonu.DAL;
using System.Data;
using HastaneOtomasyonu.Entity.Domain;
using HastaneOtomasyonu.Entity.Dto;

namespace HastaneOtomasyonu.BL
{
    public class HastaBL
    {
        public object HastaKayıt(int id, string kullaniciadi, string sifre)
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            //string sorgu = "insert KullanıcıHasta(HastaID,KullaniciAdi,KullaniciSifre) values (@id,@kullaniciadi,@sifre)";
            string sorgu = "sp_HastaKullacıEkle";
            vt.ParametreEkle("@kullaniciadi", DbType.String, kullaniciadi);
            vt.ParametreEkle("@sifre", DbType.String, sifre);
            vt.ParametreEkle("@id", DbType.Int32, id);
            object sonuc = vt.ExecuteNonQueryYap(sorgu,CommandType.StoredProcedure);
            return sonuc;

        }

        public object HastaKayıtBilgileriGetir(int id, string ad, string soyad, int tc, DateTime dt, int cepno)
        {

            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            string sorgu = "insert Hasta(HastaID,HastaAdi,HastaSoyadi,TCNO,DogumTarihi,Ceptelefonu) values (@id,@ad,@soyad,@tc,@dt,@cepno)";
            //string sorgu = "insert Hasta(HastaAdi,HastaSoyadi,TCNO,DogumTarihi,Ceptelefonu) values (@ad,@soyad,@tc,@dt,@cepno)";
            vt.ParametreEkle("@ad", DbType.String, ad);
            vt.ParametreEkle("@soyad", DbType.String, soyad);
            vt.ParametreEkle("@tc", DbType.Int32, tc);
            vt.ParametreEkle("@id", DbType.Int32, id);
            vt.ParametreEkle("@cepno", DbType.Int32, cepno);
            vt.ParametreEkle("@dt", DbType.DateTime, dt);
            
            object sonuc = vt.ExecuteNonQueryYap(sorgu);
            return sonuc;

        }
        List<HastaIdyeGöre> hs = new List<HastaIdyeGöre>();

        public HastaIdyeGöre HastaBilgileriGöster(int hastaid)
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            HastaIdyeGöre hasta = null;
            string sorgu = "sp_BilgileriGetir";
            vt.ParametreEkle("@hastaid", DbType.Int32, hastaid);
            IDataReader dr = vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);

            if (dr.Read())
            {
                hasta = new HastaIdyeGöre();
                hasta.Adi = dr["HastaAdi"].ToString();
                hasta.Soyadi = dr["HastaSoyadi"].ToString();
                hasta.Boy = dr["Boy"] == DBNull.Value ? null : (decimal?)dr["Boy"];
                hasta.Kilo = dr["Kilo"] == DBNull.Value ? null : (decimal?)dr["Kilo"];
                hasta.CepNo = dr["Ceptelefonu"] == DBNull.Value ? null : (int?)dr["Ceptelefonu"];
                hasta.TCno = dr["TCNO"] == DBNull.Value ? null : (int?)dr["TCNO"];
                hasta.Dogumtarihi = dr["DogumTarihi"] == DBNull.Value ? null : (DateTime?)dr["DogumTarihi"];
                hasta.Id = (int)dr["HastaID"];
                hasta.KullaniciAdi = dr["KullaniciAdi"].ToString();
                hasta.Sifre = dr["KullaniciSifre"].ToString();
                hs.Add(hasta);

            }
            //hs.Add(hasta);
            dr.Dispose();
            return hasta;
        }

        public object HastaBilgileriGüncelle(string ad, string soyad, int tc, int id, int cepno, DateTime dt, decimal kilo, decimal boy)
        {

            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            string sorgu = "sp_BilgileriGüncelle";
            vt.ParametreEkle("@ad", DbType.String, ad);
            vt.ParametreEkle("@soyad", DbType.String, soyad);
            vt.ParametreEkle("@tcno", DbType.Int32, tc);
            vt.ParametreEkle("@id", DbType.Int32, id);
            vt.ParametreEkle("@cepno", DbType.Int32, cepno);
            vt.ParametreEkle("@dogumtarihi", DbType.DateTime, dt);
            vt.ParametreEkle("@kilo", DbType.Decimal, kilo);
            vt.ParametreEkle("@boy", DbType.Decimal, boy);
            return vt.ExecuteNonQueryYap(sorgu, CommandType.StoredProcedure);


        }


        public object HastaBilgileriGüncelle(string ad, string soyad, int tc, int id, int cepno, DateTime dt, decimal kilo, decimal boy,int kangrubuid)
        {

            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            string sorgu = "[sp_BilgileriGüncelle2]";
            vt.ParametreEkle("@ad", DbType.String, ad);
            vt.ParametreEkle("@soyad", DbType.String, soyad);
            vt.ParametreEkle("@tcno", DbType.Int32, tc);
            vt.ParametreEkle("@id", DbType.Int32, id);
            vt.ParametreEkle("@cepno", DbType.Int32, cepno);
            vt.ParametreEkle("@dogumtarihi", DbType.DateTime, dt);
            vt.ParametreEkle("@kilo", DbType.Decimal, kilo);
            vt.ParametreEkle("@boy", DbType.Decimal, boy);
            vt.ParametreEkle("@kangrubuid", DbType.Int32, kangrubuid);
            return vt.ExecuteNonQueryYap(sorgu, CommandType.StoredProcedure);


        }









        public object HastaKullanıcıBilgileriGüncelle(int id, string kullaniciadi, string sifre)
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            string sorgu = "sp_kullanicihasta";
            vt.ParametreEkle("@kullaniciadi", DbType.String, kullaniciadi);
            vt.ParametreEkle("@sifre", DbType.String, sifre);
            vt.ParametreEkle("@id", DbType.Int32, id);
            object sonuc = vt.ExecuteNonQueryYap(sorgu, CommandType.StoredProcedure);
            return sonuc;

        }
        List<RandevuBilgileri> rd = new List<RandevuBilgileri>();
        public List<RandevuBilgileri> RandevuBilgileriGetir(string kullanıcı, string sifre,int id)
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            string sorgu = "sp_randevu";
            vt.ParametreEkle("@adi", DbType.String, kullanıcı);
            vt.ParametreEkle("@sifre", DbType.String, sifre);
            vt.ParametreEkle("@hastaid", DbType.Int32, id);
            IDataReader dr = vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);
            RandevuBilgileri randevubil = null;
            while (dr.Read())
            {
                randevubil = new RandevuBilgileri();
                randevubil.RandevuID = (int)dr["RandevuID"];
                randevubil.Ad = dr["HastaAdi"].ToString();
                randevubil.Soyad = dr["HastaSoyadi"].ToString();
                randevubil.PersonelAdi = dr["PersonelAdi"].ToString();
                randevubil.PersonelSoyadi = dr["PersonelSoyadi"].ToString();
                randevubil.BolumAdi = dr["BolumAdi"].ToString();
                randevubil.Aciklama = dr["Açıklama"].ToString();
                randevubil.RandevuTarihi = (DateTime)dr["Tarih"];
                randevubil.Saat = dr["Saat"].ToString();
                rd.Add(randevubil);
            }
           
            dr.Dispose();
            return rd;
        }

         public List<RandevuBilgileri> RandevuBilgileriGetir()
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            string sorgu = "[sp_randevutümü]";
            
            IDataReader dr = vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);
            RandevuBilgileri randevubil = null;
            while (dr.Read())
            {
                randevubil = new RandevuBilgileri();
                randevubil.RandevuID = (int)dr["RandevuID"];
                randevubil.Ad = dr["HastaAdi"].ToString();
                randevubil.Soyad = dr["HastaSoyadi"].ToString();
                randevubil.PersonelAdi = dr["PersonelAdi"].ToString();
                randevubil.PersonelSoyadi = dr["PersonelSoyadi"].ToString();
                randevubil.BolumAdi = dr["BolumAdi"].ToString();
                randevubil.Aciklama = dr["Açıklama"].ToString();
                randevubil.RandevuTarihi = (DateTime)dr["Tarih"];
                randevubil.Saat = dr["Saat"].ToString();
                rd.Add(randevubil);
            }
           
            dr.Dispose();
            return rd;
        }

        public int RandevuSil(int randevuid)
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            vt.ParametreEkle("@randevuid", DbType.Int32, randevuid);
            string sorgu = "sp_RandevuSil";
            int sonuc = vt.ExecuteNonQueryYap(sorgu, CommandType.StoredProcedure);
            return sonuc;

        }

        public int RandevuAl(int personelid, int bolumid, string aciklama, DateTime tarih,int Hastaid,string saat)
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            vt.ParametreEkle("@PersonelId", DbType.Int32, personelid);
            vt.ParametreEkle("@BolumID", DbType.Int32, bolumid);
            vt.ParametreEkle("@Tarih", DbType.DateTime, tarih);
            vt.ParametreEkle("@Aciklama", DbType.String, aciklama);
            vt.ParametreEkle("@HastaID", DbType.Int32, Hastaid);
            vt.ParametreEkle("@Saat", DbType.String, saat);
            string sorgu = "[sp_RandevuAl]";
            int sonuc = vt.ExecuteNonQueryYap(sorgu, CommandType.StoredProcedure);
            return sonuc;

        }


        public SigortaBilgileri SigortaBilgileriGetir(string kullanıcı, string sifre)
        {

            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            vt.ParametreEkle("@kullanıcıadi", DbType.String, kullanıcı);
            vt.ParametreEkle("@sifre", DbType.String, sifre);
            SigortaBilgileri bilgiler = null;
            string sorgu = "sp_SigortaBilgileri";
            IDataReader dr = vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);
            if (dr.Read())
            {
                bilgiler = new SigortaBilgileri();
                bilgiler.HastaAdi = dr["HastaAdi"].ToString();
                bilgiler.HastaSoyadi = dr["HastaSoyadi"].ToString();
                bilgiler.Tc = (int)dr["TCNO"];
                bilgiler.SigortaAdi = dr["SigortaAdi"].ToString();
                bilgiler.SigortaNo = dr["SigortaNo"]==DBNull.Value?null:(int?) dr["SigortaNo"];

            }

            dr.Dispose();
            return bilgiler;



        }
        List<SonucBilgileri> liste = new List<SonucBilgileri>();
        public List<SonucBilgileri> SonuclarıGetir(string kullanıcı, string sifre)
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            vt.ParametreEkle("@kullaniciadi", DbType.String, kullanıcı);
            vt.ParametreEkle("@sifre", DbType.String, sifre);
            SonucBilgileri bilgiler = null;
            string sorgu = "sp_SonucBilgileri";
            IDataReader dr = vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);
            while (dr.Read())
            {
                bilgiler = new SonucBilgileri();
                bilgiler.Adi = dr["HastaAdi"].ToString();
                bilgiler.Soyadi = dr["HastaSoyadi"].ToString();
                bilgiler.SonucID = (int)dr["SonucID"];
                bilgiler.DogumTarihi = dr["DogumTarihi"] == DBNull.Value ? null : (DateTime?)dr["DogumTarihi"];
                bilgiler.Sonuc = dr["Sonuc"].ToString();
                bilgiler.SonucTarih = (DateTime)dr["Tarih"];
              
               
                
                liste.Add(bilgiler);
            }
            dr.Dispose();
            return liste;
        }

        public List<SonucBilgileri> SonuclarıGetir()
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
          
            SonucBilgileri bilgiler = null;
            string sorgu = "[sp_SonucBilgileriTumu]";
            IDataReader dr = vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);
            while (dr.Read())
            {
                bilgiler = new SonucBilgileri();
                bilgiler.Adi = dr["HastaAdi"].ToString();
                bilgiler.Soyadi = dr["HastaSoyadi"].ToString();
                bilgiler.SonucID = (int)dr["SonucID"];
                bilgiler.DogumTarihi = dr["DogumTarihi"] == DBNull.Value ? null : (DateTime?)dr["DogumTarihi"];
                bilgiler.Sonuc = dr["Sonuc"].ToString();
                bilgiler.SonucTarih = (DateTime)dr["Tarih"];



                liste.Add(bilgiler);
            }
            dr.Dispose();
            return liste;
        }

        List<SonucDurum> sonucdurumlistesi = new List<SonucDurum>();
        public List<SonucDurum> SonucDurumGetir(string kullanıcı, string sifre,int sonucid)
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            vt.ParametreEkle("@kullaniciadi", DbType.String, kullanıcı);
            vt.ParametreEkle("@sifre", DbType.String, sifre);
            vt.ParametreEkle("@sonucid", DbType.Int32, sonucid);
            SonucDurum bilgiler = null;
            string sorgu = "[sp_SonucDurumBilgileriGetir]";
            IDataReader dr = vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);
            while (dr.Read())
            {
                bilgiler = new SonucDurum();
                bilgiler.SoncDurumID = (int)dr["SonucDurumID"];
                bilgiler.SonucID = (int)dr["SonucID"];
                bilgiler.SonucTakip = dr["SonucTakip"].ToString();
                bilgiler.SonucTakipTarih = (DateTime)dr["SonucTakipTarih"];
                sonucdurumlistesi.Add(bilgiler);
            }
            dr.Dispose();
            return sonucdurumlistesi;
        }

        public List<SonucDurum> SonucDurumGetir(int sonucid)
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
           
            vt.ParametreEkle("@sonucid", DbType.Int32, sonucid);
            SonucDurum bilgiler = null;
            string sorgu = "[sp_SonucDurumBilgileriGetirTümü]";
            IDataReader dr = vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);
            while (dr.Read())
            {
                bilgiler = new SonucDurum();
                bilgiler.SoncDurumID = (int)dr["SonucDurumID"];
                bilgiler.SonucID = (int)dr["SonucID"];
                bilgiler.SonucTakip = dr["SonucTakip"].ToString();
                bilgiler.SonucTakipTarih = (DateTime)dr["SonucTakipTarih"];
                sonucdurumlistesi.Add(bilgiler);
            }
            dr.Dispose();
            return sonucdurumlistesi;
        }


        public int HastadanRandevuyuSil(int randevuid)
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            vt.ParametreEkle("@randevuid", DbType.Int32, randevuid);
            string sorgu = "update Hasta set RandevuID=null where Hasta.RandevuID=@randevuid";
            int sonuc = vt.ExecuteNonQueryYap(sorgu);
            return sonuc;

        }
        bool durum;
        public bool RandevuAynıKayıt(DateTime tarih,string saat,int id)
        {
            string sorgu = "sp_RandevuZatenVar";
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            vt.ParametreEkle("@tarih", DbType.DateTime, tarih);
            vt.ParametreEkle("@saat", DbType.String, saat);
            vt.ParametreEkle("@personelid", DbType.Int32, id);
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
        List<FaturaBilgileri> faturalistesi = new List<FaturaBilgileri>();
        public List<FaturaBilgileri> hastafaturabilgilerigetir(int id=0,string ad="",string soyad="",int tc=0)

        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            vt.ParametreEkle("@id", DbType.Int32, id);
            vt.ParametreEkle("@tc", DbType.Int32, tc);
            vt.ParametreEkle("@ad", DbType.String, ad);
            vt.ParametreEkle("@soyad", DbType.String, soyad);
            string sorgu = "[sp_HastaFaturaBilgileri]";
            IDataReader dr = vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);

            while (dr.Read())
            {
                FaturaBilgileri faturabilgisi = new FaturaBilgileri();
                faturabilgisi.HastaAdi = dr["HastaAdi"].ToString();
                faturabilgisi.HastaSoyadi = dr["HastaSoyadi"].ToString();
                faturabilgisi.dogumtarihi = dr["DogumTarihi"] == DBNull.Value ? null : (DateTime?)dr["DogumTarihi"];
                faturabilgisi.TC = (int)dr["TCNO"];
                faturabilgisi.SigortaAdi = dr["SigortaAdi"].ToString();
                faturabilgisi.SigortaNo = dr["SigortaNo"] == DBNull.Value ? null : (int?)dr["SigortaNo"];
                faturabilgisi.CepNo = dr["Ceptelefonu"] == DBNull.Value ? null : (int?)dr["Ceptelefonu"];
                faturabilgisi.OdemeSekli = dr["OdemeTürü"].ToString();
                faturabilgisi.Fatura = (decimal)dr["Fatura"];
                faturabilgisi.FaturaDurum = dr["FaturaDurum"].ToString();
                faturabilgisi.HastaID = (int)dr["HastaID"];
                //faturabilgisi.FaturaDurumID= (int)dr["FaturaDurumID"];
                //faturabilgisi.OdemeID = (int)dr["OdemeID"];
                faturalistesi.Add(faturabilgisi);

            }

            dr.Dispose();
            return faturalistesi;

    }

        List<HastaBilgileriTümü> hastalistesi = new List<HastaBilgileriTümü>();
        public List<HastaBilgileriTümü> HastaBilgileriGetirTümü()
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            HastaBilgileriTümü hasta = null;
            string sorgu = "sp_HastaBilgileriTümü";
            
            IDataReader dr = vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);

            while (dr.Read())
            {
                hasta = new HastaBilgileriTümü();
                hasta.Adi = dr["HastaAdi"].ToString();
                hasta.Soyadi = dr["HastaSoyadi"].ToString();
                hasta.Boy = dr["Boy"] == DBNull.Value ? null : (decimal?)dr["Boy"];
                hasta.Kilo = dr["Kilo"] == DBNull.Value ? null : (decimal?)dr["Kilo"];
                hasta.CepNo = dr["Ceptelefonu"] == DBNull.Value ? null : (int?)dr["Ceptelefonu"];
                hasta.TCno = (int)dr["TCNO"];
                hasta.Dogumtarihi = dr["DogumTarihi"] == DBNull.Value ? null : (DateTime?)dr["DogumTarihi"];
                hasta.Id = (int)dr["HastaID"];
                hasta.KanGrubuAdi = dr["KanGrubuAdi"].ToString();
                hasta.SigortaNo = (int)dr["SigortaNo"];
                hasta.SigortaAdi = dr["SigortaAdi"].ToString();
                hastalistesi.Add(hasta);

            }
            
            dr.Dispose();
            return hastalistesi;
        }
        List<HastaÇıkısBilgileri> cikislistesi = new List<HastaÇıkısBilgileri>();
        public List<HastaÇıkısBilgileri>CikisBilgileri()
        {
            VeriTabaniSaglayicisi vt = new VeriTabaniSaglayicisi();
            string sorgu = "sp_HastaCıkısBilgileri";
            IDataReader dr = vt.ExecuteReaderYap(sorgu, CommandType.StoredProcedure);
            HastaÇıkısBilgileri cikisbil = null;
            while (dr.Read())
            {
                cikisbil = new HastaÇıkısBilgileri();

                cikisbil.HastaAdi = dr["HastaAdi"].ToString();
                cikisbil.HastaSoyadi = dr["HastaSoyadi"].ToString();
                cikisbil.CepTelefonu = (int)dr["Ceptelefonu"];
                cikisbil.CıkısTarihi = (DateTime)dr["CıkısTarihi"];
                cikisbil.HastaID = (int)dr["HastaID"];
                cikisbil.FaturaID = (int)dr["FaturaID"];
                cikisbil.Fatura = (decimal)dr["Fatura"];


                cikislistesi.Add(cikisbil);
            }

            dr.Dispose();
            return cikislistesi;
        }









    }
}
