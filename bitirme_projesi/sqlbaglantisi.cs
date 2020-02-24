using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace bitirme_projesi
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-CS3GM3HQ;Initial Catalog=DboTicariOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}
