namespace EgitimDBFrom
{
    partial class Form2
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
            this.lblYetki = new System.Windows.Forms.Label();
            this.lblYetkiniz = new System.Windows.Forms.Label();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnBolumEkle = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPersonelList = new System.Windows.Forms.Button();
            this.btnBolumList = new System.Windows.Forms.Button();
            this.btnEgitim = new System.Windows.Forms.Button();
            this.btnEgitimList = new System.Windows.Forms.Button();
            this.btnUye = new System.Windows.Forms.Button();
            this.btnUyeList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetki.Location = new System.Drawing.Point(71, 9);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(11, 13);
            this.lblYetki.TabIndex = 0;
            this.lblYetki.Text = "-";
            // 
            // lblYetkiniz
            // 
            this.lblYetkiniz.AutoSize = true;
            this.lblYetkiniz.Location = new System.Drawing.Point(12, 9);
            this.lblYetkiniz.Name = "lblYetkiniz";
            this.lblYetkiniz.Size = new System.Drawing.Size(53, 13);
            this.lblYetkiniz.TabIndex = 1;
            this.lblYetkiniz.Text = "Yetkiniz : ";
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(12, 53);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(97, 50);
            this.btnPersonelEkle.TabIndex = 2;
            this.btnPersonelEkle.Text = "Personel İşleri";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnBolumEkle
            // 
            this.btnBolumEkle.Location = new System.Drawing.Point(115, 53);
            this.btnBolumEkle.Name = "btnBolumEkle";
            this.btnBolumEkle.Size = new System.Drawing.Size(97, 50);
            this.btnBolumEkle.TabIndex = 3;
            this.btnBolumEkle.Text = "Bölümler";
            this.btnBolumEkle.UseVisualStyleBackColor = true;
            this.btnBolumEkle.Click += new System.EventHandler(this.btnBolumEkle_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPass.ForeColor = System.Drawing.Color.Green;
            this.lblPass.Location = new System.Drawing.Point(416, 9);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(11, 13);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "-";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(686, 237);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnPersonelList
            // 
            this.btnPersonelList.Location = new System.Drawing.Point(12, 109);
            this.btnPersonelList.Name = "btnPersonelList";
            this.btnPersonelList.Size = new System.Drawing.Size(97, 23);
            this.btnPersonelList.TabIndex = 6;
            this.btnPersonelList.Text = "Personel Listele";
            this.btnPersonelList.UseVisualStyleBackColor = true;
            this.btnPersonelList.Click += new System.EventHandler(this.btnPersonelList_Click);
            // 
            // btnBolumList
            // 
            this.btnBolumList.Location = new System.Drawing.Point(115, 109);
            this.btnBolumList.Name = "btnBolumList";
            this.btnBolumList.Size = new System.Drawing.Size(97, 23);
            this.btnBolumList.TabIndex = 7;
            this.btnBolumList.Text = "Bölüm Listele";
            this.btnBolumList.UseVisualStyleBackColor = true;
            this.btnBolumList.Click += new System.EventHandler(this.btnBolumList_Click);
            // 
            // btnEgitim
            // 
            this.btnEgitim.Location = new System.Drawing.Point(218, 53);
            this.btnEgitim.Name = "btnEgitim";
            this.btnEgitim.Size = new System.Drawing.Size(97, 50);
            this.btnEgitim.TabIndex = 15;
            this.btnEgitim.Text = "Eğitim";
            this.btnEgitim.UseVisualStyleBackColor = true;
            this.btnEgitim.Click += new System.EventHandler(this.btnEgitim_Click);
            // 
            // btnEgitimList
            // 
            this.btnEgitimList.Location = new System.Drawing.Point(218, 109);
            this.btnEgitimList.Name = "btnEgitimList";
            this.btnEgitimList.Size = new System.Drawing.Size(97, 23);
            this.btnEgitimList.TabIndex = 16;
            this.btnEgitimList.Text = "Eğitim Listele";
            this.btnEgitimList.UseVisualStyleBackColor = true;
            this.btnEgitimList.Click += new System.EventHandler(this.btnEgitimList_Click);
            // 
            // btnUye
            // 
            this.btnUye.Location = new System.Drawing.Point(601, 53);
            this.btnUye.Name = "btnUye";
            this.btnUye.Size = new System.Drawing.Size(97, 50);
            this.btnUye.TabIndex = 17;
            this.btnUye.Text = "Üye Ekle";
            this.btnUye.UseVisualStyleBackColor = true;
            this.btnUye.Click += new System.EventHandler(this.btnUye_Click);
            // 
            // btnUyeList
            // 
            this.btnUyeList.Location = new System.Drawing.Point(601, 109);
            this.btnUyeList.Name = "btnUyeList";
            this.btnUyeList.Size = new System.Drawing.Size(97, 23);
            this.btnUyeList.TabIndex = 18;
            this.btnUyeList.Text = "Üye Listele";
            this.btnUyeList.UseVisualStyleBackColor = true;
            this.btnUyeList.Click += new System.EventHandler(this.btnUyeList_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 387);
            this.Controls.Add(this.btnUyeList);
            this.Controls.Add(this.btnUye);
            this.Controls.Add(this.btnEgitimList);
            this.Controls.Add(this.btnEgitim);
            this.Controls.Add(this.btnBolumList);
            this.Controls.Add(this.btnPersonelList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.btnBolumEkle);
            this.Controls.Add(this.btnPersonelEkle);
            this.Controls.Add(this.lblYetkiniz);
            this.Controls.Add(this.lblYetki);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed_1);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYetki;
        private System.Windows.Forms.Label lblYetkiniz;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnBolumEkle;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnPersonelList;
        private System.Windows.Forms.Button btnBolumList;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEgitim;
        private System.Windows.Forms.Button btnEgitimList;
        private System.Windows.Forms.Button btnUye;
        private System.Windows.Forms.Button btnUyeList;
    }
}