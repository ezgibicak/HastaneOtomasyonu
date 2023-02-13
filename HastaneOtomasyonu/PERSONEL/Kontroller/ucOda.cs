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
    public partial class ucOda : UserControl
    {
        public ucOda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            odano = Convert.ToInt32(btn1.Tag);
            if (btn1.Text=="DOLU")
            {
                
                frmHastaOdaBilgileri frm = new frmHastaOdaBilgileri(odano);
                frm.Show();
            }
            else
            {
               
                HastaOdaKayıt frm = new HastaOdaKayıt(odano);
                frm.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            odano = Convert.ToInt32(btn2.Tag);
            if (btn2.Text == "DOLU")
            {

                frmHastaOdaBilgileri frm = new frmHastaOdaBilgileri(odano);
                frm.Show();
            }
            else
            {
              
                HastaOdaKayıt frm = new HastaOdaKayıt(odano);
                frm.Show();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            odano = Convert.ToInt32(btn3.Tag);
            if (btn3.Text == "DOLU")
            {

                frmHastaOdaBilgileri frm = new frmHastaOdaBilgileri(odano);
                frm.Show();
            }
            else
            {
                
                HastaOdaKayıt frm = new HastaOdaKayıt(odano);
                frm.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            odano = Convert.ToInt32(btn4.Tag);
            if (btn4.Text == "DOLU")
            {

                frmHastaOdaBilgileri frm = new frmHastaOdaBilgileri(odano);
                frm.Show();
            }
            else
            {
                
                HastaOdaKayıt frm = new HastaOdaKayıt(odano);
                frm.Show();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            odano = Convert.ToInt32(btn5.Tag);
            if (btn5.Text == "DOLU")
            {

                frmHastaOdaBilgileri frm = new frmHastaOdaBilgileri(odano);
                frm.Show();
            }
            else
            {
                
                HastaOdaKayıt frm = new HastaOdaKayıt(odano);
                frm.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            odano = Convert.ToInt32(btn6.Tag);
            if (btn6.Text == "DOLU")
            {

                frmHastaOdaBilgileri frm = new frmHastaOdaBilgileri(odano);
                frm.Show();
            }
            else
            {
                
                HastaOdaKayıt frm = new HastaOdaKayıt(odano);
                frm.Show();
            }   
        }

        private void button7_Click(object sender, EventArgs e)
        {
            odano = Convert.ToInt32(btn7.Tag);
            if (btn7.Text == "DOLU")
            {

                frmHastaOdaBilgileri frm = new frmHastaOdaBilgileri();
                frm.Show();
            }
            else
            {
                
                HastaOdaKayıt frm = new HastaOdaKayıt(odano);
                frm.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            odano = Convert.ToInt32(btn8.Tag);
            if (btn8.Text == "DOLU")
            {

                frmHastaOdaBilgileri frm = new frmHastaOdaBilgileri(odano);
                frm.Show();
            }
            else
            {
                
                HastaOdaKayıt frm = new HastaOdaKayıt(odano);
                frm.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            odano = Convert.ToInt32(btn9.Tag);
            if (btn9.Text == "DOLU")
            {

                frmHastaOdaBilgileri frm = new frmHastaOdaBilgileri(odano);
                frm.Show();
            }
            else
            {
                
                HastaOdaKayıt frm = new HastaOdaKayıt(odano);
                frm.Show();
            }
        }

        int odano;
       

        private void ucOda_Load(object sender, EventArgs e)
        {
            foreach (Button item in this.Controls)
            {
                item.BackColor = Color.Green;
            }

            foreach (Button item in this.Controls)
            {
                OdaBL bl2 = new OdaBL();
                odano = Convert.ToInt32(item.Text);
                if (bl2.OdaDurumu(odano).DurumID == 1)
                {
                    item.BackColor = Color.Gray;
                    item.Tag = item.Text;
                    item.Text = "DOLU";
                    
                   
                }
                else
                {
                    item.Tag = item.Text;
                }
            }

           



        }
    }
}
