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

namespace HastaneOtomasyonu.HASTA
{
    public partial class ucCalisanPersoneller : UserControl
    {
        public ucCalisanPersoneller()
        {
            InitializeComponent();
        }

        private void ucCalisanPersoneller_Load(object sender, EventArgs e)
        {
            PersonelBL bl = new PersonelBL();

            dataGridView1.DataSource = bl.PersonelBilgileriGetir();
            DataGridViewDüzenle();
        }

        private void DataGridViewDüzenle()
        {
            dataGridView1.Columns["MeslekID"].Visible = false;
            dataGridView1.Columns["TcNo"].Visible = false;
            dataGridView1.Columns["AdresID"].Visible = false;
            dataGridView1.Columns["Fotograf"].Visible = false;
            dataGridView1.Columns["FotografYolu"].Visible = false;
            dataGridView1.Columns["CinsiyetID"].Visible = false;
            dataGridView1.Columns["PersonelSoyadi"].Visible = false;
            dataGridView1.Columns["PersonelAdi"].HeaderText = "Personel Adı Soyadı";
           // dataGridView1.Columns["PersonelSoyadi"].HeaderText = "Personel Soyadı";
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonelBL bl = new PersonelBL();
            int yil = cmbYillar.SelectedItem.ToString() == "Tümü" ? 0 : Convert.ToInt32(cmbYillar.SelectedItem);
            string ad = txtAdSoyad.Text;
            dataGridView1.DataSource = bl.PersonelBilgileriGetir(yil, ad);
        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
            PersonelBL bl = new PersonelBL();
            int yil = cmbYillar.SelectedItem.ToString() == "Tümü" ? 0 : Convert.ToInt32(cmbYillar.SelectedItem);
            string ad = txtAdSoyad.Text;
            dataGridView1.DataSource = bl.PersonelBilgileriGetir(yil, ad);
        }
    }
}
