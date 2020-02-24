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
using DevExpress.Charts;


namespace bitirme_projesi
{
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void gridView2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }
        void musterihareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute Musterihareketler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void firmahareket()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2=new SqlDataAdapter("Execute Musterihareketler", bgl.baglanti());
            da2.Fill(dt2);
            gridControl3.DataSource = dt2;

        }
        public string ad;

        private void FrmKasa_Load(object sender, EventArgs e)
        {
            DataTable dt10 = new DataTable();
            SqlDataAdapter da10 = new SqlDataAdapter("Select ID,AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR FROM TBL_GIDERLER ", bgl.baglanti());
            da10.Fill(dt10);
            gridControl2.DataSource = dt10;









            LBLKULLANICILAR.Text =ad;




            musterihareket();
            firmahareket();
            SqlCommand komut1 = new SqlCommand("Select Sum(Tutar) From Tbl_Faturadetay", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read())
            {
                LBLTUTAR.Text = dr1[0].ToString() + "TL";

            }
            bgl.baglanti().Close();


            SqlCommand komut2 = new SqlCommand("Select (ELEKTRIK+SU+DOGALGAZ+INTERNET+EKSTRA)from TBL_GIDERLER ORDER BY ID ASC ", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                LBLODEMELER.Text = dr2[0].ToString() + "TL"; 
            }
            bgl.baglanti().Close();


            SqlCommand komut3 = new SqlCommand("Select Maaslar From Tbl_gıderler ORDER BY ID ASC", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LBLMAAS.Text = dr3[0].ToString() + "TL";
            }
            bgl.baglanti().Close();

            SqlCommand komut4 = new SqlCommand("Select Count(*) From Tbl_Musterıler", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LBLMUSTERISAYI.Text = dr4[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut5 = new SqlCommand("Select Count(*) From Tbl_Musterıler", bgl.baglanti());
            SqlDataReader dr5= komut5.ExecuteReader();
            while (dr5.Read())
            {
                LBLFIRMASAYI.Text = dr5[0].ToString();
            }
            bgl.baglanti().Close();


            SqlCommand komut6 = new SqlCommand("Select Count(Distinct(IL)) From Tbl_Musterıler", bgl.baglanti());
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                LBLFSEHIRSAYI.Text = dr6[0].ToString();
            }
            bgl.baglanti().Close();


            SqlCommand komut7 = new SqlCommand("Select Count(Distinct(IL)) From Tbl_Musterıler", bgl.baglanti());
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                LBLMSEHIRSAYI.Text = dr7[0].ToString();
            }
            bgl.baglanti().Close();



            SqlCommand komut8 = new SqlCommand("Select Count(*) From Tbl_PERSONELLER ", bgl.baglanti());
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                LBLPERSONELSAYI.Text = dr8[0].ToString();
            }
            bgl.baglanti().Close();


            SqlCommand komut9 = new SqlCommand("Select Sum(Adet) From Tbl_URUNLER ", bgl.baglanti());
            SqlDataReader dr9 = komut9.ExecuteReader();
            while (dr9.Read())
            {
                LBLSTOKSAYI.Text = dr9[0].ToString();
            }
            bgl.baglanti().Close();



            




        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if(sayac>0 && sayac<=5)
            {
                groupControl11.Text = "ELEKTRİK";
                SqlCommand komut10 = new SqlCommand("Select top 4 AY,ELEKTRIK FROM TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();

               

            }
            if (sayac>5 && sayac <=10)
            {
                groupControl11.Text = "SU";
                chartControl1.Series["AYLAR"].Points.Clear();
                
                SqlCommand komut11 = new SqlCommand("Select top 4 AY,SU FROM TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //internet

            if (sayac > 10 && sayac <= 15)
            {
                groupControl11.Text = "İNTERNET";
                chartControl1.Series["AYLAR"].Points.Clear();

                SqlCommand komut11 = new SqlCommand("Select top 4 AY,INTERNET FROM TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //DOĞALGAZ

            if (sayac > 15 && sayac <= 20)
            {
                groupControl11.Text = "DOĞALGAZ";
                chartControl1.Series["AYLAR"].Points.Clear();

                SqlCommand komut11 = new SqlCommand("Select top 4 AY,DOGALGAZ FROM TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //ekstra

            if (sayac > 20 && sayac <= 25)
            {
                groupControl11.Text = "EKSTRA";
                chartControl1.Series["AYLAR"].Points.Clear();

                SqlCommand komut11 = new SqlCommand("Select top 4 AY,EKSTRA FROM TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            if (sayac==26)

            {
                sayac = 0;
            }
        }
        int sayac2;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;
            if (sayac2 > 0 && sayac2 <= 5)
            {
                groupControl13.Text = "ELEKTRİK";
                SqlCommand komut10 = new SqlCommand("Select top 4 AY,ELEKTRIK FROM TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl2.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();



            }
            if (sayac2 > 5 && sayac2 <= 10)
            {
                groupControl13.Text = "SU";
               

                SqlCommand komut11 = new SqlCommand("Select top 4 AY,SU FROM TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //internet

            if (sayac2 > 10 && sayac2 <= 15)
            {
                groupControl13.Text = "İNTERNET";
                chartControl2.Series["AYLAR"].Points.Clear();

                SqlCommand komut11 = new SqlCommand("Select top 4 AY,INTERNET FROM TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //DOĞALGAZ

            if (sayac2 > 15 && sayac2 <= 20)
            {
                groupControl13.Text = "DOĞALGAZ";
                chartControl2.Series["AYLAR"].Points.Clear();

                SqlCommand komut11 = new SqlCommand("Select top 4 AY,DOGALGAZ FROM TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //ekstra

            if (sayac2 > 20 && sayac2 <= 25)
            {
                groupControl13.Text = "EKSTRA";
                chartControl2.Series["AYLAR"].Points.Clear();

                SqlCommand komut11 = new SqlCommand("Select top 4 AY,EKSTRA FROM TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            if (sayac2 == 26)

            {
                sayac2 = 0;
            }
        }
    }
}
