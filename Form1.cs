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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.MaxLength = 8;
            txtPassword.PasswordChar = '*';
        }

        // Giriş Butonu için...
        private void btnLogin_Click(object sender, EventArgs e)
        {
                       SqlConnection baglanti = new SqlConnection("data source = OFRKAKCA;integrated security = SSPI;database = EgitimDB");
lDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Login Where TcNo='"+txtUserName.Text+ "' and Sifre='"+txtPassword.Text + "' ", baglanti);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                this.Hide();
                // dt.Rows[][] Logiin tablosundaki k_Ad => 0, k_Sifre => 1, k_Yetki => 2 olur.
                Form2 form = new Form2(dt.Rows[0][2].ToString(), dt.Rows[0][0].ToString());
                form.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yapıldı",Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Çıkış yapmak için...
        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure ?", Application.CompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


    }
}
