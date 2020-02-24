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

namespace bitirme_projesi
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBL_ADMIN where Kullaniciad=@p1 and sifre=@p2  ", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", TxtKullaniciadi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                Anasayfa fr = new Anasayfa();
                fr.kullanici = TxtKullaniciadi.Text;
                fr.Show();
                this.Hide();

            }

            else
            {

                MessageBox.Show("HATALI KULLANICI ADI YA DA ŞİFRE GİRİLDİ!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            bgl.baglanti().Close();

        }

        private void TxtKullaniciadi_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
