namespace EgitimDBFrom
{
    partial class Egitim
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
            this.btnOgretmen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtKursNo = new System.Windows.Forms.TextBox();
            this.lblKursNo = new System.Windows.Forms.Label();
            this.txtKursAd = new System.Windows.Forms.TextBox();
            this.lblKursAd = new System.Windows.Forms.Label();
            this.txtKurslar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGorevEkle = new System.Windows.Forms.Button();
            this.txtGorevNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGorevAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGorevler = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOgretmenSoyad = new System.Windows.Forms.TextBox();
            this.btnAta = new System.Windows.Forms.Button();
            this.txtOgretmenAd = new System.Windows.Forms.TextBox();
            this.comboKursSecOgretmen = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDersAl = new System.Windows.Forms.Button();
            this.txtTcNoOgrenci = new System.Windows.Forms.TextBox();
            this.comboKursSecOgrenci = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOgretmen
            // 
            this.btnOgretmen.BackColor = System.Drawing.Color.IndianRed;
            this.btnOgretmen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgretmen.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretmen.ForeColor = System.Drawing.Color.LightYellow;
            this.btnOgretmen.Location = new System.Drawing.Point(12, 338);
            this.btnOgretmen.Name = "btnOgretmen";
            this.btnOgretmen.Size = new System.Drawing.Size(99, 28);
            this.btnOgretmen.TabIndex = 0;
            this.btnOgretmen.Text = "Öğretmenler";
            this.btnOgretmen.UseVisualStyleBackColor = false;
            this.btnOgretmen.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 372);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(972, 174);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.BackColor = System.Drawing.Color.Goldenrod;
            this.btnOgrenci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenci.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenci.ForeColor = System.Drawing.Color.LightYellow;
            this.btnOgrenci.Location = new System.Drawing.Point(117, 338);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(101, 28);
            this.btnOgrenci.TabIndex = 2;
            this.btnOgrenci.Text = "Öğrenciler";
            this.btnOgrenci.UseVisualStyleBackColor = false;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click_1);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.LightYellow;
            this.btnEkle.Location = new System.Drawing.Point(167, 18);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(99, 73);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Kurs Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtKursNo
            // 
            this.txtKursNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtKursNo.Location = new System.Drawing.Point(62, 19);
            this.txtKursNo.Name = "txtKursNo";
            this.txtKursNo.Size = new System.Drawing.Size(99, 20);
            this.txtKursNo.TabIndex = 4;
            // 
            // lblKursNo
            // 
            this.lblKursNo.AutoSize = true;
            this.lblKursNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKursNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKursNo.Location = new System.Drawing.Point(2, 22);
            this.lblKursNo.Name = "lblKursNo";
            this.lblKursNo.Size = new System.Drawing.Size(48, 13);
            this.lblKursNo.TabIndex = 5;
            this.lblKursNo.Text = "Kurs No:";
            // 
            // txtKursAd
            // 
            this.txtKursAd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtKursAd.Location = new System.Drawing.Point(62, 45);
            this.txtKursAd.Name = "txtKursAd";
            this.txtKursAd.Size = new System.Drawing.Size(99, 20);
            this.txtKursAd.TabIndex = 6;
            // 
            // lblKursAd
            // 
            this.lblKursAd.AutoSize = true;
            this.lblKursAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKursAd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKursAd.Location = new System.Drawing.Point(2, 49);
            this.lblKursAd.Name = "lblKursAd";
            this.lblKursAd.Size = new System.Drawing.Size(49, 13);
            this.lblKursAd.TabIndex = 7;
            this.lblKursAd.Text = "Kurs Adı:";
            // 
            // txtKurslar
            // 
            this.txtKurslar.BackColor = System.Drawing.Color.DarkOrchid;
            this.txtKurslar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtKurslar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKurslar.ForeColor = System.Drawing.Color.LightYellow;
            this.txtKurslar.Location = new System.Drawing.Point(224, 338);
            this.txtKurslar.Name = "txtKurslar";
            this.txtKurslar.Size = new System.Drawing.Size(101, 28);
            this.txtKurslar.TabIndex = 10;
            this.txtKurslar.Text = "Kurslar";
            this.txtKurslar.UseVisualStyleBackColor = false;
            this.txtKurslar.Click += new System.EventHandler(this.txtKurslar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtKursNo);
            this.groupBox1.Controls.Add(this.lblKursNo);
            this.groupBox1.Controls.Add(this.txtKursAd);
            this.groupBox1.Controls.Add(this.lblKursAd);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 97);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kurs";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGorevEkle);
            this.groupBox2.Controls.Add(this.txtGorevNo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtGorevAd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 75);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Görev";
            // 
            // btnGorevEkle
            // 
            this.btnGorevEkle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGorevEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGorevEkle.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorevEkle.ForeColor = System.Drawing.Color.LightYellow;
            this.btnGorevEkle.Location = new System.Drawing.Point(167, 19);
            this.btnGorevEkle.Name = "btnGorevEkle";
            this.btnGorevEkle.Size = new System.Drawing.Size(99, 46);
            this.btnGorevEkle.TabIndex = 3;
            this.btnGorevEkle.Text = "Görev Ekle";
            this.btnGorevEkle.UseVisualStyleBackColor = false;
            this.btnGorevEkle.Click += new System.EventHandler(this.btnGorevEkle_Click);
            // 
            // txtGorevNo
            // 
            this.txtGorevNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGorevNo.Location = new System.Drawing.Point(62, 19);
            this.txtGorevNo.Name = "txtGorevNo";
            this.txtGorevNo.Size = new System.Drawing.Size(99, 20);
            this.txtGorevNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(2, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Görev No:";
            // 
            // txtGorevAd
            // 
            this.txtGorevAd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGorevAd.Location = new System.Drawing.Point(62, 45);
            this.txtGorevAd.Name = "txtGorevAd";
            this.txtGorevAd.Size = new System.Drawing.Size(99, 20);
            this.txtGorevAd.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(2, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Görev Adı:";
            // 
            // btnGorevler
            // 
            this.btnGorevler.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGorevler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGorevler.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorevler.ForeColor = System.Drawing.Color.LightYellow;
            this.btnGorevler.Location = new System.Drawing.Point(331, 338);
            this.btnGorevler.Name = "btnGorevler";
            this.btnGorevler.Size = new System.Drawing.Size(101, 28);
            this.btnGorevler.TabIndex = 19;
            this.btnGorevler.Text = "Görevler";
            this.btnGorevler.UseVisualStyleBackColor = false;
            this.btnGorevler.Click += new System.EventHandler(this.btnGorevler_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtOgretmenSoyad);
            this.groupBox3.Controls.Add(this.btnAta);
            this.groupBox3.Controls.Add(this.txtOgretmenAd);
            this.groupBox3.Controls.Add(this.comboKursSecOgretmen);
            this.groupBox3.Location = new System.Drawing.Point(290, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 97);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Öğretmen Ata";
            // 
            // txtOgretmenSoyad
            // 
            this.txtOgretmenSoyad.ForeColor = System.Drawing.Color.Gray;
            this.txtOgretmenSoyad.Location = new System.Drawing.Point(6, 65);
            this.txtOgretmenSoyad.Name = "txtOgretmenSoyad";
            this.txtOgretmenSoyad.Size = new System.Drawing.Size(121, 20);
            this.txtOgretmenSoyad.TabIndex = 9;
            this.txtOgretmenSoyad.Text = "Öğretmen Soyad";
            // 
            // btnAta
            // 
            this.btnAta.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAta.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAta.ForeColor = System.Drawing.Color.LightYellow;
            this.btnAta.Location = new System.Drawing.Point(133, 15);
            this.btnAta.Name = "btnAta";
            this.btnAta.Size = new System.Drawing.Size(110, 76);
            this.btnAta.TabIndex = 8;
            this.btnAta.Text = "Öğretmen Ata";
            this.btnAta.UseVisualStyleBackColor = false;
            this.btnAta.Click += new System.EventHandler(this.btnAta_Click);
            // 
            // txtOgretmenAd
            // 
            this.txtOgretmenAd.ForeColor = System.Drawing.Color.Gray;
            this.txtOgretmenAd.Location = new System.Drawing.Point(6, 40);
            this.txtOgretmenAd.Name = "txtOgretmenAd";
            this.txtOgretmenAd.Size = new System.Drawing.Size(121, 20);
            this.txtOgretmenAd.TabIndex = 2;
            this.txtOgretmenAd.Text = "Öğretmen Ad";
            this.txtOgretmenAd.Enter += new System.EventHandler(this.txtTcNoOgretmen_Enter);
            this.txtOgretmenAd.Leave += new System.EventHandler(this.txtTcNoOgretmen_Leave);
            // 
            // comboKursSecOgretmen
            // 
            this.comboKursSecOgretmen.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboKursSecOgretmen.FormattingEnabled = true;
            this.comboKursSecOgretmen.Location = new System.Drawing.Point(6, 15);
            this.comboKursSecOgretmen.Name = "comboKursSecOgretmen";
            this.comboKursSecOgretmen.Size = new System.Drawing.Size(121, 21);
            this.comboKursSecOgretmen.TabIndex = 1;
            this.comboKursSecOgretmen.Text = "Kurs Seç";
            this.comboKursSecOgretmen.SelectedIndexChanged += new System.EventHandler(this.comboKursSecOgretmen_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDersAl);
            this.groupBox4.Controls.Add(this.txtTcNoOgrenci);
            this.groupBox4.Controls.Add(this.comboKursSecOgrenci);
            this.groupBox4.Location = new System.Drawing.Point(545, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 97);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Personel";
            // 
            // btnDersAl
            // 
            this.btnDersAl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDersAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDersAl.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersAl.ForeColor = System.Drawing.Color.LightYellow;
            this.btnDersAl.Location = new System.Drawing.Point(133, 18);
            this.btnDersAl.Name = "btnDersAl";
            this.btnDersAl.Size = new System.Drawing.Size(96, 69);
            this.btnDersAl.TabIndex = 8;
            this.btnDersAl.Text = "Kurs Al";
            this.btnDersAl.UseVisualStyleBackColor = false;
            this.btnDersAl.Click += new System.EventHandler(this.btnDersAl_Click);
            // 
            // txtTcNoOgrenci
            // 
            this.txtTcNoOgrenci.ForeColor = System.Drawing.Color.Gray;
            this.txtTcNoOgrenci.Location = new System.Drawing.Point(6, 42);
            this.txtTcNoOgrenci.Name = "txtTcNoOgrenci";
            this.txtTcNoOgrenci.Size = new System.Drawing.Size(121, 20);
            this.txtTcNoOgrenci.TabIndex = 2;
            this.txtTcNoOgrenci.Text = "Tc No ";
            this.txtTcNoOgrenci.TextChanged += new System.EventHandler(this.txtTcNoOgrenci_TextChanged);
            this.txtTcNoOgrenci.Enter += new System.EventHandler(this.txtTcNoOgrenci_Enter);
            this.txtTcNoOgrenci.Leave += new System.EventHandler(this.txtTcNoOgrenci_Leave);
            // 
            // comboKursSecOgrenci
            // 
            this.comboKursSecOgrenci.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboKursSecOgrenci.FormattingEnabled = true;
            this.comboKursSecOgrenci.Location = new System.Drawing.Point(6, 18);
            this.comboKursSecOgrenci.Name = "comboKursSecOgrenci";
            this.comboKursSecOgrenci.Size = new System.Drawing.Size(121, 21);
            this.comboKursSecOgrenci.TabIndex = 1;
            this.comboKursSecOgrenci.Text = "Kurs Seç";
            this.comboKursSecOgrenci.SelectedIndexChanged += new System.EventHandler(this.comboKursSecOgrenci_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Location = new System.Drawing.Point(756, 297);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 69);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(867, 297);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 69);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Egitim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(972, 546);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnGorevler);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtKurslar);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOgretmen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Egitim";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Egitim";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Egitim_FormClosed);
            this.Load += new System.EventHandler(this.Egitim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgretmen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtKursNo;
        private System.Windows.Forms.Label lblKursNo;
        private System.Windows.Forms.TextBox txtKursAd;
        private System.Windows.Forms.Label lblKursAd;
       // private System.Windows.Forms.TextBox txtKacSaat;
        private System.Windows.Forms.Button txtKurslar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGorevEkle;
        private System.Windows.Forms.TextBox txtGorevNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGorevAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGorevler;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboKursSecOgretmen;
        private System.Windows.Forms.TextBox txtOgretmenAd;
        private System.Windows.Forms.Button btnAta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDersAl;
        private System.Windows.Forms.TextBox txtTcNoOgrenci;
        private System.Windows.Forms.ComboBox comboKursSecOgrenci;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtOgretmenSoyad;
    }
}