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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_NOTLAR", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;


        }

        void temizle()
        {
            TxtBaslik.Text = "";
            TxtHitap.Text = "";
            TxtId.Text = "";
            TxtOlusturan.Text = "";
            MskSaat.Text = "";
            MskTarih.Text = "";
            RchDetay.Text = "";




        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void Btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_NOTLAR (TARIH,SAAT,BASLIK,DETAY,OLUSTURAN,HITAP) values " +
                "(@P1,@P2,@P3,@P4,@P5,@P6)", bgl.baglanti());

            komut.Parameters.AddWithValue("@P1", MskTarih.Text);
            komut.Parameters.AddWithValue("@P2", MskSaat.Text);
            komut.Parameters.AddWithValue("@P3", TxtBaslik.Text);
            komut.Parameters.AddWithValue("@P4", RchDetay.Text);
            komut.Parameters.AddWithValue("@P5", TxtOlusturan.Text);
            komut.Parameters.AddWithValue("@P6", TxtHitap.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("NOT EKLEME İŞLEMİNİZ BAŞARI İLE TAMAMLANDI!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtBaslik.Text = dr["BASLIK"].ToString();
                RchDetay.Text = dr["DETAY"].ToString();
                TxtOlusturan.Text = dr["OLUSTURAN"].ToString();
                TxtHitap.Text = dr["HITAP"].ToString();
                MskTarih.Text = dr["TARIH"].ToString();
                MskSaat.Text = dr["SAAT"].ToString();


            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void Btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Notlar where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("NOT SİLME İŞLEMİ BAŞARI İLE TAMAMLANDI", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_NOTLAR SET TARIH=@P1,SAAT=@P2,BASLIK=@P3,DETAY=@P4,OLUSTURAN=@P5,HITAP=@P6 where ID=@P7", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", MskTarih.Text);
            komut.Parameters.AddWithValue("@P2", MskSaat.Text);
            komut.Parameters.AddWithValue("@P3", TxtBaslik.Text);
            komut.Parameters.AddWithValue("@P4", RchDetay.Text);
            komut.Parameters.AddWithValue("@P5", TxtOlusturan.Text);
            komut.Parameters.AddWithValue("@P6", TxtHitap.Text);
            komut.Parameters.AddWithValue("@p7", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("NOT GÜNCELLEME İŞLEMİNİZ BAŞARI İLE TAMAMLANDI!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmNotDetay fr = new FrmNotDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fr.metin = dr["DETAY"].ToString();


            }
            fr.Show();
        }
    }
}
