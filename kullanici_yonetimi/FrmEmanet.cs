using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace kullanici_yonetimi
{
    public partial class FrmEmanet : Form
    {
        public FrmEmanet()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=grup12-2023; Uid=root; pwd=");

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa yönlendirmepanel = new anasayfa();
            yönlendirmepanel.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)//EMANET KAYDETME
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("INSERT INTO emanet (emanetAlan, emanetVermeTarih,evrakAdı,emanetTeslimAlmaTarih) VALUES (@p1, @p2, @p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtEmanetAdı.Text);
            komut.Parameters.AddWithValue("@p2", dtpKayitTarihi.Value);
            komut.Parameters.AddWithValue("@p3", txtEvrakAdı.Text);
            komut.Parameters.AddWithValue("@p4", dptAlmaTarih.Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Emanet Kayıt Edildi.");
        }

        private void EvrakAra_Click(object sender, EventArgs e)//EMANET ARAMA
        {
            MySqlCommand komut = new MySqlCommand("Select emanetAlan, emanetVermeTarih, emanetTeslimAlmaTarih,evrakAdı From emanet where emanetAlan= @p1", baglanti); //Listeleme için yaptığımız SQL sorgusu.
            komut.Parameters.AddWithValue("@p1",textBox1.Text);
            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("İlgili emanet listelendi");
        }

        private void EvrakListele_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("Select emanetAlan, emanetVermeTarih, emanetTeslimAlmaTarih,evrakAdı From emanet", baglanti); //Listeleme için yaptığımız SQL sorgusu.
            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("Emanetler Listelendi");
        }

        private void EvrakSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                MySqlCommand komut3 = new MySqlCommand("delete from emanet where emanetAlan=@p1 and evrakAdı=@p2", baglanti);
                komut3.Parameters.AddWithValue("@p1", txtEmanetAdı.Text);
                komut3.Parameters.AddWithValue("@p2", txtEvrakAdı.Text);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Emanet başarılı bir şekilde silindi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Silme sırasında hata oluştu." + hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anasayfa yönlendirmepanel = new anasayfa();
            yönlendirmepanel.Show();
            this.Hide();
        }

        private void EmanetGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut5 = new MySqlCommand("update emanet set emanetTeslimAlmaTarih=@p1,evrakAdı=@p3,emanetVermeTarih=@p4 where emanetAlan=@p2", baglanti);
            komut5.Parameters.AddWithValue("@p1",dptAlmaTarih.Value);
            komut5.Parameters.AddWithValue("@p2",txtEmanetAdı.Text);
            komut5.Parameters.AddWithValue("@p3", txtEvrakAdı.Text);
            komut5.Parameters.AddWithValue("@p4", dtpKayitTarihi.Value);
            komut5.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Emanet başarılı bir şekilde güncellendi.");
        }
    }
}
