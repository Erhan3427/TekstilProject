using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;


namespace Tekstile.Context
{
    public class MyDbContext: DbContext
    {
       
        public DbSet<Musteriler> Musteriler { get; set; }
        public DbSet<Siparisler> Siparisler { get; set; }
        public DbSet<Makineler> Makineler { get; set; }
        public DbSet<Kumascinsleri> Kumascinsleri { get; set; }
        public DbSet<Desenler> Desenler { get; set; }
        public DbSet<DesenBoyalar> DesenBoyalari { get; set; }
        public DbSet<Boyalar> Boyalar { get; set; }
        public DbSet<StokHareket> StokHareket { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ERHANLAPTOP\\SQLEXPRESS;Database=TekstileDB;TrustServerCertificate=True;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          


        }


    }
    
    
}
