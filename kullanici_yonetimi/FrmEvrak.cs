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
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace kullanici_yonetimi
{
    public partial class FrmEvrak : Form
    {
        public FrmEvrak()
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

        private void button4_Click(object sender, EventArgs e)//Evrak EKleme
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("INSERT INTO Evrak (evrakTuru, bırakanPersonel, evrakRafNo,kayitTarih) VALUES (@p1, @p2, @p3, @p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtEvrakAdı.Text);
            komut.Parameters.AddWithValue("@p2", txtBırakanPersonel.Text);
            komut.Parameters.AddWithValue("@p3", txtRafNo.Text);
            komut.Parameters.AddWithValue("@p4",dtpKayitTarihi.Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Evrak Kayıt Edildi.");

        }

        private void EvrakListele_Click(object sender, EventArgs e)//Evrakları listeleme
        {
            MySqlCommand komut = new MySqlCommand("Select evrakTuru,evrakRafNo,kayitTarih,bırakanPersonel From evrak", baglanti); //Listeleme için yaptığımız SQL sorgusu.
            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("Evraklar Listelendi");
        }

        private void EvrakSil_Click(object sender, EventArgs e)//Evrakları Silme
        {
            try
            {
                baglanti.Open();
                MySqlCommand komut3 = new MySqlCommand("delete from evrak where evrakTuru=@p1 and bırakanPersonel=@p2", baglanti);
                komut3.Parameters.AddWithValue("@p1",txtEvrakAdı.Text);
                komut3.Parameters.AddWithValue("@p2", txtBırakanPersonel.Text);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Evrak başarılı bir şekilde silindi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Silme sırasında hata oluştu." + hata.Message);
            }
        }

        private void EvrakAra_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand komut = new MySqlCommand("Select evrakTuru,evrakRafNo,bırakanPersonel,kayitTarih From Evrak where bırakanPersonel = @p1", baglanti); //Listeleme için yaptığımız SQL sorgusu.
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Evraklar Listelendi");
            }
            catch
            {
                MessageBox.Show("Evrak Bulunamadı.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut5 = new MySqlCommand("update evrak set evrakTuru=@p1,evrakRafNo=@p2,kayitTarih=@p4 where bırakanPersonel=@p3", baglanti);
            komut5.Parameters.AddWithValue("@p1", txtEvrakAdı.Text);
            komut5.Parameters.AddWithValue("@p2", txtRafNo.Text);
            komut5.Parameters.AddWithValue("@p3", txtBırakanPersonel.Text);
            komut5.Parameters.AddWithValue("@p4", dtpKayitTarihi.Value);
            komut5.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Evrak başarılı bir şekilde güncellendi.");
        }
    }
}
