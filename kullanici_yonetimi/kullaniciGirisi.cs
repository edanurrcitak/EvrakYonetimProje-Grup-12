using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kullanici_yonetimi
{
    public partial class kullaniciGirisi : Form
    {
        public kullaniciGirisi()
        {
            InitializeComponent();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=grup12-2023; Uid=root; pwd=");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("Select * From kullanıcı where userName=@p1 and kullaniciSifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUser.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            MySqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                anasayfa ekran = new anasayfa();
                ekran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!");
            }
            baglanti.Close();

            
            }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Unchecked)
            {
                txtSifre.UseSystemPasswordChar = true;
                checkBox1.Text = "Şifreyi Göster";
            }
            else if (checkBox1.CheckState == CheckState.Checked)
            {
                txtSifre.UseSystemPasswordChar = false;
                checkBox1.Text = "Şifreyi Gizle";
            }
        }
    }
}
