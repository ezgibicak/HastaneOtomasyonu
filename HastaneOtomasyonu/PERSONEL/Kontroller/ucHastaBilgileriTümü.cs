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
using HastaneOtomasyonu.PERSONEL.Kontroller;

namespace HastaneOtomasyonu.PERSONEL
{
    public partial class ucHastaBilgileriTümü : UserControl
    {
        public ucHastaBilgileriTümü()
        {
            InitializeComponent();
        }

        private void ucHastaBilgileriTümü_Load(object sender, EventArgs e)
        {
            HastaBL bl = new HastaBL();
            dataGridView1.DataSource = bl.HastaBilgileriGetirTümü();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            frmHastaBilgileriGüncelle frm = new frmHastaBilgileriGüncelle((int)dataGridView1.Rows[e.RowIndex].Cells[2].Value,
                (string)dataGridView1.Rows[e.RowIndex].Cells[0].Value,
                (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value,
               (int)dataGridView1.Rows[e.RowIndex].Cells[6].Value);
            this.Hide();
            frm.Show();
        }
    }
}
