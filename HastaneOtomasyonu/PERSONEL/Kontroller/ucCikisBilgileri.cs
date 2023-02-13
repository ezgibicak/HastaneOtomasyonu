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
    public partial class ucCikisBilgileri : UserControl
    {
        public ucCikisBilgileri()
        {
            InitializeComponent();
        }

        private void ucCikisBilgileri_Load(object sender, EventArgs e)
        {
            HastaBL bl = new HastaBL();
            dataGridView1.DataSource = bl.CikisBilgileri();
        }
    }
}
