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
    public partial class newDepartment : Form
    {
        private yeniKullanici yeniKullanici;

        public newDepartment()
        {
        }

        public newDepartment(yeniKullanici parentForm)
        {
            InitializeComponent();
            yeniKullanici = parentForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") 
            {
            string texBoxValue = textBox1.Text;
            yeniKullanici.AddItemToComboBox(texBoxValue);
            this.Close();
                MessageBox.Show("Yeni departman başarılı bir şekilde eklendi.");
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir departman adı giriniz.");
                textBox1.Focus();
            }
            
           
        }
    }
}
