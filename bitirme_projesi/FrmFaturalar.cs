﻿using System;
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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
      void faturalistele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_FATURABILGI", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;


        }

        void temizle()
        {
            TxtAlici.Text = "";
            TxtId.Text = "";
            TxtSeriNo.Text = "";
            TxtSiraNo.Text = "";
            TxtVergi.Text = "";
            TxtTeslimalan.Text = "";
            TxtTeslimeden.Text = "";
            MskSaat.Text = "";
            MskTarih.Text = "";





        }
        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            faturalistele();
            temizle();
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (TxtFaturaId.Text == "")
            {
                SqlCommand komut = new SqlCommand("insert into TBL_FATURABILGI(SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) VALUES " +
                    "(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", TxtSeriNo.Text);
                komut.Parameters.AddWithValue("@P2", TxtSiraNo.Text);
                komut.Parameters.AddWithValue("@P3", MskTarih.Text);
                komut.Parameters.AddWithValue("@P4", MskSaat.Text);
                komut.Parameters.AddWithValue("@P5", TxtVergi.Text);
                komut.Parameters.AddWithValue("@P6", TxtAlici.Text);
                komut.Parameters.AddWithValue("@P7", TxtTeslimeden.Text);
                komut.Parameters.AddWithValue("@P8", TxtTeslimalan.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("FATURA BİLGİSİ SİSTEME KAYDEDİLDİ!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                faturalistele();
                
            }
            if(TxtFaturaId.Text!="")
            {

                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(TxtFiyat.Text);
                miktar = Convert.ToDouble(TxtUrunMiktar.Text);
                tutar = miktar * fiyat;
                TxtTutar.Text = tutar.ToString();




                SqlCommand komut2 = new SqlCommand("insert into TBL_FATURADETAY (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) VALUES " +
                    "(@P1,@P2,@P3,@P4,@P5)", bgl.baglanti());


                komut2.Parameters.AddWithValue("@P1", TxtUrunAd.Text);
                komut2.Parameters.AddWithValue("@P2", TxtUrunMiktar.Text);
                komut2.Parameters.AddWithValue("@P3",decimal.Parse(TxtFiyat.Text));
                komut2.Parameters.AddWithValue("@P4",decimal.Parse( TxtTutar.Text));
                komut2.Parameters.AddWithValue("@P5",Int32.Parse( TxtFaturaId.Text));
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();

                //HAREKET TABLOSUNA VERİ GİRİŞİ
                SqlCommand komut3 = new SqlCommand("insert into tbl_fırmahareketler (Urunıd,adet,personel,fırma,fıyat,toplam,faturaıd,tarıh) values " +
                    "(@h1,@h2,@h3,@h4,@h5,@h6,@h7)", bgl.baglanti());
                komut3.Parameters.AddWithValue("@h1", TxtUrunId.Text);
                komut3.Parameters.AddWithValue("@h2", TxtUrunMiktar.Text);
                komut3.Parameters.AddWithValue("@h3", TxtPersonel.Text);
                komut3.Parameters.AddWithValue("@h4", txtfirma.Text);
                komut3.Parameters.AddWithValue("@h5",decimal.Parse( TxtFiyat.Text));
                komut3.Parameters.AddWithValue("@h6", decimal.Parse(TxtTutar.Text));
                komut3.Parameters.AddWithValue("@h7", TxtFaturaId.Text);
                komut3.Parameters.AddWithValue("@h8", MskTarih.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();


                //Stok sayısını azaltma

                SqlCommand komut4 = new SqlCommand("update tbl_urunler set adet=adet-@s1 where Id=@s2", bgl.baglanti());
                komut4.Parameters.AddWithValue("@s1", TxtUrunMiktar.Text);
                komut4.Parameters.AddWithValue("@s2", TxtUrunId.Text);
                komut4.ExecuteNonQuery();
                bgl.baglanti().Close();


                MessageBox.Show("FATURAYA AİT ÜRÜN SİSTEME KAYDEDİLDİ!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtId.Text = dr["FATURABILGIID"].ToString();
                TxtSiraNo.Text = dr["SIRANO"].ToString();
                TxtSeriNo.Text = dr["SERI"].ToString();
                MskTarih.Text = dr["TARIH"].ToString();
                MskSaat.Text = dr["SAAT"].ToString();
                TxtAlici.Text = dr["ALICI"].ToString();
                TxtTeslimeden.Text = dr["TESLIMEDEN"].ToString();
                TxtTeslimalan.Text = dr["TESLIMALAN"].ToString();
                TxtVergi.Text = dr["VERGIDAIRE"].ToString();






            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_FATURABILGI where FATURABILGIID=@p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("FATURA SİLME İŞLEMİ BAŞARI İLE TAMAMLANDI!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            faturalistele();
        }

        private void Btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_FATURABILGI set SERI=@P1,SIRANO=@P2,TARIH=@P3,SAAT=@P4,VERGIDAIRE=@P5,ALICI=@P6,TESLIMALAN=@P7,TESLIMEDEN=@P8 WHERE FATURABILGIID=@P9", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtSeriNo.Text);
            komut.Parameters.AddWithValue("@P2", TxtSiraNo.Text);
            komut.Parameters.AddWithValue("@P3", MskTarih.Text);
            komut.Parameters.AddWithValue("@P4", MskSaat.Text);
            komut.Parameters.AddWithValue("@P5", TxtVergi.Text);
            komut.Parameters.AddWithValue("@P6", TxtAlici.Text);
            komut.Parameters.AddWithValue("@P7", TxtTeslimeden.Text);
            komut.Parameters.AddWithValue("@P8", TxtTeslimalan.Text);
            komut.Parameters.AddWithValue("@P9", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("FATURA BİLGİSİ GÜNCELLENDİ!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            faturalistele();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaDetay fr = new FrmFaturaDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr!=null)
            {
                fr.id = dr["FATURABILGIID"].ToString();

            }
            fr.Show();
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT Urunad,satısFıyat from Tbl_Urunler where Id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtUrunId.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtUrunAd.Text = dr[0].ToString();
                TxtFiyat.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
