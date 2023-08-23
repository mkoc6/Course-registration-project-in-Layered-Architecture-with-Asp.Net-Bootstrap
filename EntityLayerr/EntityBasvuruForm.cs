using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayerr
{
    class EntityBasvuruForm
    {
        private int basvuruid;
        private int basderid;
        private int basogrid;
         
        public int BASVURUID { get => basvuruid; set => basvuruid = value; }
        public int BASDERID { get => basderid; set => basderid = value; }
        public int BASOGRID { get => basogrid; set => basogrid = value; }
    }
}
