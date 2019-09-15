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
    public partial class UyeEkle : Form
    {
        SqlConnection baglanti = new SqlConnection("data source =OFRKAKCA; integrated security = SSPI;database = EgitimDB");

        public UyeEkle()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Insert Into Login(TcNo, Sifre, Yetki) Values('"+txtUserName.Text+"', '"+txtSifre.Text+"', '"+(comboBox1.SelectedIndex+1)+"')", baglanti);
                if(cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Kullanıcı kayıtlama başarılı.");
                else
                    MessageBox.Show("Kullanıcı kayıtlanamadı !");
            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı adı kayitli veya boş alan girildi.");
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void UyeEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
