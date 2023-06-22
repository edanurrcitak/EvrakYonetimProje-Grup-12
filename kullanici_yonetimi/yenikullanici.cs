using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Org.BouncyCastle.Utilities;

namespace kullanici_yonetimi
{
    public partial class yeniKullanici : Form
    {
        public yeniKullanici()
        {
            InitializeComponent();
        }

        public void button_save_Click(object sender, EventArgs e)
        {
            string name = txtBox_name.Text;
            string surname = txtBox_surname.Text;
            string username = txtBox_user.Text;
            string password = txtBox_password.Text;
            string password2 = txtBox_password2.Text;

            try
            {
                if (password != password2)
                {
                    MessageBox.Show("Şifreler eşleştirilemedi.");
                }
                else if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(password2) || string.IsNullOrEmpty(combobox_department.Text))
                {
                    MessageBox.Show("Boş alan bırakmayınız.");
                }
                else if (password.Length < 8 || password2.Length < 8)
                {
                    MessageBox.Show("Şifre 8 karakterden fazla olmalıdır.");
                }
                else
                {
                    // VERİTABANI KODLARI

                    MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=grup12-2023; Uid=root; pwd=");
                    baglanti.Open();

                    // Kullanıcı adının veritabanında mevcut olup olmadığını kontrol etme
                    string kullaniciAdiSorgusu = "SELECT COUNT(*) FROM Kullanıcı WHERE userName = @p3";
                    using (MySqlCommand komut2 = new MySqlCommand(kullaniciAdiSorgusu, baglanti))
                    {
                        komut2.Parameters.AddWithValue("@p3", username);
                        int kayitSayisi = Convert.ToInt32(komut2.ExecuteScalar());

                        if (kayitSayisi > 0)
                        {
                            MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor. Lütfen farklı bir kullanıcı adı seçin.");
                        }
                        else
                        {
                            // Kullanıcıyı veritabanına ekleme
                            string kullaniciEklemeSorgusu = "INSERT INTO Kullanıcı (kullaniciAd, kullaniciSoyad, userName, kullaniciDepartman, kullaniciSifre) VALUES (@p1, @p2, @p3, @p4, @p5)";
                            using (MySqlCommand komut = new MySqlCommand(kullaniciEklemeSorgusu, baglanti))
                            {
                                komut.Parameters.AddWithValue("@p1", name);
                                komut.Parameters.AddWithValue("@p2", surname);
                                komut.Parameters.AddWithValue("@p3", username);
                                komut.Parameters.AddWithValue("@p4", combobox_department.SelectedItem);
                                komut.Parameters.AddWithValue("@p5", password);
                                komut.ExecuteNonQuery();

                                MessageBox.Show("Kullanıcı kaydı başarılı bir şekilde gerçekleşti.");
                            }
                        }
                    }

                    baglanti.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }    
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.CheckState == CheckState.Unchecked)
            {
                txtBox_password.UseSystemPasswordChar = true;
                txtBox_password2.UseSystemPasswordChar= true;
                checkBox1.Text = "Şifreyi Göster";
            }
            else if (checkBox1.CheckState == CheckState.Checked)
            {
                txtBox_password.UseSystemPasswordChar = false;
                txtBox_password2.UseSystemPasswordChar= false;
                checkBox1.Text = "Şifreyi Gizle";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa yönlendirmepanel = new anasayfa();
            yönlendirmepanel.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newDepartment form2 = new newDepartment(this);
            form2.Show();
        }

        private void yeniKullanici_Load(object sender, EventArgs e)
        {
            MySqlConnection baglanti2 = new MySqlConnection("Server=localhost; Database=grup12-2023; Uid=root; pwd=");
            baglanti2.Open();
            MySqlCommand komut = new MySqlCommand("Select userName from kullanıcı", baglanti2);
            MySqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                string kullaniciAdi = reader.GetString("userName");
                userSec.Items.Add(kullaniciAdi);
            }
            reader.Close();
        }
        private void openForm2Button_Click(object sender, EventArgs e)
        {
            newDepartment newDepartment = new newDepartment(this);
            newDepartment.ShowDialog();
        }
        public void AddItemToComboBox(string item)
        {
            combobox_department.Items.Add(item);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string secilenKullaniciAdi = userSec.SelectedItem.ToString();

            string connectionString = "Server=localhost; Database=grup12-2023; Uid=root; pwd=";
            MySqlConnection baglanti = new MySqlConnection(connectionString);

            try
            {
                baglanti.Open();

                string sorgu = "DELETE FROM kullanıcı WHERE userName = @kullaniciAdi";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@kullaniciAdi", secilenKullaniciAdi);
                int etkilenenSatirSayisi = komut.ExecuteNonQuery();
                if (etkilenenSatirSayisi > 0)
                {
                    MessageBox.Show("Kullanıcı başarıyla silindi.");
                    userSec.Items.Remove(secilenKullaniciAdi);
                }
                else
                {
                    MessageBox.Show("Kullanıcı silinirken bir hata oluştu.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı sırasında bir hata oluştu: " + ex);
            }
        }

        }
    }
   

