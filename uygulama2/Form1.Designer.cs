﻿namespace YazılımYapımıOdev2
{
    partial class Form1
    {
        
       
       
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gpOyunModu = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_oyun9x9 = new System.Windows.Forms.RadioButton();
            this.rb_oyun8x8 = new System.Windows.Forms.RadioButton();
            this.rb_oyun7x7 = new System.Windows.Forms.RadioButton();
            this.rb_oyun6x6 = new System.Windows.Forms.RadioButton();
            this.rb_oyun5x5 = new System.Windows.Forms.RadioButton();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.btnOyunHakkinda = new System.Windows.Forms.Button();
            this.btnOyunBitir = new System.Windows.Forms.Button();
            this.gpOyunBilgi = new System.Windows.Forms.GroupBox();
            this.lblOyunDurum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOyunModu = new System.Windows.Forms.Label();
            this.lblEnYuksekSkor = new System.Windows.Forms.Label();
            this.lblsuanSkor = new System.Windows.Forms.Label();
            this.dgOyunTahtasi = new System.Windows.Forms.DataGridView();
            this.gpOyunModu.SuspendLayout();
            this.gpOyunBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOyunTahtasi)).BeginInit();
            this.SuspendLayout();
            // 
            // gpOyunModu
            // 
            this.gpOyunModu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gpOyunModu.Controls.Add(this.label1);
            this.gpOyunModu.Controls.Add(this.rb_oyun9x9);
            this.gpOyunModu.Controls.Add(this.rb_oyun8x8);
            this.gpOyunModu.Controls.Add(this.rb_oyun7x7);
            this.gpOyunModu.Controls.Add(this.rb_oyun6x6);
            this.gpOyunModu.Controls.Add(this.rb_oyun5x5);
            this.gpOyunModu.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpOyunModu.Location = new System.Drawing.Point(142, 586);
            this.gpOyunModu.Name = "gpOyunModu";
            this.gpOyunModu.Size = new System.Drawing.Size(340, 111);
            this.gpOyunModu.TabIndex = 1;
            this.gpOyunModu.TabStop = false;
            this.gpOyunModu.Text = "Oyun Modu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lütfen Oyun Alanını Seçin:";
            // 
            // rb_oyun9x9
            // 
            this.rb_oyun9x9.AutoSize = true;
            this.rb_oyun9x9.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_oyun9x9.Location = new System.Drawing.Point(264, 72);
            this.rb_oyun9x9.Name = "rb_oyun9x9";
            this.rb_oyun9x9.Size = new System.Drawing.Size(54, 23);
            this.rb_oyun9x9.TabIndex = 4;
            this.rb_oyun9x9.TabStop = true;
            this.rb_oyun9x9.Text = "9x9";
            this.rb_oyun9x9.UseVisualStyleBackColor = true;
            this.rb_oyun9x9.CheckedChanged += new System.EventHandler(this.rb_oyun9x9_CheckedChanged);
            // 
            // rb_oyun8x8
            // 
            this.rb_oyun8x8.AutoSize = true;
            this.rb_oyun8x8.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_oyun8x8.Location = new System.Drawing.Point(196, 72);
            this.rb_oyun8x8.Name = "rb_oyun8x8";
            this.rb_oyun8x8.Size = new System.Drawing.Size(54, 23);
            this.rb_oyun8x8.TabIndex = 3;
            this.rb_oyun8x8.TabStop = true;
            this.rb_oyun8x8.Text = "8x8";
            this.rb_oyun8x8.UseVisualStyleBackColor = true;
            this.rb_oyun8x8.CheckedChanged += new System.EventHandler(this.rb_oyun8x8_CheckedChanged);
            // 
            // rb_oyun7x7
            // 
            this.rb_oyun7x7.AutoSize = true;
            this.rb_oyun7x7.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_oyun7x7.Location = new System.Drawing.Point(139, 72);
            this.rb_oyun7x7.Name = "rb_oyun7x7";
            this.rb_oyun7x7.Size = new System.Drawing.Size(54, 23);
            this.rb_oyun7x7.TabIndex = 2;
            this.rb_oyun7x7.TabStop = true;
            this.rb_oyun7x7.Text = "7x7";
            this.rb_oyun7x7.UseVisualStyleBackColor = true;
            this.rb_oyun7x7.CheckedChanged += new System.EventHandler(this.rb_oyun7x7_CheckedChanged);
            // 
            // rb_oyun6x6
            // 
            this.rb_oyun6x6.AutoSize = true;
            this.rb_oyun6x6.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_oyun6x6.Location = new System.Drawing.Point(82, 72);
            this.rb_oyun6x6.Name = "rb_oyun6x6";
            this.rb_oyun6x6.Size = new System.Drawing.Size(54, 23);
            this.rb_oyun6x6.TabIndex = 1;
            this.rb_oyun6x6.TabStop = true;
            this.rb_oyun6x6.Text = "6x6";
            this.rb_oyun6x6.UseVisualStyleBackColor = true;
            this.rb_oyun6x6.CheckedChanged += new System.EventHandler(this.rb_oyun6x6_CheckedChanged);
            // 
            // rb_oyun5x5
            // 
            this.rb_oyun5x5.AutoSize = true;
            this.rb_oyun5x5.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_oyun5x5.Location = new System.Drawing.Point(15, 72);
            this.rb_oyun5x5.Name = "rb_oyun5x5";
            this.rb_oyun5x5.Size = new System.Drawing.Size(54, 23);
            this.rb_oyun5x5.TabIndex = 0;
            this.rb_oyun5x5.TabStop = true;
            this.rb_oyun5x5.Text = "5x5";
            this.rb_oyun5x5.UseVisualStyleBackColor = true;
            this.rb_oyun5x5.CheckedChanged += new System.EventHandler(this.rb_oyun5x5_CheckedChanged);
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnYeniOyun.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOyun.Location = new System.Drawing.Point(28, 596);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(108, 34);
            this.btnYeniOyun.TabIndex = 3;
            this.btnYeniOyun.Text = "Yeni Oyun";
            this.btnYeniOyun.UseVisualStyleBackColor = false;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // btnOyunHakkinda
            // 
            this.btnOyunHakkinda.BackColor = System.Drawing.Color.Transparent;
            this.btnOyunHakkinda.ForeColor = System.Drawing.Color.Transparent;
            this.btnOyunHakkinda.Location = new System.Drawing.Point(262, 75);
            this.btnOyunHakkinda.Name = "btnOyunHakkinda";
            this.btnOyunHakkinda.Size = new System.Drawing.Size(29, 20);
            this.btnOyunHakkinda.TabIndex = 5;
            this.btnOyunHakkinda.UseVisualStyleBackColor = false;
            // 
            // btnOyunBitir
            // 
            this.btnOyunBitir.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnOyunBitir.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOyunBitir.Location = new System.Drawing.Point(28, 640);
            this.btnOyunBitir.Name = "btnOyunBitir";
            this.btnOyunBitir.Size = new System.Drawing.Size(108, 38);
            this.btnOyunBitir.TabIndex = 7;
            this.btnOyunBitir.Text = "Oyunu Bitir";
            this.btnOyunBitir.UseVisualStyleBackColor = false;
            this.btnOyunBitir.Click += new System.EventHandler(this.btnOyunBitir_Click);
            // 
            // gpOyunBilgi
            // 
            this.gpOyunBilgi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gpOyunBilgi.Controls.Add(this.lblOyunDurum);
            this.gpOyunBilgi.Controls.Add(this.label6);
            this.gpOyunBilgi.Controls.Add(this.label3);
            this.gpOyunBilgi.Controls.Add(this.label4);
            this.gpOyunBilgi.Controls.Add(this.lblOyunModu);
            this.gpOyunBilgi.Controls.Add(this.lblEnYuksekSkor);
            this.gpOyunBilgi.Controls.Add(this.lblsuanSkor);
            this.gpOyunBilgi.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpOyunBilgi.Location = new System.Drawing.Point(12, 29);
            this.gpOyunBilgi.Name = "gpOyunBilgi";
            this.gpOyunBilgi.Size = new System.Drawing.Size(508, 165);
            this.gpOyunBilgi.TabIndex = 8;
            this.gpOyunBilgi.TabStop = false;
            this.gpOyunBilgi.Text = "Oyun Bilgi";
            // 
            // lblOyunDurum
            // 
            this.lblOyunDurum.AutoSize = true;
            this.lblOyunDurum.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOyunDurum.Location = new System.Drawing.Point(201, 37);
            this.lblOyunDurum.Name = "lblOyunDurum";
            this.lblOyunDurum.Size = new System.Drawing.Size(307, 95);
            this.lblOyunDurum.TabIndex = 6;
            this.lblOyunDurum.Text = "Oyun Nasıl Oynanır?\r\nSatrançtaki atın hareketlerine\r\n yönelik hamleler yaparak \r\n" +
    "birdaha aynı kareye basmamak şartıyla \r\natılabildiği kadar hamle oynamak";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(21, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Oyun Modu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "En Yüksek Skor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şuanki Skorunuz:";
            // 
            // lblOyunModu
            // 
            this.lblOyunModu.AutoSize = true;
            this.lblOyunModu.Location = new System.Drawing.Point(155, 39);
            this.lblOyunModu.Name = "lblOyunModu";
            this.lblOyunModu.Size = new System.Drawing.Size(37, 19);
            this.lblOyunModu.TabIndex = 2;
            this.lblOyunModu.Text = "----";
            // 
            // lblEnYuksekSkor
            // 
            this.lblEnYuksekSkor.AutoSize = true;
            this.lblEnYuksekSkor.Location = new System.Drawing.Point(155, 105);
            this.lblEnYuksekSkor.Name = "lblEnYuksekSkor";
            this.lblEnYuksekSkor.Size = new System.Drawing.Size(37, 19);
            this.lblEnYuksekSkor.TabIndex = 1;
            this.lblEnYuksekSkor.Text = "----";
            // 
            // lblsuanSkor
            // 
            this.lblsuanSkor.AutoSize = true;
            this.lblsuanSkor.Location = new System.Drawing.Point(155, 72);
            this.lblsuanSkor.Name = "lblsuanSkor";
            this.lblsuanSkor.Size = new System.Drawing.Size(37, 19);
            this.lblsuanSkor.TabIndex = 0;
            this.lblsuanSkor.Text = "----";
            // 
            // dgOyunTahtasi
            // 
            this.dgOyunTahtasi.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgOyunTahtasi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgOyunTahtasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOyunTahtasi.Location = new System.Drawing.Point(28, 200);
            this.dgOyunTahtasi.MultiSelect = false;
            this.dgOyunTahtasi.Name = "dgOyunTahtasi";
            this.dgOyunTahtasi.ReadOnly = true;
            this.dgOyunTahtasi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgOyunTahtasi.RowTemplate.Height = 24;
            this.dgOyunTahtasi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgOyunTahtasi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgOyunTahtasi.Size = new System.Drawing.Size(454, 380);
            this.dgOyunTahtasi.TabIndex = 2;
            this.dgOyunTahtasi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOyunTahtasi_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(532, 743);
            this.Controls.Add(this.gpOyunBilgi);
            this.Controls.Add(this.btnOyunBitir);
            this.Controls.Add(this.btnOyunHakkinda);
            this.Controls.Add(this.btnYeniOyun);
            this.Controls.Add(this.dgOyunTahtasi);
            this.Controls.Add(this.gpOyunModu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Kare Defter Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpOyunModu.ResumeLayout(false);
            this.gpOyunModu.PerformLayout();
            this.gpOyunBilgi.ResumeLayout(false);
            this.gpOyunBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOyunTahtasi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.GroupBox gpOyunModu;
        private System.Windows.Forms.RadioButton rb_oyun8x8;
        private System.Windows.Forms.RadioButton rb_oyun7x7;
        private System.Windows.Forms.RadioButton rb_oyun6x6;
        private System.Windows.Forms.RadioButton rb_oyun5x5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_oyun9x9;
        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.Button btnOyunHakkinda;
        private System.Windows.Forms.Button btnOyunBitir;
        private System.Windows.Forms.GroupBox gpOyunBilgi;
        private System.Windows.Forms.Label lblOyunModu;
        private System.Windows.Forms.Label lblEnYuksekSkor;
        private System.Windows.Forms.Label lblsuanSkor;
        private System.Windows.Forms.Label lblOyunDurum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgOyunTahtasi;
    }
}

