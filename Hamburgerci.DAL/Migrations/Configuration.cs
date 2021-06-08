namespace Hamburgerci.DAL.Migrations
{
    using Hamburgerci.DATA;
    using Hamburgerci.DATA.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Hamburgerci.DAL.Context.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Hamburgerci.DAL.Context.ProjectContext context)
        {
         

            context.menuler.AddOrUpdate(x => x.MenuID,

            new Hamburgerci.DATA.Menu { MenuAdi = "Big King", Fiyati = 18.25M },
            new Hamburgerci.DATA.Menu { MenuAdi = "Double King Chicken", Fiyati = 20.75M },
            new Hamburgerci.DATA.Menu { MenuAdi = "Big Royal", Fiyati = 21.25M },
            new Hamburgerci.DATA.Menu { MenuAdi = "Whooper", Fiyati = 27.25M },
            new Hamburgerci.DATA.Menu { MenuAdi = "Double Whooper", Fiyati = 33.79M },
            new Hamburgerci.DATA.Menu { MenuAdi = "Big King XXL", Fiyati = 39.75M }

            );

            context.ekstraMalzemeler.AddOrUpdate(x => x.EkstraID,

            new Ekstra { EkstraAdi = "Ketcap", EkstraFiyat = 0.25M },
            new Ekstra { EkstraAdi = "Mayonez", EkstraFiyat = 0.25M },
            new Ekstra { EkstraAdi = "Sarımsaklı Mayonez", EkstraFiyat = 0.50M },
            new Ekstra { EkstraAdi = "BBQ Sos", EkstraFiyat = 0.75M },
            new Ekstra { EkstraAdi = "Hardal", EkstraFiyat = 0.75M },
            new Ekstra { EkstraAdi = "Ranch Sos", EkstraFiyat = 0.75M },
            new Ekstra { EkstraAdi = "Buffalo Sos", EkstraFiyat = 1M },
            new Ekstra { EkstraAdi = "Ballı Hardal ", EkstraFiyat = 1M });

        }
    }
}
