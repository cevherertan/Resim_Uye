using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    public class Vt
    {
        public static SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0HLJ5NJ\SQLEXPRESS;Initial Catalog=TophaneBurada;Integrated Security=True");
        public static void ac()
        {
            baglanti.Open();
        }
        public static void kapat()
        {
            baglanti.Close();
        }
    }
}
