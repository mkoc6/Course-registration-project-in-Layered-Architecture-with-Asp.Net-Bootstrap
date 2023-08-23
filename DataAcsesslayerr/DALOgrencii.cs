using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayerr;

namespace DataAcsesslayerr
{
    public class DALOgrenci
    {
        /// ekleme metodu
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand command = new SqlCommand("insert into TBL_OGRENCI (OGRAD,OGRSOYAD, OGRNUMARA, OGRFOTO, OGRSIFRE) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("@p1", parametre.AD);
            command.Parameters.AddWithValue("@p2", parametre.SOYAD);
            command.Parameters.AddWithValue("@p3", parametre.NUMARA);
            command.Parameters.AddWithValue("@p4", parametre.FOTOGRAF);
            command.Parameters.AddWithValue("@p5", parametre.SIFRE);

            return command.ExecuteNonQuery();
        }
        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand command2 = new SqlCommand("select * from TBL_OGRENCI", Baglanti.bgl);
            if (command2.Connection.State != ConnectionState.Open)
            {
                command2.Connection.Open();
            }
            SqlDataReader DR = command2.ExecuteReader();
            while (DR.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.ID = Convert.ToInt32(DR["OGRID"].ToString());
                ent.AD = DR["OGRAD"].ToString();
                ent.SOYAD = DR["OGRSOYAD"].ToString();
                ent.NUMARA = DR["OGRNUMARA"].ToString();
                ent.SIFRE = DR["OGRSIFRE"].ToString();
                ent.FOTOGRAF = DR["OGRFOTO"].ToString();
                ent.BAKIYE = Convert.ToDouble(DR["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            DR.Close();
            return degerler;
        }
    }
}
