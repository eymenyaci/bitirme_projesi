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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            //chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 4);
            //chartControl1.Series["Series 1"].Points.AddPoint("İzmir", 8);
            //chartControl1.Series["Series 1"].Points.AddPoint("Ankara", 6);
            //chartControl1.Series["Series 1"].Points.AddPoint("Çanakkale",25);


            SqlDataAdapter da = new SqlDataAdapter("Select UrunAd,Sum(Adet) As 'Miktar' from Tbl_Urunler group by UrunAd", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;


            //Charta Stok Miktarı listeleme
            SqlCommand komut = new SqlCommand("Select UrunAd,Sum(Adet) As 'Miktar' from Tbl_Urunler group by UrunAd", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]),int.Parse(dr[1].ToString()));
            }
            bgl.baglanti().Close();


        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmStokDetay fr = new FrmStokDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fr.ad = dr["URUNAD"].ToString();

            }
            fr.Show();
        }
    }
}
