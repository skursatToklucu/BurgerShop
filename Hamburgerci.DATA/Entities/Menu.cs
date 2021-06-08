using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DATA
{
    public class Menu
    {
        
        public int MenuID { get; set; } //✓
        public string MenuAdi { get; set; }//✓

        public decimal Fiyati { get; set; }//✓

        public virtual List<Siparis> Siparisler { get; set; }//✓


        public override string ToString()
        {
            return MenuAdi + " Menü";
        }
    }
}
