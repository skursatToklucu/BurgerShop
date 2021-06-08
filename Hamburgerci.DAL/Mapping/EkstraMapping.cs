using Hamburgerci.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DAL.Mapping
{
    public class EkstraMapping : EntityTypeConfiguration<Ekstra> //✓
    {
        public EkstraMapping()
        {
            ToTable("EkstraMalzemeler");

            Property(x => x.EkstraAdi).IsRequired().HasColumnType("nvarchar").HasMaxLength(20); //✓
            Property(x => x.EkstraFiyat).IsRequired().HasColumnType("decimal"); //✓


            HasKey(x => x.EkstraID);//✓

        }

    }
}
