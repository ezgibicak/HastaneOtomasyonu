using HastaneOtomasyonu.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu.PERSONEL
{
    public partial class HastaOdaKayıt : Form
    {
        public HastaOdaKayıt()
        {
            InitializeComponent();
        }
        int no;
        public HastaOdaKayıt(int No)
        {
            this.no = No;
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            try
            {

                OdaBL obl = new OdaBL();
                HastaBL bl = new HastaBL();
                int id = Convert.ToInt32(txtHastaId.Text);
                int sonuc = obl.HastaOdaKayıt(id, no, gtarih, ctarih);
                if (sonuc > 0)
                {
                    MessageBox.Show("Oda Kayıt İşlemi Gerçekleştirildi.");
                    obl.HastaOdaDurumuDeğiştir(no, 1);
                }
                else
                {
                    MessageBox.Show("HATA!");
                    MessageBox.Show(id + "Kayıt Bulunamamıştır.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex+"");
            }
            

            

        }

        private void HastaOdaKayıt_Load(object sender, EventArgs e)
        {
            txtOdaNo.Text = no + "";
            txtOdaNo.Enabled = false;
        }
        DateTime gtarih;

        private void mntGirisTarihi_DateChanged(object sender, DateRangeEventArgs e)
        {
            string Yil = e.Start.Year.ToString();
            string Ay = e.Start.Month.ToString();
            string Gun = e.Start.Day.ToString();
            gtarih = Convert.ToDateTime(Gun + "/" + Ay + "/" + Yil);
        }
        DateTime ctarih;
        private void mntCikisTarihi_DateChanged(object sender, DateRangeEventArgs e)
        {
            string Yil = e.Start.Year.ToString();
            string Ay = e.Start.Month.ToString();
            string Gun = e.Start.Day.ToString();
            ctarih = Convert.ToDateTime(Gun + "/" + Ay + "/" + Yil);
        }
    }
}
