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

namespace HastaneOtomasyonu.PERSONEL.Kontroller
{
    public partial class ucYeniFatura : UserControl
    {
        public ucYeniFatura()
        {
            InitializeComponent();
        }

        private void ucbilgilerigüncelle1_Load(object sender, EventArgs e)
        {

        }

       
        private void btnFaturaEkle_Click(object sender, EventArgs e)
        {

            try
            {
                FaturaBL bl = new FaturaBL();
                int id = Convert.ToInt32(txtHastaID.Text);
                HastaBL hbl = new HastaBL();
                if (id != hbl.HastaBilgileriGöster(id).Id)
                {

                    MessageBox.Show(id + "Kayıt Bulunamadı.");
                }
                else
                {
                    int faturadurum = Convert.ToInt32(cmbFaturaDurumu.SelectedValue);
                    int odemedurumu = Convert.ToInt32(cmbOdemeTuru.SelectedValue);
                    decimal fatura = Convert.ToDecimal(txtFatura.Text);
                    int sonuc = bl.YeniFaturaEkle(id, faturadurum, odemedurumu, fatura);

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Yeni Fatura Başarıyla Eklendi.");
                    }
                    else
                    {
                        MessageBox.Show("HATA");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            



        }

        private void ucYeniFatura_Load(object sender, EventArgs e)
        {

            FaturaBL bl = new FaturaBL();
            cmbFaturaDurumu.DataSource = bl.DurumTablosu();
            cmbOdemeTuru.DataSource = bl.OdemeTablosu();
            cmbOdemeTuru.ValueMember = "OdemeID";
            cmbFaturaDurumu.ValueMember = "FaturaDurumID";
            cmbFaturaDurumu.DisplayMember = "FaturaDurum2";
            cmbOdemeTuru.DisplayMember = "OdemeTürü2";
            

        }
    }
}
