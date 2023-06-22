namespace kullanici_yonetimi
{
    partial class FrmEvrak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEvrak));
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtRafNo = new System.Windows.Forms.TextBox();
            this.EvrakSil = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBırakanPersonel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEvrakAdı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.EvrakAra = new System.Windows.Forms.Button();
            this.EvrakListele = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(11, 78);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "←";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Arşivde Ara:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(411, 136);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(712, 26);
            this.textBox1.TabIndex = 38;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(411, 186);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 360);
            this.dataGridView1.TabIndex = 37;
            // 
            // txtRafNo
            // 
            this.txtRafNo.Location = new System.Drawing.Point(196, 278);
            this.txtRafNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRafNo.Name = "txtRafNo";
            this.txtRafNo.Size = new System.Drawing.Size(176, 26);
            this.txtRafNo.TabIndex = 36;
            // 
            // EvrakSil
            // 
            this.EvrakSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EvrakSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EvrakSil.ForeColor = System.Drawing.SystemColors.Control;
            this.EvrakSil.Location = new System.Drawing.Point(216, 399);
            this.EvrakSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EvrakSil.Name = "EvrakSil";
            this.EvrakSil.Size = new System.Drawing.Size(156, 48);
            this.EvrakSil.TabIndex = 35;
            this.EvrakSil.Text = "Evrağı Sil";
            this.EvrakSil.UseVisualStyleBackColor = false;
            this.EvrakSil.Click += new System.EventHandler(this.EvrakSil_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(-154, 421);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 36);
            this.button3.TabIndex = 34;
            this.button3.Text = "Evrağı Kaydet";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-74, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Evrak Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-101, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Raf Numarası:";
            // 
            // txtBırakanPersonel
            // 
            this.txtBırakanPersonel.Location = new System.Drawing.Point(196, 231);
            this.txtBırakanPersonel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBırakanPersonel.Name = "txtBırakanPersonel";
            this.txtBırakanPersonel.Size = new System.Drawing.Size(176, 26);
            this.txtBırakanPersonel.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-151, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Bırakan Personel Adı:";
            // 
            // dtpKayitTarihi
            // 
            this.dtpKayitTarihi.Location = new System.Drawing.Point(196, 329);
            this.dtpKayitTarihi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpKayitTarihi.Name = "dtpKayitTarihi";
            this.dtpKayitTarihi.Size = new System.Drawing.Size(176, 26);
            this.dtpKayitTarihi.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-114, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Bırakıldığı Tarih:";
            // 
            // txtEvrakAdı
            // 
            this.txtEvrakAdı.Location = new System.Drawing.Point(200, 180);
            this.txtEvrakAdı.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEvrakAdı.Name = "txtEvrakAdı";
            this.txtEvrakAdı.Size = new System.Drawing.Size(176, 26);
            this.txtEvrakAdı.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-82, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Evrak Türü:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 74);
            this.panel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Evrak Kayıt Yönetim Sistemi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Raf Numarası:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Bırakan Personel Adı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 41;
            this.label11.Text = "Bırakıldığı Tarih:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(105, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 40;
            this.label12.Text = "Evrak Türü:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(53, 399);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 48);
            this.button4.TabIndex = 45;
            this.button4.Text = "Evrağı Kaydet";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // EvrakAra
            // 
            this.EvrakAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EvrakAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EvrakAra.ForeColor = System.Drawing.SystemColors.Control;
            this.EvrakAra.Location = new System.Drawing.Point(1130, 132);
            this.EvrakAra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EvrakAra.Name = "EvrakAra";
            this.EvrakAra.Size = new System.Drawing.Size(76, 36);
            this.EvrakAra.TabIndex = 46;
            this.EvrakAra.Text = "ARA";
            this.EvrakAra.UseVisualStyleBackColor = false;
            this.EvrakAra.Click += new System.EventHandler(this.EvrakAra_Click);
            // 
            // EvrakListele
            // 
            this.EvrakListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EvrakListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EvrakListele.ForeColor = System.Drawing.SystemColors.Control;
            this.EvrakListele.Location = new System.Drawing.Point(53, 455);
            this.EvrakListele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EvrakListele.Name = "EvrakListele";
            this.EvrakListele.Size = new System.Drawing.Size(156, 48);
            this.EvrakListele.TabIndex = 47;
            this.EvrakListele.Text = "Evrakları Listele";
            this.EvrakListele.UseVisualStyleBackColor = false;
            this.EvrakListele.Click += new System.EventHandler(this.EvrakListele_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(216, 455);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 48);
            this.button2.TabIndex = 48;
            this.button2.Text = "Evrakları Güncelle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmEvrak
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1276, 576);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EvrakListele);
            this.Controls.Add(this.EvrakAra);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtRafNo);
            this.Controls.Add(this.EvrakSil);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBırakanPersonel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpKayitTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEvrakAdı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmEvrak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEvrak";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtRafNo;
        private System.Windows.Forms.Button EvrakSil;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBırakanPersonel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpKayitTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEvrakAdı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button EvrakAra;
        private System.Windows.Forms.Button EvrakListele;
        private System.Windows.Forms.Button button2;
    }
}