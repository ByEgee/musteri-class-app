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
    public partial class Login : Form
    {
        //koleksiyon örnek kullaınımı için böyle bir sistem yaptım
        //NOT: Şifrelerde matematiksel bir işlem yapmayacağınız için İNT türünde kayıt etmek yerine STRİNG türünde kayıt edin.
        string[] kullanicilar = { "admin" };
        string[] sifre = { "123" };

        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txtKadi.Text = "admin";
            txtSifre.Text = "123";
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtKadi.Text;
            string sifre = txtSifre.Text;
            if (kullanicilar.Contains(kullaniciadi) == true || sifre.Contains(sifre) == true )
            {
                MessageBox.Show($"Başarılı bir şekilde {kullaniciadi} adıyla giriş yaptın.");
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girdiğin bilgiler geçersiz.");
            }
        }


    }
}
