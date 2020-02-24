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
using System.Xml;

namespace bitirme_projesi
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void stoklar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Urunad,sum(adet) as 'Adet' from TBL_URUNLER GROUP BY Urunad having sum(adet)<=20 order by sum(adet)", bgl.baglanti());
            da.Fill(dt);
            gridstoklar.DataSource = dt;

        }
        void ajanda()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select top 8 tarıh,saat,baslık from TBL_NOTLAR order by ID desc",bgl.baglanti());
            da.Fill(dt);
            gridajanda.DataSource = dt;
        }
        void firmahareketleri()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec Firmahareket2", bgl.baglanti());
            da.Fill(dt);
            gridhareket.DataSource = dt;
        }
        void fihrist()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Ad,Telefon1 from tbl_fırmalar",bgl.baglanti());
            da.Fill(dt);
            gridfihrist.DataSource = dt;
        }
       
       
            private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            stoklar();
            ajanda();
            firmahareketleri();
            fihrist();

            webBrowser1.Navigate("http://www.tcmb.gov.tr/kurlar/today.xml");
            
        }
    }
}
