using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımYapımıOdev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int OyunModu, rekorSkor = 0, hamlesayisi = 1; 

        public void OyunHazirla(int boyut) 
        {
            OyunModu = boyut;
            dgOyunTahtasi.RowCount = 9;
            dgOyunTahtasi.ColumnCount = 9;             

            for (int i = 0; i < 9; i++)
            {
                dgOyunTahtasi.Columns[i].Width = 32;        
                dgOyunTahtasi.Rows[i].Height = 32;        
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (i >= boyut || j >= boyut)
                    {
                        dgOyunTahtasi.Rows[i].Cells[j].Style.BackColor = Color.Gray;
                    }
                    else
                    {
                        dgOyunTahtasi.Rows[i].Cells[j].Style.BackColor = Color.Green;
                    }
                }
               
            }
            dgOyunTahtasi.Enabled = false;
            dgOyunTahtasi.ClearSelection();
            lblOyunModu.Text = boyut.ToString() + "x" + boyut.ToString();
            hamlesayisi = 1;
        }

        public void TahtaYenile()       
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (i >= OyunModu || j >= OyunModu)
                    {
                        dgOyunTahtasi.Rows[i].Cells[j].Style.BackColor = Color.Gray;
                    }
                    else 
                    {

                    if (dgOyunTahtasi.Rows[i].Cells[j].Value.ToString() == "") { dgOyunTahtasi.Rows[i].Cells[j].Style.BackColor = Color.Green; }
                    }
                }
            }
        }   

        private void Form1_Load(object sender, EventArgs e)
        {
            dgOyunTahtasi.Enabled = false;  
            btnOyunBitir.Enabled = false;
        }

        private void rb_oyun5x5_CheckedChanged(object sender, EventArgs e)
        {
            OyunHazirla(5);
            btnYeniOyun.Enabled = true;
        }   

        private void rb_oyun6x6_CheckedChanged(object sender, EventArgs e)
        {
            OyunHazirla(6);
            btnYeniOyun.Enabled = true;
        }   

        private void rb_oyun7x7_CheckedChanged(object sender, EventArgs e)
        {
            OyunHazirla(7);
            btnYeniOyun.Enabled = true;
        }   

        private void rb_oyun8x8_CheckedChanged(object sender, EventArgs e)
        {
            OyunHazirla(8);
            btnYeniOyun.Enabled = true;
        }   

        private void rb_oyun9x9_CheckedChanged(object sender, EventArgs e)
        {
            OyunHazirla(9);
            btnYeniOyun.Enabled = true;
        }   

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                    dgOyunTahtasi.Rows[i].Cells[j].Value = "";              

                }
            }
            dgOyunTahtasi.Enabled = true;
            gpOyunModu.Enabled = false;
            lblOyunDurum.Text = "Oyun Başladı!";           
            btnOyunBitir.Enabled = true;
            btnYeniOyun.Enabled = false;
        }

        private void btnOyunBitir_Click(object sender, EventArgs e)
        {
            OyunHazirla(0); 
            gpOyunModu.Enabled = true; 
            lblOyunDurum.Text = "Oyun Sonlandırıldı!"; 
            MessageBox.Show("Oyun Sonlandırıldı! Skorunuz : " + lblsuanSkor.Text); 
            if ((hamlesayisi -1) > rekorSkor) {rekorSkor = (hamlesayisi - 1);}          
            lblEnYuksekSkor.Text = rekorSkor.ToString();                                
            lblOyunModu.Text = lblsuanSkor.Text = "----";
            rb_oyun5x5.Checked = rb_oyun6x6.Checked = rb_oyun7x7.Checked = rb_oyun8x8.Checked = rb_oyun9x9.Checked = false; 
            btnYeniOyun.Enabled = false;
            btnOyunBitir.Enabled = false;
            dgOyunTahtasi.ClearSelection(); 

        }

       
        public DataGridViewCell hamle1;
        public DataGridViewCell hamle2;
        public DataGridViewCell hamle3;
        public DataGridViewCell hamle4;
        public DataGridViewCell hamle5;            
        public DataGridViewCell hamle6;
        public DataGridViewCell hamle7;
        public DataGridViewCell hamle8;

        private void dgOyunTahtasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hucreSatir = e.RowIndex;
            int hucreSutun = e.ColumnIndex;

            DataGridViewCell tiklananhucre = dgOyunTahtasi.Rows[hucreSatir].Cells[hucreSutun];


            
            hamle1 = hamle2 = hamle3 = hamle4 = hamle4 = hamle5 = hamle6 = hamle7 = hamle8 = null;
            try
            {
                if (dgOyunTahtasi.Rows[hucreSatir - 1].Cells[hucreSutun - 2] != null) { hamle1 = dgOyunTahtasi.Rows[hucreSatir - 1].Cells[hucreSutun - 2]; }
            }
            catch
            {
                
            }

            try
            {
                if (dgOyunTahtasi.Rows[hucreSatir - 1].Cells[hucreSutun + 2] != null) { hamle2 = dgOyunTahtasi.Rows[hucreSatir - 1].Cells[hucreSutun + 2]; }
            }
            catch
            {
                
            }

            try
            {
                if (dgOyunTahtasi.Rows[hucreSatir + 1].Cells[hucreSutun - 2] != null) { hamle3 = dgOyunTahtasi.Rows[hucreSatir + 1].Cells[hucreSutun - 2]; }
            }
            catch
            {
                
            }

            try
            {
                if (dgOyunTahtasi.Rows[hucreSatir + 1].Cells[hucreSutun + 2] != null) { hamle4 = dgOyunTahtasi.Rows[hucreSatir + 1].Cells[hucreSutun + 2]; }
            }
            catch
            {
              
            }

            try
            {
                if (dgOyunTahtasi.Rows[hucreSatir -2].Cells[hucreSutun - 1] != null) { hamle5 = dgOyunTahtasi.Rows[hucreSatir - 2].Cells[hucreSutun - 1]; }
            }
            catch
            {
                
            }

            try
            {
                if (dgOyunTahtasi.Rows[hucreSatir - 2].Cells[hucreSutun + 1] != null) { hamle6 = dgOyunTahtasi.Rows[hucreSatir - 2].Cells[hucreSutun + 1]; }
            }
            catch
            {
                
            }

            try
            {
                if (dgOyunTahtasi.Rows[hucreSatir + 2].Cells[hucreSutun - 1] != null) { hamle7 = dgOyunTahtasi.Rows[hucreSatir + 2].Cells[hucreSutun - 1]; }
            }
            catch
            {
               
            }

            try
            {
                if (dgOyunTahtasi.Rows[hucreSatir + 2].Cells[hucreSutun + 1] != null) { hamle8 = dgOyunTahtasi.Rows[hucreSatir + 2].Cells[hucreSutun + 1]; }
            }
            catch
            {
               
            }

            if ((tiklananhucre.Style.BackColor == Color.Green) && (hamlesayisi==1))  
            {
                    tiklananhucre.Value = hamlesayisi++;
                    TahtaYenile();
                    if (hamle1 != null && hamle1.Style.BackColor != Color.Gray) { hamle1.Style.BackColor = Color.Red; }
                    if (hamle2 != null && hamle2.Style.BackColor != Color.Gray) { hamle2.Style.BackColor = Color.Red; }
                    if (hamle3 != null && hamle3.Style.BackColor != Color.Gray) { hamle3.Style.BackColor = Color.Red; }
                    if (hamle4 != null && hamle4.Style.BackColor != Color.Gray) { hamle4.Style.BackColor = Color.Red; }
                    if (hamle5 != null && hamle5.Style.BackColor != Color.Gray) { hamle5.Style.BackColor = Color.Red; }
                    if (hamle6 != null && hamle6.Style.BackColor != Color.Gray) { hamle6.Style.BackColor = Color.Red; }
                    if (hamle7 != null && hamle7.Style.BackColor != Color.Gray) { hamle7.Style.BackColor = Color.Red; }
                    if (hamle8 != null && hamle8.Style.BackColor != Color.Gray) { hamle8.Style.BackColor = Color.Red; }

            }
            else if((tiklananhucre.Style.BackColor == Color.Red) && (tiklananhucre.Value != null) && (hamlesayisi > 1)) 
            {

                TahtaYenile();
                    
                try
                {
                    if ( hamle1.Value.ToString() == "" && hamle1 != null && hamle1.Style.BackColor != Color.Gray) { hamle1.Style.BackColor = Color.Red; }
                }
                catch
                {
                   
                }

                try
                {
                    if (hamle2.Value.ToString() == "" && hamle2 != null && hamle2.Style.BackColor != Color.Gray) { hamle2.Style.BackColor = Color.Red; }
                }
                catch
                {
                    
                }

                try
                {
                    if (hamle3.Value.ToString() == "" && hamle3 != null && hamle3.Style.BackColor != Color.Gray) { hamle3.Style.BackColor = Color.Red; }
                }
                catch
                {
                    
                }

                try
                {
                    if (hamle4.Value.ToString() == "" && hamle4 != null && hamle4.Style.BackColor != Color.Gray) { hamle4.Style.BackColor = Color.Red; }
                }
                catch
                {
                    
                }

                try
                {
                    if (hamle5.Value.ToString() == "" && hamle5 != null && hamle5.Style.BackColor != Color.Gray) { hamle5.Style.BackColor = Color.Red; }
                }
                catch
                {
                   
                }

                try
                {
                    if (hamle6.Value.ToString() == "" && hamle6 != null && hamle6.Style.BackColor != Color.Gray) { hamle6.Style.BackColor = Color.Red; }
                }
                catch
                {
                   
                }

                try
                {
                    if (hamle7.Value.ToString() == "" && hamle7 != null && hamle7.Style.BackColor != Color.Gray) { hamle7.Style.BackColor = Color.Red; }
                }
                catch
                {
                    
                }

                try
                {
                    if (hamle8.Value.ToString() == "" && hamle8 != null && hamle8.Style.BackColor != Color.Gray) { hamle8.Style.BackColor = Color.Red; }
                }
                catch
                {
                   
                }


                tiklananhucre.Value = hamlesayisi++;

                }
            
            else
            {
                if (hucreSatir > OyunModu-1 || hucreSutun > OyunModu - 1)
                {
                    MessageBox.Show("Lütfen Oyun Alanının Dışına Çıkmayın!");
                }
                else
                {
                    MessageBox.Show("Lütfen Kırmızı Renkler ile Devam Edin!");
                }
            }
            dgOyunTahtasi.ClearSelection();
            lblsuanSkor.Text = (hamlesayisi-1).ToString();
            if ((hamlesayisi - 1) > rekorSkor) { rekorSkor = (hamlesayisi - 1); }
            lblEnYuksekSkor.Text = rekorSkor.ToString();
        }

        
    }
}