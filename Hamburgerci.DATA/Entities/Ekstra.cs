using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DATA
{
    public class Ekstra
    {
        
        public int EkstraID { get; set; } //✓

        public string EkstraAdi { get; set; }//✓

        public decimal EkstraFiyat { get; set; }//✓

        public virtual List<Siparis> Siparisler { get; set; }//✓

    }
}
