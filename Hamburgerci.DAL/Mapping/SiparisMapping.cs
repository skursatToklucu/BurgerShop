using Hamburgerci.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DAL.Mapping
{
    public class SiparisMapping : EntityTypeConfiguration<Siparis>
    {
        public SiparisMapping()
        {
            ToTable("Siparisler");

            
            Property(x => x.MenuBoyutu).IsRequired().HasColumnType("nvarchar");
            Property(x => x.Adet).IsRequired().HasColumnType("int");
            Property(x => x.SiparisTarihi).IsRequired().HasColumnType("datetime");
            Property(x => x.ToplamTutar).IsRequired().HasColumnType("decimal");

            Ignore(x => x.SeciliMenu);
            Ignore(x => x.EkstraMalzemeleri);
            Ignore(x => x.Boyutu);


            HasKey(x => x.SiparisID);
            


        }
    }
}
