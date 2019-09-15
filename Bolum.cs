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
    public partial class Bolum : Form
    {

        SqlConnection baglanti = new SqlConnection("data source = OFRKAKCA;integrated security = SSPI;database = EgitimDB");

        public Bolum()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            bolumList();
        }

        // Listele butonuna basınca..
        public void bolumList()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * From Bolum", baglanti);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
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

        // Ekle butonuna basınca...
        private void btnEkle_Click(object sender, EventArgs e)
        {

            // Stored Procedure ile ..
            //using (SqlConnection baglanti = new SqlConnection("data source = OFRKAKCA;integrated security = SSPI;database = EgitimDB"))
            //{
            //    baglanti.Open();

            //    SqlCommand cmd = new SqlCommand("BolumEkle", baglanti);
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    cmd.Parameters.Add(new SqlParameter("@bolumNo", txtBolumNo.Text));
            //    cmd.Parameters.Add(new SqlParameter("@bolumAd", txtBolumAd.Text));

            //    if (cmd.ExecuteNonQuery() > 0)
            //    {
            //        MessageBox.Show("Eklendi");
            //    }
            //}
                


            // Normal Ekleme
            if (int.Parse(txtBolumNo.Text) >= 0 || txtBolumNo.Text.ToString() == "")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Bolum(Bolum_id, BolumAd) Values(@Bolum_id, @BolumAd)", baglanti);
                    cmd.Parameters.AddWithValue("@Bolum_id", txtBolumNo.Text);
                    cmd.Parameters.AddWithValue("@BolumAd", txtBolumAd.Text);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Ekleme başarılı");

                    }
                    else
                        MessageBox.Show("Ekleme başarısız !");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hatalı giriş yapıldı.");
                }
                finally
                {
                    baglanti.Close();
                }
                txtBolumNo.Text = "";
                txtBolumAd.Text = "";
                bolumList();
            }
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtBolumNo.Text = row.Cells["Bolum_id"].Value.ToString();
                txtBolumAd.Text = row.Cells["BolumAd"].Value.ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Delete From Bolum Where Bolum_id = @Bolum_id", baglanti);
                cmd.Parameters.AddWithValue("@Bolum_id", txtBolumNo.Text);
                if(MessageBox.Show(txtBolumNo.Text+" silinsin mi?",Application.ProductName,MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if(cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Bolum silindi..");
                    else
                        MessageBox.Show("Hata !");
                }
                    
            }
            catch (Exception)
            {
                MessageBox.Show("Hata !");   
            }
            finally
            {
                baglanti.Close();
            }
            txtBolumAd.Text = "";
            txtBolumNo.Text = "";
            bolumList();
        }

        // Rapor butonuna tıklayınca..
        private void btnRapor_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Bolum SET BolumAd = @BolumAd WHERE Bolum_id = " + txtBolumNo.Text + "", baglanti);

                cmd.Parameters.AddWithValue("@BolumAd", txtBolumAd.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Eklendi!");
                    baglanti.Close();
                    bolumList();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hatalı giriş yapıldı.");
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void Bolum_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["Form2"].Show();
        }

        private void Bolum_Load(object sender, EventArgs e)
        {

        }
    }
}
