namespace kullanici_yonetimi
{
    partial class yeniKullanici
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yeniKullanici));
            this.txtBox_password2 = new System.Windows.Forms.TextBox();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.txtBox_surname = new System.Windows.Forms.TextBox();
            this.txtBox_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.combobox_department = new System.Windows.Forms.ComboBox();
            this.button_save = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.userSec = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBox_password2
            // 
            this.txtBox_password2.Location = new System.Drawing.Point(479, 433);
            this.txtBox_password2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_password2.Name = "txtBox_password2";
            this.txtBox_password2.Size = new System.Drawing.Size(201, 26);
            this.txtBox_password2.TabIndex = 4;
            this.txtBox_password2.UseSystemPasswordChar = true;
            // 
            // txtBox_password
            // 
            this.txtBox_password.Location = new System.Drawing.Point(479, 329);
            this.txtBox_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.Size = new System.Drawing.Size(201, 26);
            this.txtBox_password.TabIndex = 3;
            this.txtBox_password.UseSystemPasswordChar = true;
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(479, 114);
            this.txtBox_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_name.Multiline = true;
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(201, 26);
            this.txtBox_name.TabIndex = 0;
            // 
            // txtBox_surname
            // 
            this.txtBox_surname.Location = new System.Drawing.Point(479, 186);
            this.txtBox_surname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_surname.Name = "txtBox_surname";
            this.txtBox_surname.Size = new System.Drawing.Size(201, 26);
            this.txtBox_surname.TabIndex = 1;
            // 
            // txtBox_user
            // 
            this.txtBox_user.Location = new System.Drawing.Point(479, 257);
            this.txtBox_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_user.Name = "txtBox_user";
            this.txtBox_user.Size = new System.Drawing.Size(201, 26);
            this.txtBox_user.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(476, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(476, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kullanıcı departmanı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(476, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Şifre tekrar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(476, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Şifre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(476, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kullanıcı Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(476, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Soyad";
            // 
            // combobox_department
            // 
            this.combobox_department.FormattingEnabled = true;
            this.combobox_department.Items.AddRange(new object[] {
            "Fakülte Sekreteri",
            "Öğrenci İşleri",
            "Personel İşleri",
            "Bölüm Sekreterlikleri"});
            this.combobox_department.Location = new System.Drawing.Point(479, 507);
            this.combobox_department.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combobox_department.Name = "combobox_department";
            this.combobox_department.Size = new System.Drawing.Size(201, 28);
            this.combobox_department.TabIndex = 18;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.LimeGreen;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_save.Location = new System.Drawing.Point(519, 600);
            this.button_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(107, 48);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "Kaydet";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(479, 373);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 24);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Şifreyi göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1545, 64);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Kayıt Yönetim Sistemi";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 40);
            this.button1.TabIndex = 22;
            this.button1.Text = "←";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(479, 549);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 28);
            this.button2.TabIndex = 23;
            this.button2.Text = "Yeni Departman";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userSec
            // 
            this.userSec.FormattingEnabled = true;
            this.userSec.Location = new System.Drawing.Point(837, 114);
            this.userSec.Name = "userSec";
            this.userSec.Size = new System.Drawing.Size(273, 28);
            this.userSec.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(833, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Kullanıcılar";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1116, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 40);
            this.button3.TabIndex = 26;
            this.button3.Text = "Kullanıcıyı Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // yeniKullanici
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1508, 701);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.userSec);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.combobox_department);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_user);
            this.Controls.Add(this.txtBox_surname);
            this.Controls.Add(this.txtBox_name);
            this.Controls.Add(this.txtBox_password);
            this.Controls.Add(this.txtBox_password2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "yeniKullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Kayıt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.yeniKullanici_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBox_password2;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.TextBox txtBox_surname;
        private System.Windows.Forms.TextBox txtBox_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combobox_department;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox userSec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
    }
}

