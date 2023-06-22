using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kullanici_yonetimi
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void kullaniciButon_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Fakülte Sekreteri Misiniz?", "Özel İzin Gereklidir", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                kullaniciKaydiGiris ozelgırıs = new kullaniciKaydiGiris();
                ozelgırıs.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı uyumsuzluğu nedeniyle giriş yapılamamaktadır.");
            }
         
        }

        private void evrakButon_Click(object sender, EventArgs e)
        {
            FrmEvrak evrakpanel = new FrmEvrak();
            evrakpanel.Show();
            this.Close();
        }

        private void emanetButon_Click(object sender, EventArgs e)
        {
            FrmEmanet emanetpanel = new FrmEmanet();
            emanetpanel.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullaniciGirisi giris = new kullaniciGirisi();
            giris.Show();
            this.Close();
        }
    }
}
