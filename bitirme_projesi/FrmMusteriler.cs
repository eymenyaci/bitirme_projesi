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
    public partial class Müşteriler : Form
    {
        public Müşteriler()
        {
            InitializeComponent();
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_MUSTERILER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }


        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("Select sehir from TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbİl.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();

        }
        void temizle()
        {
            TxtAd.Text = "";
            TxtId.Text = "";
            TxtMail.Text = "";
            TxtSoyad.Text = "";
            TxtVergi.Text = "";
            Cmbİl.Text = "";
            Cmbİlce.Text = "";
            MskTC.Text = "";
            MskTelefon1.Text = "";
            MskTelefon2.Text = "";
            rchAdres.Text = "";
        }
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistesi();
            listele();
            temizle();

        }

        private void Cmbİl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmbİlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ilce from TBL_ILCELER where sehir=@p1 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Cmbİl.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbİlce.Properties.Items.Add(dr[0]);


            }
            bgl.baglanti().Close();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_MUSTERILER (AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,ADRES,VERGIDAIRE) values " +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7," +
                "@p8,@p9,@p10)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2",TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTelefon1.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefon2.Text);
            komut.Parameters.AddWithValue("@p5", MskTC.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);
            komut.Parameters.AddWithValue("@p7", Cmbİl.Text);
            komut.Parameters.AddWithValue("@p8", Cmbİlce.Text);
            komut.Parameters.AddWithValue("@p9", rchAdres.Text);
            komut.Parameters.AddWithValue("@p10", TxtVergi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("MÜŞTERİ SİSTEME EKLENDİ!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtAd.Text = dr["AD"].ToString();
                TxtSoyad.Text = dr["SOYAD"].ToString();
                MskTelefon1.Text = dr["TELEFON"].ToString();
                MskTelefon2.Text = dr["TELEFON2"].ToString();
                MskTC.Text = dr["TC"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                Cmbİl.Text = dr["IL"].ToString();
                Cmbİlce.Text = dr["ILCE"].ToString();
                TxtVergi.Text = dr["VERGIDAIRE"].ToString();
                rchAdres.Text = dr["ADRES"].ToString();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_MUSTERILER where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("p1", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("MÜŞTERİ SİLİNDİ!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            listele();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_MUSTERILER set AD=@p1, SOYAD=@p2, TELEFON=@p3,TELEFON2=@p4,TC=@p5,MAIL=@p6,IL=@p7,ILCE=@p8,VERGIDAIRE=@p9,ADRES=@p10" +
                "  where ID=@p11",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTelefon1.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefon2.Text);
            komut.Parameters.AddWithValue("@p5", MskTC.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);
            komut.Parameters.AddWithValue("@p7", Cmbİl.Text);
            komut.Parameters.AddWithValue("@p8", Cmbİlce.Text);
            komut.Parameters.AddWithValue("@p9", TxtVergi.Text);
            komut.Parameters.AddWithValue("@p10", rchAdres.Text);
            komut.Parameters.AddWithValue("@p11", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("MÜŞTERİ BİLGİSİ GÜNCELLENDİ!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();


        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
