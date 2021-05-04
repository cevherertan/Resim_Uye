using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class DbCrud
    {
        public bool kayit(Uye kullanici)
        {
            Vt.ac();
            SqlCommand komut = new SqlCommand("insert into TblUye values(@a,@b,@c,@d,@e,@f,@g,@h)",Vt.baglanti);
            komut.Parameters.AddWithValue("@a",kullanici.kullaniciadi);
            komut.Parameters.AddWithValue("@b",kullanici.sifre);
            komut.Parameters.AddWithValue("@c",kullanici.ad);
            komut.Parameters.AddWithValue("@d",kullanici.soyad);
            komut.Parameters.AddWithValue("@e",kullanici.eposta);
            komut.Parameters.AddWithValue("@f",kullanici.cinsiyet);
            komut.Parameters.AddWithValue("@g",kullanici.dogumtarihi);
            komut.Parameters.AddWithValue("@h", kullanici.resim);
            int kn =komut.ExecuteNonQuery();
            if (kn==1)
            {
                return true;
            }
            Vt.kapat();
            return false;
        }
    }
}
