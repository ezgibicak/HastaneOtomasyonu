using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneOtomasyonu.BL;
using HastaneOtomasyonu.HASTA;
using HastaneOtomasyonu.HASTA.Kontroller;

namespace HastaneOtomasyonu.HASTA
{
    public partial class frmHastaKayıt : Form
    {
        public frmHastaKayıt()
        {
            InitializeComponent();
        }

      

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            panel1.Controls.Clear();
          
            if (e.Node.Text=="Kayıt Bilgileri")
            {
                uckisiselbilgilerhasta kisiselbilgiler = new uckisiselbilgilerhasta();
                panel1.Controls.Add(kisiselbilgiler);
            }
            //if (e.Node.Text == "Kayıt Tamamlama")
            //{
            //    ucislemsonu islemsonu = new ucislemsonu();
            //    panel1.Controls.Add(islemsonu);
            //}
        }

        private void frmHastaKayıt_Load(object sender, EventArgs e)
        {
            Giris ugris = new Giris();
            panel1.Controls.Add(ugris);
        }

    }
}
