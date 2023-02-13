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
    public partial class ucHastaFatura : UserControl
    {
        public ucHastaFatura()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            HastaBL bl = new HastaBL();
            if (txtID.Text!=""  && txtTc.Text!="") {
                int id = Convert.ToInt32(txtID.Text);
                int tc = Convert.ToInt32(txtTc.Text);
                dataGridView1.DataSource = bl.hastafaturabilgilerigetir(id, txtAd.Text, txtSoyad.Text, tc); }

            else
            {
                dataGridView1.DataSource = bl.hastafaturabilgilerigetir(0, txtAd.Text, txtSoyad.Text, 0);
            }
        }
        

        private void ucHastaFatura_Load(object sender, EventArgs e)
        {
            HastaBL bl = new HastaBL();
            dataGridView1.DataSource=bl.hastafaturabilgilerigetir();
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            HastaBL bl = new HastaBL();
            if (txtID.Text != "" && txtTc.Text != "")
            {
                int id = Convert.ToInt32(txtID.Text);
                int tc = Convert.ToInt32(txtTc.Text);
                dataGridView1.DataSource = bl.hastafaturabilgilerigetir(id, txtAd.Text, txtSoyad.Text, tc);
            }

            else
            {
                dataGridView1.DataSource = bl.hastafaturabilgilerigetir(0, txtAd.Text, txtSoyad.Text, 0);
            }
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            HastaBL bl = new HastaBL();
            if (txtID.Text == "" && txtTc.Text != "")
            {

                int tc = Convert.ToInt32(txtTc.Text);
                dataGridView1.DataSource = bl.hastafaturabilgilerigetir(0,txtAd.Text, txtSoyad.Text, tc);
            }
            else if (txtID.Text != "" && txtTc.Text == "")
            {
                int id = Convert.ToInt32(txtID.Text);
                dataGridView1.DataSource = bl.hastafaturabilgilerigetir(id, txtAd.Text, txtSoyad.Text, 0);
            }
            else if (txtID.Text == "" && txtTc.Text == "")
            {

                dataGridView1.DataSource = bl.hastafaturabilgilerigetir(0, txtAd.Text, txtSoyad.Text, 0);
            }
            else
            {
                int id = Convert.ToInt32(txtID.Text);
                int tc = Convert.ToInt32(txtTc.Text);
                dataGridView1.DataSource = bl.hastafaturabilgilerigetir(id, txtAd.Text, txtSoyad.Text, tc);

            }


        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            HastaBL bl = new HastaBL();
            if (txtID.Text=="" && txtTc.Text!="")
            {

                int tc = Convert.ToInt32(txtTc.Text);
                dataGridView1.DataSource = bl.hastafaturabilgilerigetir(0,txtAd.Text,txtSoyad.Text,tc);
            }
            else if(txtID.Text != "" && txtTc.Text == "")
            {
                int id = Convert.ToInt32(txtID.Text);
                dataGridView1.DataSource = bl.hastafaturabilgilerigetir(id, txtAd.Text, txtSoyad.Text, 0);
            }
            else if (txtID.Text == "" && txtTc.Text == "")
            {
                
                dataGridView1.DataSource = bl.hastafaturabilgilerigetir(0, txtAd.Text, txtSoyad.Text, 0);
            }
            else
            {
                int id = Convert.ToInt32(txtID.Text);
                int tc = Convert.ToInt32(txtTc.Text);
                dataGridView1.DataSource = bl.hastafaturabilgilerigetir(id, txtAd.Text, txtSoyad.Text, tc);
                
            }
        }
    }
}
