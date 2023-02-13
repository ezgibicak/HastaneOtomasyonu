using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneOtomasyonu.BL;
using HastaneOtomasyonu.Entity.Dto;

namespace HastaneOtomasyonu.HASTA.Kontroller
{
    public partial class ucSonuclar : UserControl
    {
        public ucSonuclar()
        {
            InitializeComponent();
        }
        string kullanıcı;
        string sifre;
        public ucSonuclar(string Kullanici,string sifre)

        {
            this.kullanıcı = Kullanici;
            this.sifre = sifre;
            InitializeComponent();
        }
        string ad;
        string soyad;
        public ucSonuclar(string Kullanici, string sifre,string Ad,string soyad)

        {
            this.kullanıcı = Kullanici;
            this.sifre = sifre;
            this.ad = Ad;
            this.soyad = soyad;
            InitializeComponent();
        }

        private void ucSonuclar_Load(object sender, EventArgs e)
        {
            HastaBL bl = new HastaBL();
            dataGridView1.DataSource = bl.SonuclarıGetir(kullanıcı, sifre);
           

            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                HastaBL bl = new HastaBL();


                dataGridView2.DataSource = bl.SonucDurumGetir(kullanıcı, sifre, (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir Hata Oluştu."+ex);
            }
            
        }
    }
}
