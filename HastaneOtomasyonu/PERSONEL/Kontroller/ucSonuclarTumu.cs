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
    public partial class ucSonuclarTumu : UserControl
    {
        public ucSonuclarTumu()
        {
            InitializeComponent();
        }

        private void ucSonuclarTumu_Load(object sender, EventArgs e)
        {
            HastaBL bl = new HastaBL();
            dataGridView1.DataSource = bl.SonuclarıGetir();
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HastaBL bl = new HastaBL();
            dataGridView2.DataSource = bl.SonucDurumGetir((int)dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}
