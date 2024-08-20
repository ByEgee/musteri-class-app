using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Musteri_class_app
{
    public partial class Anasayfa : Form
    {
        List<urunler> urunListesi;
        public Anasayfa()
        {
            InitializeComponent();

        }
        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
        private void btnurunEkle_Click(object sender, EventArgs e)
        {
            urunListesi = new List<urunler>();
            urunler urunler = new urunler();
            urunler.urunadi = txturunAd.Text;
            urunler.urunadedi = int.Parse(txturunAded.Text);
            urunler.urunfiyati = int.Parse(txturunFiyat.Text);
            MessageBox.Show("Ürün başarıyla kayıt edildi.");
            urunListesi.Add(urunler);

            foreach (urunler urun in urunListesi)
            {
                comboBox1.Items.Add(urun.urunadi);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen ürünün özelliklerini alalım
            int secilenIndex = comboBox1.SelectedIndex;
            urunler secilenUrun = urunListesi[secilenIndex];
            lblUrunAded.Text = Convert.ToString(secilenUrun.urunadedi);
            lblUrunFiyat.Text = Convert.ToString(secilenUrun.urunfiyati);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }


    }
}
