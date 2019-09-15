using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EgitimDBFrom
{
    public partial class PersonelEkle : Form
    {

        public PersonelEkle()
        {
            InitializeComponent();
        }

        public PersonelEkle(string role)
        {
            if(role == "3")
            {
                InitializeComponent();
                disableRoles();
            }
            else
            {
                InitializeComponent();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            personelEkle();
        }

        // Personel Sil
        public void personelSil()
        {
            SqlConnection baglanti = new SqlConnection("data source = OFRKAKCA;integrated security = SSPI;database = EgitimDB");

            try
            {

                if(MessageBox.Show("Are you sure ? ",Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("Delete From Login Where TcNo = @TcNo ", baglanti);
                    baglanti.Open();
                    cmd.Parameters.AddWithValue("@TcNo", txtTcNo.Text);
                    cmd.ExecuteNonQuery();
                    KayitGetir();
                    MessageBox.Show(txtTcNo.Text + " silindi");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Test");
            }
            finally
            {
                baglanti.Close();
            }

        }

        // Personel Güncelle
        public void personelGuncelle()
        {
            SqlConnection baglanti = new SqlConnection("data source = OFRKAKCA; integrated security = SSPI;database = EgitimDB");
            SqlCommand cmd = new SqlCommand("UPDATE Personel SET TcNo=@TcNo,PersonelAd=@PersonelAd,PersonelSoyad=@PersonelSoyad,PersonelAdres=@PersonelAdres,PersonelTelefon=@PersonelTelefon,PersonelEgitim=@PersonelEgitim,PersonelBolum=@PersonelBolum,PersonelGorev=@PersonelGorev WHERE TcNo=@TcNo", baglanti);

            cmd.Parameters.AddWithValue("@TcNo", txtTcNo.Text);
            cmd.Parameters.AddWithValue("@PersonelAdres", tbAdres.Text);
            cmd.Parameters.AddWithValue("@PersonelTelefon", tbTelefon.Text);

            cmd.Parameters.AddWithValue("@PersonelBolum", comboBolum.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@PersonelGorev", comboGorev.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@PersonelEgitim", comboEgitim.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@PersonelAd", txtPersonelAd.Text);
            cmd.Parameters.AddWithValue("@PersonelSoyad", txtPersonelSoyad.Text);

            try
            {
                baglanti.Open();
                cmd.ExecuteNonQuery();
                KayitGetir();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("Test");
            }
            finally
            {
                baglanti.Close();
            }
        }

        // Personel eklemek için 
        public void personelEkle()
        {
            SqlConnection baglanti = new SqlConnection("data source = OFRKAKCA;integrated security = SSPI;database = EgitimDB");
            SqlCommand cmd2 = new SqlCommand("Insert INTO Login(TcNo) Values(@TcNo2)", baglanti);
            cmd2.Parameters.AddWithValue("@TcNo2", txtTcNo.Text);

            try
            {
                baglanti.Open();
                if(cmd2.ExecuteNonQuery()>0)
                    KayitGetir();
            }
            catch (Exception )
            {
                MessageBox.Show("Test");
            }
            finally {
                baglanti.Close();
            }

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Insert Into Personel(TcNo, PersonelAd, PersonelSoyad, PersonelAdres, PersonelTelefon, PersonelEgitim, PersonelBolum, PersonelGorev) Values(@TcNo, @PersonelAd, @PersonelSoyad, @PersonelAdres, @PersonelTelefon, @PersonelEgitim, @PersonelBolum, @PersonelGorev)", baglanti);


            cmd.Parameters.AddWithValue("@TcNo", txtTcNo.Text);
            cmd.Parameters.AddWithValue("@PersonelEgitim", comboEgitim.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@PersonelGorev", comboGorev.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@PersonelBolum", comboBolum.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@PersonelAd", txtPersonelAd.Text);
            cmd.Parameters.AddWithValue("@PersonelSoyad", txtPersonelSoyad.Text);
            cmd.Parameters.AddWithValue("@PersonelAdres", txtPersonelSoyad.Text);
            cmd.Parameters.AddWithValue("@PersonelTelefon", txtPersonelSoyad.Text);

            


            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    KayitGetir();
                    MessageBox.Show("Eklendi!");
                }
                else
                {
                    MessageBox.Show("Hata!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Aynı TC No Girilemez - Boş alan olmamalı");
            }
            finally
            {
                baglanti.Close();
            }

        }

        // Form yüklendiğinde Tablolar Gelir.
        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            KayitGetir();
        }
        
        // Her işlemden sonra tablo güncelleme
        public void KayitGetir()
        {
            SqlConnection baglanti = new SqlConnection("data source = OFRKAKCA;integrated security = SSPI;database = EgitimDB");
           //SqlDataAdapter adapter = new SqlDataAdapter("Select TcNo as [TC Kimlik], Bolum_ad as [Bölüm Adı], GorevAd as [Görev Adı], KursAd as [Eğitim Adı], PersonelAd as [Personel Adı] , PersonelSoyad as [Personel Soyadı] From Personel Inner Join Bolum On Personel.Bolum = Bolum.Bolum_id Inner Join Gorev On Personel.Gorev_id = Gorev.Gorev_id Inner Join EgitimKurs On Personel.Kurs_id = EgitimKurs.Kurs_id", baglanti);
           SqlDataAdapter adapter = new SqlDataAdapter("Select * From Personel", baglanti);
                   
            /*  Select tcNo as [TC Kimlik], bolumAd as [Bölüm Adı], gorevAd as [GörevAdı], egitimAd as[Eğitim Adı],
             * personelAd as [Personel Adı], personelSoyad as [Personel soyadı] From Personel
             * INNER JOIN Bolum On Personel.bolumNo = bolum.bolumNo
             * Inner JOIN Gorev On Personel.gorevNo = gorev.gorevNo
             * Inner JOIN Egitim On Personel.egitimNo = egitim.egitimNo 
             * 
             **/

            DataTable dt = new DataTable();

            baglanti.Open();

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            baglanti.Close();
        }

        // Her Cell tıkladığımızda 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtPersonelAd.Text = row.Cells["PersonelAd"].Value.ToString();
                txtPersonelSoyad.Text = row.Cells["PersonelSoyad"].Value.ToString();
                comboEgitim.Text = row.Cells["PersonelEgitim"].Value.ToString();
                comboGorev.Text = row.Cells["PersonelGorev"].Value.ToString();
                comboBolum.Text = row.Cells["PersonelBolum"].Value.ToString();
                tbAdres.Text = row.Cells["PersonelAdres"].Value.ToString();
                tbTelefon.Text = row.Cells["PersonelTelefon"].Value.ToString();
                //comboBolum.Text = row.Cells["PersonelTelefon"].Value.ToString();
                txtTcNo.Text = row.Cells["TcNo"].Value.ToString();

                btnPersonelSil.Enabled = true;
            }

        }

        // Context menuden Sağ tık Delete deyince silinmesi için.
        public void personelSilContext(string tcNo)
        {
            SqlConnection baglanti = new SqlConnection("data source = OFRKAKCA;integrated security = SSPI;database = EgitimDB");

            if(tcNo != "")
            {
                try
                {

                    if (MessageBox.Show("Are you sure ? ", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("Delete From Login Where TcNo = @TcNo ", baglanti);
                        baglanti.Open();
                        cmd.Parameters.AddWithValue("@TcNo", txtTcNo.Text);
                        cmd.ExecuteNonQuery();
                        KayitGetir();
                        MessageBox.Show(tcNo + " Silindi");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Hata");
                }
                finally
                {
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Boşluklar silinimez");
            }
            
        }

        // Personel silme butonu
        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            personelSil();
        }

        // Güncelle Butonu
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            personelGuncelle();
        }

        // Her Cell değiştiğinde Buton Aktifleşir
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedCells.Count > 0)
            {
                btnPersonelSil.Enabled = false;
            }
        }

        // Personel Arama
        public void PersonelAra(string query)
        {
            SqlConnection baglanti = new SqlConnection("data source = OFRKAKCA;integrated security = SSPI;database = EgitimDB");
            SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
            DataTable dt = new DataTable();

            try
            {
                baglanti.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            catch (Exception)
            {
                MessageBox.Show("Test");
            }
            finally
            {
                baglanti.Close();
            }

        }

        // ile başlayan
        public void StartWith(string lookFor)
        {
            PersonelAra("Select * FROM Personel WHERE " + lookFor+ " LIKE '" + txtSearch.Text + "%'");
            /*Select tcNo as [TC Kimlik], bolumAd as [Bölüm Adı], gorevAd as [Görev Adı], egitimAd as [Eğitim Adı],
             * personelAd as [Personel Adı], personelSoyad as [Personel Soyadı] FROM Personel 
             * INNER JOIN Bolum ON Personel.bolumNo = Bolum.bolumNo 
             * INNER JOIN Gorev ON Personel.gorevNo = Gorev.gorevNo 
             *  INNER JOIN Egitim ON Personel.egitimNo = Egitim.egitimNo WHERE " + lookFor+ " LIKE '" + txtSearch.Text + "%'
             **/
        }

        // ile biten
        public void EndWith(string lookFor)
        {
            PersonelAra("Select * FROM Personel WHERE " +lookFor+ " LIKE '%" + txtSearch.Text + "'");
        }

        // kelime arasında olanlar
        public void LikeWith(string lookFor)
        {
            PersonelAra("Select * FROM Personel WHERE " + lookFor + " LIKE '%" + txtSearch.Text + "%'");
        }

        // ara butonuna tıklayınca
        private void btnSearch_Click(object sender, EventArgs e)
        {


            if(rdStartWith.Checked)
            {
                StartWith(radioChecked());
            }
            if (rdEndWith.Checked)
            {
                EndWith(radioChecked());
            }
            if (rdLike.Checked)
            {
                LikeWith(radioChecked());
            }
        }

        // Neye göre arama olduğunu hangi butonun checked olduğunu döndürür.
        public string radioChecked()
        {
            if (rdPersonelAd.Checked)
                return "PersonelAd";
            else if (rdPersonelSoyad.Checked)
                return "PersonelSoyad";
            else if (rdPersonelTcNo.Checked)
                return "TcNo";
            else if (rdBolum.Checked)
                return "PersonelBolum";
            else if (rdGorev.Checked)
                return "PersonelGorev";

            return "a";
        }

        // Kayit Getir.
        private void btnListele_Click(object sender, EventArgs e)
        {
            KayitGetir();
        }

        // Textboxa değer girildiğinde arama gerçekleşir.
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rdStartWith.Checked)
            {
                StartWith(radioChecked());
            }
            if (rdEndWith.Checked)
            {
                EndWith(radioChecked());
            }
            if (rdLike.Checked)
            {
                LikeWith(radioChecked());
            }
        }

        // Sağ tıklayınca o satırı seçmesi için.
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                // tablodaki boş satırlara basınca hata vermemesi için.
                try
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dataGridView1.Focus();
                }
                catch (Exception)
                {

                }
                
            }
        }

        // Sağ tıklaması için
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new System.Windows.Forms.ContextMenuStrip();
                int position_xy_mouse_row = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                //MessageBox.Show(position_xy_mouse_row.ToString());

                if (position_xy_mouse_row >= 0)
                {
                    // Context Menuye İtem Ekleme
                    myMenu.Items.Add("Delete").Name = "Delete";
                }

                myMenu.Show(dataGridView1, new Point(e.X, e.Y));
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemClicked);
            }

        }

        // Context menuye tıklayınca.
        public void myMenu_ItemClicked(object Sender, ToolStripItemClickedEventArgs e)
        {

            // Context Menude İsme göre tıklama yapıldığında neler yaptırması için.
            switch (e.ClickedItem.Name.ToString())
            {
                case "Delete":
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;

                    // Seçtiğimiz satırdaki tc no yu alır.
                    string tcNo = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();

                    personelSilContext(tcNo);

                    //MessageBox.Show(e.ClickedItem.Text);
                    break;
            }
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {

        }

        private void btnNewRapor_Click(object sender, EventArgs e)
        {

        }

        public void disableRoles()
        {

            txtPersonelAd.Enabled = false;
            txtPersonelSoyad.Enabled = false;
            txtBolumNo.Enabled = false;
            txtTcNo.Enabled = false;
            comboBolum.Enabled = false;
            comboEgitim.Enabled = false;
            comboGorev.Enabled = false;
            btnGuncelle.Enabled = false;
            btnEkle.Enabled = false;
            btnListele.Enabled = false;
            btnPersonelSil.Enabled = false;
            panel1.Enabled = false;
            panel2.Enabled = false;
            dataGridView1.Enabled = false;

        }

        private void PersonelEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["Form2"].Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBolum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboEgitim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPersonelAd.Clear();
            txtPersonelSoyad.Clear();
            txtTcNo.Clear();
            tbAdres.Clear();
            tbTelefon.Clear();
            comboBolum.Text ="Bölüm Seç";
            comboGorev.Text ="Görev Seç";
            comboEgitim.Text ="Eğitim Seç";
               
        }

        private void lblEgitimNo_Click(object sender, EventArgs e)
        {

        }

    }
}
