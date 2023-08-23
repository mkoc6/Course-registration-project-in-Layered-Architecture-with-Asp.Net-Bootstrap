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
    public partial class OgrenciListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityOgrenci> ogrlist = BLLOgrenci.BllListele();
            Repeater1.DataSource = ogrlist;
            Repeater1.DataBind();
        }
    }
}