namespace Musteri_class_app
{
    partial class Anasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txturunAd = new System.Windows.Forms.TextBox();
            this.txturunAded = new System.Windows.Forms.TextBox();
            this.txturunFiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnurunEkle = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUrunFiyat = new System.Windows.Forms.Label();
            this.lblUrunAded = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(420, 229);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnurunEkle);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txturunFiyat);
            this.tabPage1.Controls.Add(this.txturunAded);
            this.tabPage1.Controls.Add(this.txturunAd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(412, 203);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürün kayıt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.lblUrunAded);
            this.tabPage2.Controls.Add(this.lblUrunFiyat);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(412, 203);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ürünler";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // txturunAd
            // 
            this.txturunAd.Location = new System.Drawing.Point(162, 61);
            this.txturunAd.Name = "txturunAd";
            this.txturunAd.Size = new System.Drawing.Size(100, 20);
            this.txturunAd.TabIndex = 0;
            // 
            // txturunAded
            // 
            this.txturunAded.Location = new System.Drawing.Point(162, 102);
            this.txturunAded.Name = "txturunAded";
            this.txturunAded.Size = new System.Drawing.Size(100, 20);
            this.txturunAded.TabIndex = 0;
            // 
            // txturunFiyat
            // 
            this.txturunFiyat.Location = new System.Drawing.Point(162, 148);
            this.txturunFiyat.Name = "txturunFiyat";
            this.txturunFiyat.Size = new System.Drawing.Size(100, 20);
            this.txturunFiyat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adedi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ürün Fiyatı";
            // 
            // btnurunEkle
            // 
            this.btnurunEkle.Location = new System.Drawing.Point(295, 92);
            this.btnurunEkle.Name = "btnurunEkle";
            this.btnurunEkle.Size = new System.Drawing.Size(92, 39);
            this.btnurunEkle.TabIndex = 2;
            this.btnurunEkle.Text = "Ürün ekle";
            this.btnurunEkle.UseVisualStyleBackColor = true;
            this.btnurunEkle.Click += new System.EventHandler(this.btnurunEkle_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(180, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fiyatı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Adedi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 2;
            // 
            // lblUrunFiyat
            // 
            this.lblUrunFiyat.AutoSize = true;
            this.lblUrunFiyat.Location = new System.Drawing.Point(163, 88);
            this.lblUrunFiyat.Name = "lblUrunFiyat";
            this.lblUrunFiyat.Size = new System.Drawing.Size(16, 13);
            this.lblUrunFiyat.TabIndex = 3;
            this.lblUrunFiyat.Text = "...";
            // 
            // lblUrunAded
            // 
            this.lblUrunAded.AutoSize = true;
            this.lblUrunAded.Location = new System.Drawing.Point(164, 128);
            this.lblUrunAded.Name = "lblUrunAded";
            this.lblUrunAded.Size = new System.Drawing.Size(16, 13);
            this.lblUrunAded.TabIndex = 3;
            this.lblUrunAded.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ürün Seç";
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 228);
            this.Controls.Add(this.tabControl1);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnurunEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txturunFiyat;
        private System.Windows.Forms.TextBox txturunAded;
        private System.Windows.Forms.TextBox txturunAd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblUrunAded;
        private System.Windows.Forms.Label lblUrunFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}