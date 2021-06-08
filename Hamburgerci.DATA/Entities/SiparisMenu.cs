using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DATA.Entities
{
    public class SiparisMenu
    {
       
        public int SiparisID { get; set; }
        
        public int MenuID { get; set; }

        public virtual Siparis Siparis { get; set; }

        public virtual Menu Menu { get; set; }
    }
}
