using Microsoft.EntityFrameworkCore;
using ProjectTask.DAL.Mappings;
using ProjectTask.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTask.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Besin> Besinler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<Porsiyon> Porsiyonlar { get; set; }
        public DbSet<Yemek> Yemekler { get; set; }
        public DbSet<YemekKategori> YemekKategorileri { get; set; }
        public DbSet<YemekPlani> YemekPlanlari { get; set; }
        public DbSet<YemekPlaniOgesi> YemekPlaniOgeleri { get; set; }   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=E;Initial Catalog=HS15-ProjeDiyetUygulama;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new BesinMapping().Configure(modelBuilder.Entity<Besin>());
            new KullaniciMapping().Configure(modelBuilder.Entity<Kullanici>());
            new OgunMapping().Configure(modelBuilder.Entity<Ogun>());
            new PorsiyonMapping().Configure(modelBuilder.Entity<Porsiyon>());
            new YemekKategoriMapping().Configure(modelBuilder.Entity<YemekKategori>());
            new YemekMapping().Configure(modelBuilder.Entity<Yemek>());
            new YemekPlaniMapping().Configure(modelBuilder.Entity<YemekPlani>());
            new YemekPlaniOgesiMapping().Configure(modelBuilder.Entity<YemekPlaniOgesi>());

            base.OnModelCreating(modelBuilder);

        }

    }
}
