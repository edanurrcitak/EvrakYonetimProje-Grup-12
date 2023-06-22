namespace kullanici_yonetimi
{
    partial class FrmEmanet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmanet));
            this.button1 = new System.Windows.Forms.Button();
            this.EvrakListele = new System.Windows.Forms.Button();
            this.EmanetAra = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EvrakSil = new System.Windows.Forms.Button();
            this.dtpKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtEmanetAdı = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dptAlmaTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEvrakAdı = new System.Windows.Forms.TextBox();
            this.EmanetGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(969, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 40);
            this.button1.TabIndex = 24;
            this.button1.Text = "GERİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EvrakListele
            // 
            this.EvrakListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EvrakListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EvrakListele.ForeColor = System.Drawing.SystemColors.Control;
            this.EvrakListele.Location = new System.Drawing.Point(54, 461);
            this.EvrakListele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EvrakListele.Name = "EvrakListele";
            this.EvrakListele.Size = new System.Drawing.Size(156, 49);
            this.EvrakListele.TabIndex = 66;
            this.EvrakListele.Text = "Emanetleri Listele";
            this.EvrakListele.UseVisualStyleBackColor = false;
            this.EvrakListele.Click += new System.EventHandler(this.EvrakListele_Click);
            // 
            // EmanetAra
            // 
            this.EmanetAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmanetAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmanetAra.ForeColor = System.Drawing.SystemColors.Control;
            this.EmanetAra.Location = new System.Drawing.Point(1131, 139);
            this.EmanetAra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmanetAra.Name = "EmanetAra";
            this.EmanetAra.Size = new System.Drawing.Size(76, 36);
            this.EmanetAra.TabIndex = 65;
            this.EmanetAra.Text = "ARA";
            this.EmanetAra.UseVisualStyleBackColor = false;
            this.EmanetAra.Click += new System.EventHandler(this.EvrakAra_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(54, 405);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 36);
            this.button4.TabIndex = 64;
            this.button4.Text = "Emaneti Kaydet";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 63;
            this.label8.Text = "Emanet Alan Adı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 20);
            this.label11.TabIndex = 60;
            this.label11.Text = "Teslim Etme Tarih:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 58;
            this.label7.Text = "Arşivde Ara:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(412, 142);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(712, 26);
            this.textBox1.TabIndex = 57;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(412, 192);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 360);
            this.dataGridView1.TabIndex = 56;
            // 
            // EvrakSil
            // 
            this.EvrakSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EvrakSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EvrakSil.ForeColor = System.Drawing.SystemColors.Control;
            this.EvrakSil.Location = new System.Drawing.Point(217, 405);
            this.EvrakSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EvrakSil.Name = "EvrakSil";
            this.EvrakSil.Size = new System.Drawing.Size(156, 36);
            this.EvrakSil.TabIndex = 54;
            this.EvrakSil.Text = "Emaneti Sil";
            this.EvrakSil.UseVisualStyleBackColor = false;
            this.EvrakSil.Click += new System.EventHandler(this.EvrakSil_Click);
            // 
            // dtpKayitTarihi
            // 
            this.dtpKayitTarihi.Location = new System.Drawing.Point(196, 241);
            this.dtpKayitTarihi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpKayitTarihi.Name = "dtpKayitTarihi";
            this.dtpKayitTarihi.Size = new System.Drawing.Size(176, 26);
            this.dtpKayitTarihi.TabIndex = 51;
            // 
            // txtEmanetAdı
            // 
            this.txtEmanetAdı.Location = new System.Drawing.Point(197, 146);
            this.txtEmanetAdı.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmanetAdı.Name = "txtEmanetAdı";
            this.txtEmanetAdı.Size = new System.Drawing.Size(176, 26);
            this.txtEmanetAdı.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1289, 70);
            this.panel1.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emanet Kayıt Yönetim Sistemi";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(11, 78);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 40);
            this.button2.TabIndex = 48;
            this.button2.Text = "←";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Teslim Alma Tarih:";
            // 
            // dptAlmaTarih
            // 
            this.dptAlmaTarih.Location = new System.Drawing.Point(196, 288);
            this.dptAlmaTarih.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dptAlmaTarih.Name = "dptAlmaTarih";
            this.dptAlmaTarih.Size = new System.Drawing.Size(176, 26);
            this.dptAlmaTarih.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Evrak Adı:";
            // 
            // txtEvrakAdı
            // 
            this.txtEvrakAdı.Location = new System.Drawing.Point(197, 192);
            this.txtEvrakAdı.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEvrakAdı.Name = "txtEvrakAdı";
            this.txtEvrakAdı.Size = new System.Drawing.Size(176, 26);
            this.txtEvrakAdı.TabIndex = 69;
            // 
            // EmanetGuncelle
            // 
            this.EmanetGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmanetGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmanetGuncelle.ForeColor = System.Drawing.SystemColors.Control;
            this.EmanetGuncelle.Location = new System.Drawing.Point(217, 461);
            this.EmanetGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmanetGuncelle.Name = "EmanetGuncelle";
            this.EmanetGuncelle.Size = new System.Drawing.Size(156, 49);
            this.EmanetGuncelle.TabIndex = 71;
            this.EmanetGuncelle.Text = "Emaneti Güncelle";
            this.EmanetGuncelle.UseVisualStyleBackColor = false;
            this.EmanetGuncelle.Click += new System.EventHandler(this.EmanetGuncelle_Click);
            // 
            // FrmEmanet
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1263, 584);
            this.Controls.Add(this.EmanetGuncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEvrakAdı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dptAlmaTarih);
            this.Controls.Add(this.EvrakListele);
            this.Controls.Add(this.EmanetAra);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EvrakSil);
            this.Controls.Add(this.dtpKayitTarihi);
            this.Controls.Add(this.txtEmanetAdı);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmEmanet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmanet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EvrakListele;
        private System.Windows.Forms.Button EmanetAra;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EvrakSil;
        private System.Windows.Forms.DateTimePicker dtpKayitTarihi;
        private System.Windows.Forms.TextBox txtEmanetAdı;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dptAlmaTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEvrakAdı;
        private System.Windows.Forms.Button EmanetGuncelle;
    }
}