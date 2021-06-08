using Hamburgerci.DAL.Mapping;
using Hamburgerci.DATA;
using Hamburgerci.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DAL.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server = DESKTOP-B77ITTF; Database = BoostKing1; integrated security = true;";
        }

        public DbSet<Siparis> siparisler { get; set; }

        public DbSet<Menu> menuler { get; set; }

        public DbSet<Ekstra> ekstraMalzemeler { get; set; }

        public DbSet<SiparisEkstra> SiparisEkstralar { get; set; }

        public DbSet<SiparisMenu> SiparisMenuler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            


            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new SiparisMapping());
            modelBuilder.Configurations.Add(new MenuMapping());
            modelBuilder.Configurations.Add(new EkstraMapping());
            modelBuilder.Entity<Siparis>()
                          .HasMany(e => e.Ekstralar)
                          .WithMany(s => s.Siparisler)
                          .Map(map =>
                          {
                              map.ToTable("SiparisEkstra");
                              map.MapLeftKey("SiparisID");
                              map.MapRightKey("EkstraID");
                          });
            modelBuilder.Entity<Siparis>()
                          .HasMany(s => s.Menuler)
                          .WithMany(e => e.Siparisler)
                          .Map(map =>
                          {
                              map.ToTable("SiparisMenu");
                              map.MapLeftKey("SiparisID");
                              map.MapRightKey("MenuID");
                          });


            base.OnModelCreating(modelBuilder);
        }

    }
}
