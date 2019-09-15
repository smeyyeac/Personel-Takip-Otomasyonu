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


    public partial class Form2 : Form
    {

        SqlConnection baglanti = new SqlConnection("data source = OFRKAKCA;integrated security = SSPI;database = EgitimDB");

        // Paging için ..
        int index = 0;
        int pageSize = 5;

        string sqlEgitim;


        // Önceki formdaki yetkiyi bu forma almak için.
        private string yetkiDuzey;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string role, string user)
        {
            InitializeComponent();
            lblYetki.Text = role;
            if (role == "1")
                lblYetki.Text = role + " (Yönetici)";
            else if (role == "2")
                lblYetki.Text = role + " (Memur)";
            else if (role == "3")
                lblYetki.Text = role + " (Eğitim)";

            yetkiDuzey = role;
            // Kullanıcı Adını ekrana girer
            lblPass.Text = "Kullanıcı Adı: " + "(" + user+ ")";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(yetkiDuzey == "2")
            {
                btnBolumEkle.Enabled = false;
                btnUye.Visible = false;
                btnUyeList.Visible = false;
                btnEgitim.Enabled = false;
                btnPersonelEkle.Enabled = true;
            }
            else if(yetkiDuzey == "3")
            {
                btnUye.Visible = false;
                btnUyeList.Visible = false;
                btnEgitim.Enabled = true;
                btnPersonelEkle.Enabled = false;
                btnBolumEkle.Enabled = false;
            }
        }

        public string getRole()
        {
            return yetkiDuzey;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }


        // Personel ekle butonuna basınca..
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form2"].Hide();
            if(yetkiDuzey == "3")
            {
                PersonelEkle p = new PersonelEkle(yetkiDuzey);
                p.Show();
            }
            else
            {
                PersonelEkle form = new PersonelEkle();
                form.Show();
            }
        }

        // Personel Personel Listele butonuna basıldığında
        private void btnPersonelList_Click(object sender, EventArgs e)
        {
            Listele("Select * From Personel");
        }

        // Bölüm Bölüm Listele butonuna basıldığında
        private void btnBolumList_Click(object sender, EventArgs e)
        {
            Listele("Select * From Bolum");
        }

        // Her Listele Butonuna basınca o tabloya ait bilgiler gelir.
        public void Listele(string query)
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
                MessageBox.Show("Hata");
            }
            finally
            {
                baglanti.Close();
            }

        }

        // Her Görev Listele butonuna basıldığında
        private void btnGorevList_Click(object sender, EventArgs e)
        {
            Listele("Select tcNo as [TC Kimlik], personelAd as [Personel Adı],personelSoyad as [Personel Soyadı], bolumAd as [Bölüm Adı], gorevAd as[Görev Adı]From Personel INNER JOIN Bolum on personel.bolumNo = bolum.bolumNo INNER JOIN Gorev on personel.gorevNo = gorev.gorevNo");
            //Listele("Select gorevNo as [Görev No], gorevAd as [Görev Ad] FROM Gorev");
        }

        // Görevler-Kurslar için..
        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select gorevAd as [Görev Adı], kursAd as[Kurs Adı] FROM GorevKurs INNER JOIN Gorev On GorevKurs.gorevNo = Gorev.gorevNo INNER JOIN Kurs On GorevKurs.kursNo = Kurs.kursNo", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            try
            {
                baglanti.Open();
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!");
                throw;
            }
            finally
            {
                baglanti.Close();
            }


        }

        // Checkboxlar değiştiğinde 
        public void sqlCheckBox(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            try
            {
                baglanti.Open();
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

        // Sağa tıkla
        private void btnRight_Click(object sender, EventArgs e)
        {
            index += 1;

            Paging_left_right("Right");
            //btnLeft.Enabled = true;
        }

        // Sola tıkla
        private void btnLeft_Click(object sender, EventArgs e)
        {

        }

        // Left Right Paging için tek fonksyon.
        public void Paging_left_right(string info)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From (Select ROW_NUMBER() OVER (Order By tcNo asc) as Sıra, * From Personel) Personel Where Sıra Between (((" + (index - 1) + ") * " + pageSize + " ) + 1) AND " + (pageSize * index) + "", baglanti);
            DataTable dt = new DataTable();

            try
            {
                baglanti.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

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

        private void btnRapor_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            if(MessageBox.Show("Çıkış yapılıyor ?",Application.ProductName, MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (Application.OpenForms["Bolum"] != null)
                    Application.OpenForms["Bolum"].Close();
                if (Application.OpenForms["Egitim"] != null)
                    Application.OpenForms["Egitim"].Close();
                if (Application.OpenForms["PersonelEkle"] != null)
                    Application.OpenForms["PersonelEkle"].Close();
                if (Application.OpenForms["Rapor"] != null)
                    Application.OpenForms["Rapor"].Close();
                if (Application.OpenForms["RaporBolum"] != null)
                    Application.OpenForms["RaporBolum"].Close();
                if (Application.OpenForms["RaporEgitim"] != null)
                    Application.OpenForms["RaporEgitim"].Close();
                if (Application.OpenForms["UyeEkle"] != null)
                    Application.OpenForms["UyeEkle"].Close();

                closeForm();
                Form1 login = new Form1();
                login.Show();
            }
            else
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
        }

        public void closeForm()
        {
            Form2 f2 = new Form2();
            f2.Close();
        }

        // Eğitim butonuna basınca.
        private void btnEgitim_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form2"].Hide();
            Egitim form = new Egitim();
            form.Show();
        }

        // Bölüm ekle butonuna tıklayınca.
        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["Bolum"] != null)
            {
                Application.OpenForms["Bolum"].Focus();
            }
            else
            {
                Application.OpenForms["Form2"].Hide();
                Bolum bolum = new Bolum();
                bolum.Show();
            }
        }

        // Eğitim listele butonuna tıklayınca.
        private void btnEgitimList_Click(object sender, EventArgs e)
        {
            sqlEgitim = "Select * From EgitimKurs";
            exeEgitim(sqlEgitim);
        }

        public void exeEgitim(string sqlCommand)
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, baglanti);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
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

        // Üye Listele
        private void btnUyeList_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * From Login", baglanti);
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

        // Üye Ekle Butonuna basınca..
        private void btnUye_Click(object sender, EventArgs e)
        {
            if((Application.OpenForms["UyeEkle"] as UyeEkle) != null)
            {
                Application.OpenForms["UyeEkle"].Focus();
            }
            else
            {
                UyeEkle form = new UyeEkle();
                form.Show();
            }
            //UyeEkle form = new UyeEkle();
            //form.Show();
        }
    }
}
