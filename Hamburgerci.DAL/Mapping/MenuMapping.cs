using Hamburgerci.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DAL.Mapping
{
    public class MenuMapping : EntityTypeConfiguration<Menu>
    {
        public MenuMapping()
        {
            ToTable("Menuler");

            Property(x => x.MenuAdi).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Fiyati).IsRequired().HasColumnType("decimal");


            HasKey(x => x.MenuID);


        }
    }
}
