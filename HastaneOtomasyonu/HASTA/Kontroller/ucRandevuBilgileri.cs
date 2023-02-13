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

namespace HastaneOtomasyonu.HASTA.Kontroller
{
    public partial class ucRandevuBilgileri : UserControl
    {
        public ucRandevuBilgileri()
        {
            InitializeComponent();
        }
        string kullanici;
        string sifre;
        public ucRandevuBilgileri(string adi,string Sifre)
        {
            this.kullanici = adi;
            this.sifre = Sifre;
            InitializeComponent();

        }
        private void ucRandevuBilgileri_Load(object sender, EventArgs e)
        {
            HastaBL bl = new HastaBL();
            KullaniciBL kbl = new KullaniciBL();
           
            dataGridView1.DataSource=bl.RandevuBilgileriGetir(kullanici,sifre, (int)kbl.HastaKullaniciGiris(kullanici,sifre).HastaID);
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Randevuyu İptal Et";
            btn.Text = "İptal";
            btn.UseColumnTextForButtonValue = true;
            //dataGridView1.Columns[0].HeaderText = "Randevu ID";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Hasta Adı";
            dataGridView1.Columns[2].HeaderText = "Hasta Soyadı";
            dataGridView1.Columns[3].HeaderText = "Bölüm Adı";
            dataGridView1.Columns[4].HeaderText = "Randevu Tarihi";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                DateTime date1 = new DateTime();
                date1 = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[5].Value);

                DateTime date2 = new DateTime();
                date2 = DateTime.Now;
                int result = DateTime.Compare(date1, date2);
                if (result < 0)
                {
                    MessageBox.Show("Randevu Tarihiniz Geçmiştir.");
                }
                else
                {
                    var senderGrid = (DataGridView)sender;

                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                    {
                        DialogResult dr = MessageBox.Show("Randevunuz İptal Olacaktır.Emin misiniz?", "DİKKAT!", MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Exclamation);
                        if (dr == DialogResult.Yes)
                        {
                            HastaBL bl = new HastaBL();

                            bl.RandevuSil((int)dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                            MessageBox.Show("İptal İşleminiz gerçekleştirildi.");
                        }
                        else
                        {


                            MessageBox.Show("İptal işleminiz gerçekleştirilmedi.");
                        }


                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!!!");
            }
            

                }
            }
        }
    
