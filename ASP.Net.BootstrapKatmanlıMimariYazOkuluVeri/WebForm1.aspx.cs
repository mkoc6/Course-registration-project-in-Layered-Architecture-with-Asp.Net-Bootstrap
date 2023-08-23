using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayerr;
using DataAcsesslayerr;
using BusinesssLogicLayer;

namespace ASP.Net.BootstrapKatmanlıMimariYazOkuluVeri
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.AD = TextAd.Text;
            ent.SOYAD = TextSoyad.Text;
            ent.NUMARA = TextNumara.Text;
            ent.SIFRE = TextSifre.Text;
            ent.FOTOGRAF = TextFoto.Text;
            BLLOgrenci.OgrenciEkleBLL(ent);

        }
    }
}