using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcsesslayerr;
using EntityLayerr;


namespace BusinesssLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci P)
        {
            if (P.AD != null && P.SOYAD != null && P.NUMARA != null && P.SIFRE != null && P.FOTOGRAF != null)
            {
                return DALOgrenci.OgrenciEkle(P);
            }
            return -1;
        }
        public static List<EntityOgrenci> BllListele()
        {
        return DALOgrenci.OgrenciListesi();
           }
    }
}
