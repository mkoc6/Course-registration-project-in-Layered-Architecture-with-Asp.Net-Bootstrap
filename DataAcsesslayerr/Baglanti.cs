using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAcsesslayerr
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-1DQCP20\SQLEXPRESS;Initial Catalog=ASP.Net.BootstrapKatmanlıMimariYazOkuluVeri;Integrated Security=True");
    }
}
