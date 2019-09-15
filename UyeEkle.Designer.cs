namespace EgitimDBFrom
{
    partial class UyeEkle
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
            this.btnKayit = new System.Windows.Forms.Button();
            this.lblKullaniciAd = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblYetki = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(88, 100);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(100, 26);
            this.btnKayit.TabIndex = 0;
            this.btnKayit.Text = "Kayit Ekle";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // lblKullaniciAd
            // 
            this.lblKullaniciAd.AutoSize = true;
            this.lblKullaniciAd.Location = new System.Drawing.Point(12, 9);
            this.lblKullaniciAd.Name = "lblKullaniciAd";
            this.lblKullaniciAd.Size = new System.Drawing.Size(70, 13);
            this.lblKullaniciAd.TabIndex = 1;
            this.lblKullaniciAd.Text = "Kullanıcı Adı: ";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(88, 6);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(88, 39);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 4;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(12, 42);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(34, 13);
            this.lblSifre.TabIndex = 3;
            this.lblSifre.Text = "Şifre: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yönetici",
            "Memur",
            "Eğitim"});
            this.comboBox1.Location = new System.Drawing.Point(88, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Location = new System.Drawing.Point(12, 75);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(34, 13);
            this.lblYetki.TabIndex = 6;
            this.lblYetki.Text = "Yetki:";
            // 
            // UyeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 132);
            this.Controls.Add(this.lblYetki);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblKullaniciAd);
            this.Controls.Add(this.btnKayit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UyeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UyeEkle";
            this.Load += new System.EventHandler(this.UyeEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label lblKullaniciAd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblYetki;
    }
}