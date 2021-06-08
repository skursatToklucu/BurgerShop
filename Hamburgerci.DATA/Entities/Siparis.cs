using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DATA
{
    public class Siparis
    {

        public int SiparisID { get; set; } //✓

        public DateTime SiparisTarihi { get; set; }

        public Menu SeciliMenu { get; set; } //✓

        public List<Ekstra> EkstraMalzemeleri { get; set; }//✓

        public Boyut Boyutu { get; set; }//✓

        public string MenuBoyutu { get; set; }

        public int Adet { get; set; }//✓

        public decimal ToplamTutar { get; set; }//✓

        public virtual List<Menu> Menuler { get; set; }//✓

        public virtual List<Ekstra> Ekstralar { get; set; }//✓

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyati;

            switch (Boyutu)
            {
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.10M;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += ToplamTutar * 0.25M;
                    break;
            }

            foreach (Ekstra item in EkstraMalzemeleri)
                ToplamTutar += item.EkstraFiyat;

            ToplamTutar = ToplamTutar * Adet;
        }

        public override string ToString()
        {
            if (EkstraMalzemeleri.Count < 1)
                return string.Format("{0} Menü x {1} Adet, {2} Boy, Toplam: {3}", SeciliMenu.MenuAdi, Adet, Boyutu.ToString(), ToplamTutar.ToString("C2"));
            else
            {
                string ekstraMalzemeler = null;

                foreach (Ekstra item in EkstraMalzemeleri)
                {
                    ekstraMalzemeler += item.EkstraAdi + ", ";
                }

                ekstraMalzemeler = ekstraMalzemeler.Trim(',', ' ');

                return string.Format("{0} Menü x {1} Adet, {2} Boy, ({3}) Toplam: {4}", SeciliMenu.MenuAdi, Adet, Boyutu.ToString(), ekstraMalzemeler, ToplamTutar.ToString("C2"));
            }
        }

    }
}
