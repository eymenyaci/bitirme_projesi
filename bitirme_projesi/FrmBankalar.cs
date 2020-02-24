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
    public partial class FrmBankalar : Form
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select TBL_BANKALAR.ID,Bankaadı,TBL_BANKALAR.IL,TBL_BANKALAR.ILCE, sube , ıban,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU, Ad from tbl_bankalar inner join TBL_FIRMALAR on tbl_bankalar.FIRMAID=TBL_FIRMALAR.Id", bgl.baglanti());
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
        void firmalistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,Ad from tbl_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;
        }
        void temizle()
        {

            TxtAd.Text = "";
            TxtHesapNo.Text = "";
            TxtHesapturu.Text = "";
            TxtIban.Text = "";
            TxtId.Text = "";
            TxtSube.Text = "";
            TxtYetkili.Text = "";
            Cmbİl.Text = "";
            Cmbİlce.Text = "";
            MskTarih.Text = "";
            MskTelefon.Text = "";
            lookUpEdit1.Text = "";
        }
        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistesi();
            firmalistesi();
            temizle();


        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_BANKALAR (BANKAADI,IL,ILCE,SUBE,IBAN,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU,FIRMAID)" +
                "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", Cmbİl.Text);
            komut.Parameters.AddWithValue("@p3", Cmbİlce.Text);
            komut.Parameters.AddWithValue("@p4", TxtSube.Text);
            komut.Parameters.AddWithValue("@p5", TxtIban.Text);
            komut.Parameters.AddWithValue("@p6", TxtHesapNo.Text);
            komut.Parameters.AddWithValue("@p7", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@p8", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p9", MskTarih.Text);
            komut.Parameters.AddWithValue("@p10", TxtHesapturu.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("BANKA BİLGİSİ SİSTEME KAYDEDİLDİ!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                TxtAd.Text = dr["BANKAADI"].ToString();
                Cmbİl.Text = dr["IL"].ToString();
                Cmbİlce.Text = dr["ILCE"].ToString();
                TxtSube.Text = dr["SUBE"].ToString();
                TxtIban.Text = dr["IBAN"].ToString();
                TxtHesapNo.Text = dr["HESAPNO"].ToString();
                TxtYetkili.Text = dr["YETKILI"].ToString();
                MskTelefon.Text = dr["TELEFON"].ToString();
                MskTarih.Text = dr["TARIH"].ToString();
                TxtHesapturu.Text = dr["HESAPTURU"].ToString();
               


            }
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from tbl_bankalar where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            temizle();
            MessageBox.Show("BANKA BİLGİSİ SİSTEMDEN SİLİNDİ!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void Btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update tbl_bankalar set BANKAADI=@P1,IL=@P2,ILCE=@P3,SUBE=@P4,IBAN=@P5,HESAPNO=@P6,YETKILI=@P7,TELEFON=@P8," +
                "TARIH=@P9,HESAPTURU=@P10,FIRMAID=@P11 where ID=@P12",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", Cmbİl.Text);
            komut.Parameters.AddWithValue("@p3", Cmbİlce.Text);
            komut.Parameters.AddWithValue("@p4", TxtSube.Text);
            komut.Parameters.AddWithValue("@p5", TxtIban.Text);
            komut.Parameters.AddWithValue("@p6", TxtHesapNo.Text);
            komut.Parameters.AddWithValue("@p7", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@p8", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p9", MskTarih.Text);
            komut.Parameters.AddWithValue("@p10", TxtHesapturu.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            komut.Parameters.AddWithValue("@p12", TxtId.Text);
            komut.ExecuteNonQuery();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("BANKA BİLGİSİ GÜNCELLENDİ!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
