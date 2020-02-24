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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        //SQL BAĞLANTISINI İSİM ATADIM.
        sqlbaglantisi bgl = new sqlbaglantisi();

        // BAĞLANTI SAĞLAYACAK METODU OLUŞTURDUM.
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_URUNLER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;


        }
        void temizle()
        {
            TxtAd.Text = "";
            TxtAlis.Text = "";
            TxtId.Text = "";
            TxtMarka.Text = "";
            TxtModel.Text = "";
            TxtSatis.Text = "";
            MskYil.Text = "";
            NudAdet.Value = 0;
            RchDetay.Text = "";

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //VERİLERİ KAYDEDECEĞİM.
            //SQLCOMMAND İLE TBL_URUNLER TABLOSU İLE BAĞLANTI KURDUM.
            SqlCommand komut = new SqlCommand("insert into TBL_URUNLER(URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti()); 
               
            
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
            komut.Parameters.AddWithValue("p3", TxtModel.Text);
            komut.Parameters.AddWithValue("@p4", MskYil.Text);
            //VERİTABANIMDA DECİMAL DEĞER KULLANDIĞIM İÇİN ALIŞ VE SATIŞTA DECİMAL OLARAK BELİRTTİM.
            komut.Parameters.AddWithValue("@p5", int.Parse((NudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtAlis.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtSatis.Text));
            komut.Parameters.AddWithValue("@p8", RchDetay.Text);
            komut.ExecuteNonQuery(); // İLE SORGULAR ÇALIŞIYOR.
            bgl.baglanti().Close();//BAĞLANTIYI KAPAT.
            
            MessageBox.Show("ÜRÜN SİSTEME BAŞARI İLE EKLENDİ!","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            temizle();




                }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_URUNLER where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", TxtId.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("ÜRÜN SİLİNDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();


        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtId.Text = dr["ID"].ToString();
            TxtAd.Text = dr["URUNAD"].ToString();
            TxtMarka.Text = dr["MARKA"].ToString();
           TxtModel.Text = dr["MODEL"].ToString();
            MskYil.Text = dr["YIL"].ToString();
            NudAdet.Value = decimal.Parse(dr["ADET"].ToString());
            TxtAlis.Text = dr["ALISFIYAT"].ToString();
            TxtSatis.Text = dr["SATISFIYAT"].ToString();




        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_URUNLER set URUNAD=@P1,MARKA=@P2,MODEL=@P3,YIL=@P4,ADET=@P5,ALISFIYAT=@P6,SATISFIYAT=@P7,DETAY=@P8 where ID=@P9", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
            komut.Parameters.AddWithValue("p3", TxtModel.Text);
            komut.Parameters.AddWithValue("@p4", MskYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((NudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtAlis.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtSatis.Text));
            komut.Parameters.AddWithValue("@p8", RchDetay.Text);
            komut.Parameters.AddWithValue("@P9", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("ÜRÜN BİLGİSİ GÜNCELLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();



        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void FrmUrunler_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
