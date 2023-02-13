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
    public partial class frmHastaOdaBilgileri : Form
    {
        public frmHastaOdaBilgileri()
        {
            InitializeComponent();
        }
        int odano;
        public frmHastaOdaBilgileri(int OdaNo)
        {
            this.odano = OdaNo;
            InitializeComponent();
        }

        private void frmHastaOdaBilgileri_Load(object sender, EventArgs e)
        {
            OdaBL bl = new OdaBL();
            lblHastaID.Text=bl.OdaBilgileriGetir(odano).HastaID.ToString();
            lblHastaAdi.Text = bl.OdaBilgileriGetir(odano).HastaAdi.ToString();
            lblHastaSoyadi.Text = bl.OdaBilgileriGetir(odano).HastaSoyadi.ToString();
            lblOdaNo.Text = bl.OdaBilgileriGetir(odano).OdaNo.ToString();
            lblTcNo.Text = bl.OdaBilgileriGetir(odano).TC.ToString();
            lblGirisTarihi.Text = bl.OdaBilgileriGetir(odano).GirişTarihi.ToString();
            lblCikisTarihi.Text = bl.OdaBilgileriGetir(odano).CıkısTarihi.ToString();
        }
    }
}
