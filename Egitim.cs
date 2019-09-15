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
using Microsoft.SqlServer.Server;

namespace EgitimDBFrom
{
    public partial class Egitim : Form
    {

        SqlConnection baglanti = new SqlConnection("data source = OFRKAKCA;integrated security = SSPI;database = EgitimDB");

        // DataGridViewin hangi kısımda olduğunu (görev-kurs-öğretmen..)
        string forDataTable;


        public Egitim()
        {
            InitializeComponent();
        }

        private void Egitim_Load(object sender, EventArgs e)
        {
            kursAta();

        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select PersonelKurs.OgretmenAd, PersonelKurs.OgretmenSoyad, EgitimKurs.KursAd From PersonelKurs Inner JOIN EgitimKurs On PersonelKurs.Kurs_id = EgitimKurs.Kurs_id ", baglanti);

                /*Select personel.tcNo, personelAd, personelSoyad, kursAd, acilisTarih From Ogretmen 
                 * Inner Join Personel On Ogretmen.tcNo = Personel.tcNo
                 * Inner Join Kurs On Ogretmen.kursNo = Kurs.kursNo
                 * */

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                forDataTable = "PersonelKursOgr";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnOgrenci_Click_1(object sender, EventArgs e)
        {
            OgrenciGoster();
        }

        public void OgrenciGoster()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select Personel.TcNo, Personel.PersonelAd, Personel.PersonelSoyad, EgitimKurs.KursAd From Personel Inner Join PersonelKursOgr On Personel.TcNo = PersonelKursOgr.TcNo Inner Join EgitimKurs On PersonelKursOgr.Kurs_id = EgitimKurs.Kurs_id", baglanti);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                forDataTable = "PersonelKursOgrenci";
            }
            catch (Exception e)
            {
                //throw;
                MessageBox.Show(e.Message);
            }
            

            {
                baglanti.Close();
            }
        }

        public void kursAta() 
        {
            comboKursSecOgretmen.Items.Clear();
            comboKursSecOgrenci.Items.Clear();
            try
            {
                baglanti.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * From EgitimKurs", baglanti);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboKursSecOgretmen.Items.Add(dt.Rows[i][1].ToString());
                    comboKursSecOgrenci.Items.Add(dt.Rows[i][1].ToString());
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }   

        // Ekle butonuna basılınca.
        private void btnEkle_Click(object sender, EventArgs e)
        {
            

            try
            {
                baglanti.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Insert Into EgitimKurs(Kurs_id, KursAd) Values ("+txtKursNo.Text+",'"+txtKursAd.Text+"')", baglanti);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception)
            {
                MessageBox.Show("KursNo Aynı olamaz ! -- Boş alan kalmamalı !");
            }
            finally
            {
                
                baglanti.Close();
                kursAta();
            }
            KursGetir();

        }

        private void txtKurslar_Click(object sender, EventArgs e)
        {
            KursGetir();
        }

        public void KursGetir()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select Kurs_id, KursAd From EgitimKurs", baglanti);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                forDataTable = "EgitimKurs";
            }
            catch (Exception)
            {
                MessageBox.Show("Hata !");
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRapor_Click(object sender, EventArgs e)
        {

        }

        private void btnGorevSaat_Click(object sender, EventArgs e)
        {
            GorevKurs("Select gorevAd as [Görev Adı], sum(kacSaat) as [Kurs Süresi] FROM GorevKurs INNER JOIN Gorev On GorevKurs.gorevNo = Gorev.gorevNo INNER JOIN Kurs On GorevKurs.kursNo = Kurs.kursNo Group By gorevAd Order By [Kurs Süresi] desc");
            forDataTable = "GorevSaat";
        }

        // Görev Ekle Butonuna basınca.
        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Insert into Gorev(Gorev_id, GorevAd) Values("+txtGorevNo.Text+", '"+txtGorevAd.Text+"')", baglanti);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
            }
            catch (Exception)
            {
                //throw;
                MessageBox.Show("Bu Görev Numarası Önceden Girilmiş.");
            }
            finally
            {
                baglanti.Close();
            }
        }

        public void GorevKurs(string query)
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {

            }
            finally
            {
                baglanti.Close();
            }
        }

        // Görevler butonuna tıklayınca.
        private void btnGorevler_Click(object sender, EventArgs e)
        {
            GorevKurs("Select * From Gorev");



            forDataTable = "Gorev"; 
        }

        private void btnAta_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand command = new SqlCommand("Insert into PersonelKurs Values(@OgretmenAd, @OgretmenSoyad, @Kurs_id)", baglanti);
                command.Parameters.AddWithValue("@OgretmenAd", txtOgretmenAd.Text);
                command.Parameters.AddWithValue("@OgretmenSoyad", txtOgretmenSoyad.Text);
                command.Parameters.AddWithValue("@Kurs_id", (comboKursSecOgretmen.SelectedIndex + 1));


                if(command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Eklendi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Tc No Yanlış yada başka bir kursa ait");
            }
            finally
            {
                baglanti.Close();
            }
        }



        // ****************  TxtTcNoOgrenci için 
        private void txtTcNoOgrenci_Enter(object sender, EventArgs e)
        {
            if(txtTcNoOgrenci.Text == "Tc No ")
            {
                txtTcNoOgrenci.Text = "";
                
            }
        }

        private void txtTcNoOgrenci_Leave(object sender, EventArgs e)
        {
            if(txtTcNoOgrenci.Text == "")
            {
                txtTcNoOgrenci.Text = "Tc No ";
                txtTcNoOgrenci.ForeColor = Color.Gray;
            }
        }
        // ****************  TxtTcNoOgrenci

        // ****************  TxtTcNoOgretmen
        private void txtTcNoOgretmen_Enter(object sender, EventArgs e)
        {
            if (txtOgretmenAd.Text == "Tc No ")
            {
                txtOgretmenAd.Text = "";
                //txtBasariNotu.ForeColor = Color.Black;
            }
        }

        private void txtTcNoOgretmen_Leave(object sender, EventArgs e)
        {
            if (txtOgretmenAd.Text == "")
            {
                txtOgretmenAd.Text = "Tc No ";
                txtOgretmenAd.ForeColor = Color.Gray;
            }
        }


        // Ders Al butonuna tıklayınca
        private void btnDersAl_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Insert Into PersonelKursOgr(TcNo, Kurs_id) Values(@tcNo, @kursNo)", baglanti);
                cmd.Parameters.AddWithValue("@tcNo", txtTcNoOgrenci.Text);
                cmd.Parameters.AddWithValue("@kursNo", (comboKursSecOgrenci.SelectedIndex+1));
               

                if(cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Eklendi..");
                else
                    MessageBox.Show("Eklenemedi !");

            }
            catch (Exception)
            {
                MessageBox.Show("Hata !");
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(forDataTable == "PersonelKursOgr")
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    txtOgretmenAd.Text = row.Cells["OgretmenAd"].Value.ToString();
                    txtOgretmenSoyad.Text = row.Cells["OgretmenSoyad"].Value.ToString();
                    comboKursSecOgretmen.Text = row.Cells["KursAd"].Value.ToString();
                  
                }
                else if (forDataTable == "PersonelKursOgrenci")
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    comboKursSecOgrenci.Text = row.Cells["KursAd"].Value.ToString();
                    txtTcNoOgrenci.Text = row.Cells["TcNo"].Value.ToString();
                }
                else if(forDataTable == "PersonelKurs")
                {
                    //DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    //txtOgretmenAd.Text = row.Cells["OgretmenAd"].Value.ToString();
                    //txtOgretmenSoyad.Text = row.Cells["OgretmenSoyad"].Value.ToString();
                }
                else if(forDataTable == "EgitimKurs")
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    txtKursNo.Text = row.Cells["Kurs_id"].Value.ToString();
                    txtKursAd.Text = row.Cells["KursAd"].Value.ToString();
                   
                }
                else if (forDataTable == "Gorev")
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    txtGorevNo.Text = row.Cells["Gorev_id"].Value.ToString();
                    txtGorevAd.Text = row.Cells["GorevAd"].Value.ToString();
                }
                else if(forDataTable == "GorevSaat")
                {

                }
                else
                {
                    MessageBox.Show("Hatalı Güncelleme Denemesi !");
                }

            }
        }

        // Her update için..
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(forDataTable == "PersonelKursOgr")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("Update PersonelKurs Set OgretmenAd = @OgretmenAd, Kurs_id = @Kurs_id, OgretmenSoyad=@OgretmenSoyad Where OgretmenAd = @OgretmenAd AND OgretmenSoyad = @OgretmenSoyad", baglanti);
                    cmd.Parameters.AddWithValue("@OgretmenAd", txtOgretmenAd.Text);
                    cmd.Parameters.AddWithValue("@OgretmenSoyad", txtOgretmenSoyad.Text);
                    cmd.Parameters.AddWithValue("@Kurs_id", (comboKursSecOgrenci.SelectedIndex + 1));
                    
                    if(cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Güncelleme yapıldı !");
                    else
                        MessageBox.Show("Güncelleme hatalı !"); 
                }
                catch (Exception)
                {
                    throw;
                    MessageBox.Show("Hata !");
                }
                finally
                {
                    baglanti.Close();
                }
            }
            if(forDataTable == "PersonelKurs")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("Update PersonelKurs Set OgretmenAd = @OgretmenAd, OgretmenSoyad = @OgretmenSoyad, Kurs_id = @Kurs_id Where OgretmenAd = @OgretmenAd AND OgretmenSoyad = @OgretmenSoyad AND Kurs_id = @Kurs_id", baglanti);
                    cmd.Parameters.AddWithValue("@OgretmenAd", txtOgretmenAd.Text);
                    cmd.Parameters.AddWithValue("@OgretmenSoyad", txtOgretmenSoyad.Text);
                    cmd.Parameters.AddWithValue("@Kurs_id", (comboKursSecOgretmen.SelectedIndex + 1));
                    if(cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Güncelleme yapıldı !");
                    else
                        MessageBox.Show("Güncelleme hatalı !");
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata !");
                }
                finally
                {
                    baglanti.Close();
                }
            }
            if(forDataTable == "EgitimKurs")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("Update EgitimKurs Set Kurs_id = @Kurs_id, KursAd = @KursAd Where Kurs_id = @Kurs_id", baglanti);
                    cmd.Parameters.AddWithValue("@Kurs_id", txtKursNo.Text);
                    cmd.Parameters.AddWithValue("@KursAd", txtKursAd.Text);
                    //cmd.Parameters.AddWithValue("@kacSaat", txtKacSaat.Text);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Güncelleme yapıldı !");
                    else
                        MessageBox.Show("Güncelleme hatalı !");
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata !");
                }
                finally
                {
                    baglanti.Close();
                }
            }
            if(forDataTable == "Gorev")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("Update Gorev Set Gorev_id = @Gorev_id, GorevAd = @GorevAd Where Gorev_id = @Gorev_id", baglanti);
                    cmd.Parameters.AddWithValue("@Gorev_id", txtGorevNo.Text);
                    cmd.Parameters.AddWithValue("@GorevAd", txtGorevAd.Text);
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Güncelleme yapıldı !");
                    else
                        MessageBox.Show("Güncelleme hatalı !");
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata !");
                }
                finally
                {
                    baglanti.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(forDataTable == "PersonelKursOgr")
            {
                try
                {
                    if (MessageBox.Show(txtOgretmenAd.Text + " " + txtOgretmenSoyad.Text + " silinsin mi? ",Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("Delete From PersonelKurs Where OgretmenAd = @OgretmenAd AND  OgretmenSoyad = @OgretmenSoyad", baglanti);
                        baglanti.Open();
                        cmd.Parameters.AddWithValue("@OgretmenAd", txtOgretmenAd.Text);
                        cmd.Parameters.AddWithValue("@OgretmenSoyad", txtOgretmenSoyad.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt silindi..");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata");
                    throw;
                }
                finally
                {
                    baglanti.Close();
                }
            }
            if(forDataTable == "PersonelKurs")
            {
                try
                {
                    if (MessageBox.Show(txtTcNoOgrenci.Text + " silinsin mi ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("Delete From PersonelKurs Where TcNo = @TcNo ", baglanti);
                        baglanti.Open();
                        cmd.Parameters.AddWithValue("@TcNo", txtOgretmenAd.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt silindi..");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata");
                    throw;
                }
                finally
                {
                    baglanti.Close();
                }
            }
            if(forDataTable == "EgitimKurs")
            {
                try
                {
                    if (MessageBox.Show(txtKursNo.Text + " silinsin mi ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("Delete From EgitimKurs Where Kurs_id = @Kurs_id", baglanti);
                        baglanti.Open();
                        cmd.Parameters.AddWithValue("@Kurs_id", txtKursNo.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt silindi..");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata");
                    throw;
                }
                finally
                {
                    baglanti.Close();
                }
            }
            if (forDataTable == "Gorev")
            {
                try
                {
                    if (MessageBox.Show(txtGorevNo.Text + " silinsin mi ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("Delete From Gorev Where Gorev_id = @Gorev_id", baglanti);
                        baglanti.Open();
                        cmd.Parameters.AddWithValue("@Gorev_id", txtGorevNo.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt silindi..");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata");
                    throw;
                }
                finally
                {
                    baglanti.Close();
                }
            }

        }

        private void Egitim_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["Form2"].Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTcNoOgrenci_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void comboKursSecOgrenci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboKursSecOgretmen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
