namespace kullanici_yonetimi
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.emanetButon = new System.Windows.Forms.Button();
            this.kullaniciButon = new System.Windows.Forms.Button();
            this.evrakButon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1544, 79);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(599, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "ANASAYFA";
            // 
            // emanetButon
            // 
            this.emanetButon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emanetButon.Image = ((System.Drawing.Image)(resources.GetObject("emanetButon.Image")));
            this.emanetButon.Location = new System.Drawing.Point(887, 247);
            this.emanetButon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emanetButon.Name = "emanetButon";
            this.emanetButon.Size = new System.Drawing.Size(144, 148);
            this.emanetButon.TabIndex = 3;
            this.emanetButon.UseVisualStyleBackColor = false;
            this.emanetButon.Click += new System.EventHandler(this.emanetButon_Click);
            // 
            // kullaniciButon
            // 
            this.kullaniciButon.Image = ((System.Drawing.Image)(resources.GetObject("kullaniciButon.Image")));
            this.kullaniciButon.Location = new System.Drawing.Point(341, 247);
            this.kullaniciButon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullaniciButon.Name = "kullaniciButon";
            this.kullaniciButon.Size = new System.Drawing.Size(145, 148);
            this.kullaniciButon.TabIndex = 4;
            this.kullaniciButon.UseVisualStyleBackColor = true;
            this.kullaniciButon.Click += new System.EventHandler(this.kullaniciButon_Click);
            // 
            // evrakButon
            // 
            this.evrakButon.Image = ((System.Drawing.Image)(resources.GetObject("evrakButon.Image")));
            this.evrakButon.Location = new System.Drawing.Point(616, 247);
            this.evrakButon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.evrakButon.Name = "evrakButon";
            this.evrakButon.Size = new System.Drawing.Size(154, 148);
            this.evrakButon.TabIndex = 5;
            this.evrakButon.UseVisualStyleBackColor = true;
            this.evrakButon.Click += new System.EventHandler(this.evrakButon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(305, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Kayıt Yönetimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(612, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Evrak Yönetimi ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(883, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Emanet Yönetimi";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 54);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1526, 576);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.evrakButon);
            this.Controls.Add(this.kullaniciButon);
            this.Controls.Add(this.emanetButon);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button emanetButon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kullaniciButon;
        private System.Windows.Forms.Button evrakButon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}