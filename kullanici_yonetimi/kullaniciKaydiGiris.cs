using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kullanici_yonetimi
{
    public partial class kullaniciKaydiGiris : Form
    {
        public kullaniciKaydiGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=grup12-2023; Uid=root; pwd=");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("Select * From kullanıcı where userName=@p1 and kullaniciSifre=@p2 and kullaniciDepartman='Fakülte Sekreteri'", baglanti);
            komut.Parameters.AddWithValue("@p1", username.Text);
            komut.Parameters.AddWithValue("@p2", password.Text);
            MySqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                yeniKullanici yeniKullanici = new yeniKullanici();
                yeniKullanici.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!");
            }
            baglanti.Close();
        }
        private void kullaniciKaydiGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
