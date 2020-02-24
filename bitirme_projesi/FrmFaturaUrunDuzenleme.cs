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
    public partial class FrmFaturaUrunDuzenleme : Form
    {
        public FrmFaturaUrunDuzenleme()
        {
            InitializeComponent();
        }
        public string urunid;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmFaturaUrunDuzenleme_Load(object sender, EventArgs e)
        {
            TxtUrunId.Text = urunid;

            SqlCommand komut = new SqlCommand("Select * from tbl_faturadetay where FATURAURUNID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", urunid);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

                TxtFiyat.Text = dr[3].ToString();
                TxtUrunMiktar.Text = dr[2].ToString();
                TxtTutar.Text = dr[4].ToString();
                TxtUrunAd.Text = dr[1].ToString();

                bgl.baglanti().Close();


            }

            

        }

        private void Btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_faturadetay set URUNAD=@P1,MIKTAR=@P2,FIYAT=@P3,TUTAR=@P4 WHERE FATURAURUNID=@P5", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtUrunAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtUrunMiktar.Text);
            komut.Parameters.AddWithValue("@P3",decimal.Parse( TxtFiyat.Text));
            komut.Parameters.AddWithValue("@P4",decimal.Parse (TxtTutar.Text));
            komut.Parameters.AddWithValue("@P5", TxtUrunId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("GÜNCELLEMELER KAYDEDİLDİ!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Faturadetay where FATURAURUNID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtUrunId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("ÜRÜN SİLİNDİ!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    
    }
}

