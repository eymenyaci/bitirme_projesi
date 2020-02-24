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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }


        sqlbaglantisi bgl = new sqlbaglantisi();

        void firmalistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_FIRMALAR",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void temizle()
        {
            TxtAd.Text = "";
            TxtId.Text = "";
            TxtYetkiliGorev.Text = "";
            TxtYetkili.Text = "";
            MskTelefon1.Text = "";
            MskTelefon2.Text = "";
            MskTelefon3.Text = "";
            TxtMail.Text = "";
            MskFax.Text = "";
            
            TxtVergi.Text = "";
            rchAdres.Text = "";
            YetkiliTcKimlik.Text = "";
            TxtKod1.Text = "";
            TxtKod2.Text = "";
            TxtKod3.Text = "";
            TxtSektor.Text = "";
            Cmbİl.Text = "";
            Cmbİlce.Text = "";




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

        void carikodaciklamalar()
        {
            SqlCommand komut = new SqlCommand("Select FIRMAKOD1 from tbl_kod", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                rchkod1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
         }
        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            firmalistesi();
            temizle();
            sehirlistesi();
            carikodaciklamalar();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtAd.Text = dr["AD"].ToString();
                TxtYetkiliGorev.Text = dr["YETKILISTATU"].ToString();
                TxtYetkili.Text = dr["YETKILIADSOYAD"].ToString();
                MskTelefon1.Text = dr["TELEFON1"].ToString();
                MskTelefon2.Text = dr["TELEFON2"].ToString();
                MskTelefon3.Text = dr["TELEFON3"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                MskFax.Text = dr["FAX"].ToString();
                Cmbİl.Text = dr["IL"].ToString();
                Cmbİlce.Text = dr["ILCE"].ToString();
                TxtVergi.Text = dr["VERGIDAIRESI"].ToString();
                rchAdres.Text = dr["ADRES"].ToString();
                YetkiliTcKimlik.Text = dr["YETKILITC"].ToString();
                TxtKod1.Text = dr["OZELKOD1"].ToString();
                TxtKod2.Text = dr["OZELKOD2"].ToString();
                TxtKod3.Text = dr["OZELKOD3"].ToString();
                TxtSektor.Text = dr["SEKTOR"].ToString();





            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_FIRMALAR (AD,YETKILISTATU,YETKILIADSOYAD,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX," +
                "IL,ILCE,VERGIDAIRESI,ADRES,YETKILITC,OZELKOD1,OZELKOD2,OZELKOD3,SEKTOR) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtYetkiliGorev.Text);
            komut.Parameters.AddWithValue("@p3", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefon1.Text);
            komut.Parameters.AddWithValue("@p5", MskTelefon2.Text);
            komut.Parameters.AddWithValue("@p6", MskTelefon3.Text);
            komut.Parameters.AddWithValue("@p7", TxtMail.Text);
            komut.Parameters.AddWithValue("@p8", MskFax.Text);
            komut.Parameters.AddWithValue("@p9", Cmbİl.Text);
            komut.Parameters.AddWithValue("@p10", Cmbİlce.Text);
            komut.Parameters.AddWithValue("@p11", TxtVergi.Text);
            komut.Parameters.AddWithValue("@p12", rchAdres.Text);
            komut.Parameters.AddWithValue("@p13", YetkiliTcKimlik.Text);
            komut.Parameters.AddWithValue("@p14", TxtKod1.Text);
            komut.Parameters.AddWithValue("@p15", TxtKod2.Text);
            komut.Parameters.AddWithValue("@p16", TxtKod3.Text);
            komut.Parameters.AddWithValue("@p17", TxtSektor.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("FİRMA SİSTEME KAYDEDİLDİ!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmalistesi();
            temizle();
        }

        private void Cmbİl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmbİlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ilce from TBL_ILCELER where sehir=@p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Cmbİl.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbİlce.Properties.Items.Add(dr[0]);


            }
            bgl.baglanti().Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_FIRMALAR where ID=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            firmalistesi();
            MessageBox.Show("FİRMA LİSTEDEN SİLİNDİ!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            temizle();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_FIRMALAR set AD=@p1,YETKILISTATU=@p2," +
                "YETKILIADSOYAD=@p3,YETKILITC=@p4,SEKTOR=@p5,TELEFON1=@p6,TELEFON2=@p7,TELEFON3=@p8," +
                "MAIL=@p9,FAX=@p10,IL=@p11,ILCE=@p12,VERGIDAIRESI=@p13,ADRES=@p14," +
                "OZELKOD1=@p15,OZELKOD2=@p16,OZELKOD3=@p17 WHERE ID=@p18", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtYetkiliGorev.Text);
            komut.Parameters.AddWithValue("@p3", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@p4", YetkiliTcKimlik.Text);
            komut.Parameters.AddWithValue("@p5", TxtSektor.Text);
            komut.Parameters.AddWithValue("@p6", MskTelefon1.Text);
            komut.Parameters.AddWithValue("@p7", MskTelefon2.Text);
            komut.Parameters.AddWithValue("@p8", MskTelefon3.Text);
            komut.Parameters.AddWithValue("@p9", TxtMail.Text);
            komut.Parameters.AddWithValue("@p10", MskFax.Text);
            komut.Parameters.AddWithValue("@p11", Cmbİl.Text);
            komut.Parameters.AddWithValue("@p12", Cmbİlce.Text);
            
            komut.Parameters.AddWithValue("@p13", TxtVergi.Text);
            komut.Parameters.AddWithValue("@p14", rchAdres.Text);
            komut.Parameters.AddWithValue("@p15", TxtKod1.Text);
            komut.Parameters.AddWithValue("@p16", TxtKod2.Text);
            komut.Parameters.AddWithValue("@p17", TxtKod3.Text);
            komut.Parameters.AddWithValue("@p18", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("FİRMA BİLGİLERİ GÜNCELLENDİ!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmalistesi();
            temizle();






        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
