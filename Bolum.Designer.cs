namespace EgitimDBFrom
{
    partial class Bolum
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
            this.lblBolumNo = new System.Windows.Forms.Label();
            this.txtBolumNo = new System.Windows.Forms.TextBox();
            this.lblBolumAd = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBolumAd = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBolumNo
            // 
            this.lblBolumNo.AutoSize = true;
            this.lblBolumNo.Location = new System.Drawing.Point(12, 9);
            this.lblBolumNo.Name = "lblBolumNo";
            this.lblBolumNo.Size = new System.Drawing.Size(56, 13);
            this.lblBolumNo.TabIndex = 0;
            this.lblBolumNo.Text = "Bölüm No:";
            // 
            // txtBolumNo
            // 
            this.txtBolumNo.Location = new System.Drawing.Point(74, 6);
            this.txtBolumNo.Name = "txtBolumNo";
            this.txtBolumNo.Size = new System.Drawing.Size(100, 20);
            this.txtBolumNo.TabIndex = 1;
            // 
            // lblBolumAd
            // 
            this.lblBolumAd.AutoSize = true;
            this.lblBolumAd.Location = new System.Drawing.Point(12, 39);
            this.lblBolumAd.Name = "lblBolumAd";
            this.lblBolumAd.Size = new System.Drawing.Size(55, 13);
            this.lblBolumAd.TabIndex = 2;
            this.lblBolumAd.Text = "Bölüm Ad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(284, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtBolumAd
            // 
            this.txtBolumAd.Location = new System.Drawing.Point(74, 36);
            this.txtBolumAd.Name = "txtBolumAd";
            this.txtBolumAd.Size = new System.Drawing.Size(100, 20);
            this.txtBolumAd.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.OliveDrab;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEkle.Location = new System.Drawing.Point(180, 6);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 50);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRapor.Location = new System.Drawing.Point(12, 79);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(75, 26);
            this.btnRapor.TabIndex = 6;
            this.btnRapor.Text = "Güncelle";
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Chocolate;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnList.Location = new System.Drawing.Point(104, 79);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 26);
            this.btnList.TabIndex = 7;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Brown;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSil.Location = new System.Drawing.Point(196, 79);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 26);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Bölüm Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Bolum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtBolumAd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblBolumAd);
            this.Controls.Add(this.txtBolumNo);
            this.Controls.Add(this.lblBolumNo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bolum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bolum";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bolum_FormClosed);
            this.Load += new System.EventHandler(this.Bolum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBolumNo;
        private System.Windows.Forms.TextBox txtBolumNo;
        private System.Windows.Forms.Label lblBolumAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBolumAd;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnSil;
    }
}