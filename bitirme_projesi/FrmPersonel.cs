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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void personelliste()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_PERSONELLER",bgl.baglanti());
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
            TxtId.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtGorev.Text = "";
            TxtMail.Text = "";
            MskTC.Text = "";
            MskTelefon1.Text = "";
            Cmbİl.Text = "";
            Cmbİlce.Text = "";


        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            personelliste();
            sehirlistesi();
            temizle();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_PERSONELLER(AD,SOYAD," +
                "TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV)" +
                " values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)",bgl.baglanti());

            komut.Parameters.AddWithValue("@P1", TxtAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", MskTelefon1.Text);
            komut.Parameters.AddWithValue("@P4", MskTC.Text);
            komut.Parameters.AddWithValue("@P5", TxtMail.Text);
            komut.Parameters.AddWithValue("@P6", Cmbİl.Text);
            komut.Parameters.AddWithValue("@P7", Cmbİlce.Text);
            komut.Parameters.AddWithValue("@P8", rchAdres.Text);
            komut.Parameters.AddWithValue("@P9",TxtGorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("PERSONEL SİSTEME BAŞARI İLE EKLENDİ!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            personelliste();
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtAd.Text = dr["AD"].ToString();
                TxtSoyad.Text = dr["SOYAD"].ToString();
                MskTelefon1.Text= dr["TELEFON"].ToString();
                MskTC.Text= dr["TC"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                Cmbİl.Text= dr["IL"].ToString();
                Cmbİlce.Text = dr["ILCE"].ToString();
                rchAdres.Text = dr["ADRES"].ToString();
                TxtGorev.Text = dr["GOREV"].ToString();



            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete from TBL_PERSONELLER where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", TxtId.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("PERSONEL SİSTEMDEN BAŞARI İLE SİLİNDİ!", "Bilgi", 
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
            personelliste();
            temizle();


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_personeller set AD=@P1,SOYAD=@P2," +
                "TELEFON=@P3,TC=@P4,MAIL=@P5,IL=@P6,ILCE=@P7,ADRES=@P8,GOREV=@P9 where ID=@P10",bgl.baglanti());

            komut.Parameters.AddWithValue("@P1", TxtAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", MskTelefon1.Text);
            komut.Parameters.AddWithValue("@P4", MskTC.Text);
            komut.Parameters.AddWithValue("@P5", TxtMail.Text);
            komut.Parameters.AddWithValue("@P6", Cmbİl.Text);
            komut.Parameters.AddWithValue("@P7", Cmbİlce.Text);
            komut.Parameters.AddWithValue("@P8", rchAdres.Text);
            komut.Parameters.AddWithValue("@P9", TxtGorev.Text);
            komut.Parameters.AddWithValue("@P10", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("PERSONEL BİLGİLERİ BAŞARI İLE GÜNCELLENDİ!", "Bilgi", 
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
            personelliste();

        }
    }
}
