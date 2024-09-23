using EkDers.Data.Mappings;
using EkDers.Entity.DbEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Data.Context
{
    public class EkdersDbContext : DbContext
    {
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brans>().ToTable("Brans");
            modelBuilder.Entity<Donem>().ToTable("Donem");
            modelBuilder.Entity<EkdersKodu>().ToTable("EkdersKodu");
            modelBuilder.Entity<RaporItem>().ToTable("RaporItem");
            modelBuilder.Entity<Gorev>().ToTable("Gorev"); 
            modelBuilder.Entity<IzinTuru>().ToTable("IzinTuru");
            modelBuilder.Entity<KariyerBasamagi>().ToTable("KariyerBasamagi");
            modelBuilder.Entity<KurumBilgi>().ToTable("KurumBilgi");
            modelBuilder.Entity<MezuniyetTuru>().ToTable("MezuniyetTuru");
            modelBuilder.Entity<Ogretmen>().ToTable("Ogretmen");
            modelBuilder.Entity<OgretmenIzin>().ToTable("OgretmenIzin");
            modelBuilder.Entity<OgretmenProgram>().ToTable("OgretmenProgram");
            modelBuilder.Entity<ProgramGroup>().ToTable("ProgramGroup");
            modelBuilder.Entity<Tatil>().ToTable("Tatil");
            

            
            
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string _connectionStringLocalDb = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EkdersDbV2; Integrated Security=True;Trusted_Certificate=True";
            string _connectionStringSqlServer = @"Data Source=.;Initial Catalog=EkdersDbV2; Integrated Security=True; TrustServerCertificate=True;";
          
            optionsBuilder.UseSqlServer(_connectionStringSqlServer);
            
        }


        public DbSet<Brans> Branslar { get; set; }
        public DbSet<Donem> Donemler { get; set; }
        public DbSet<EkdersKodu> EkDersKodlari { get; set; }
        public DbSet<RaporItem> RaporItemlar { get; set; }
        public DbSet<Gorev> Gorevler { get; set; }
        public DbSet<OgretmenIzin> OgretmenIzinleri { get; set; }
        public DbSet<IzinTuru> IzinTurleri { get; set; }
        public DbSet<KurumBilgi> KurumBilgileri { get; set; }
        public DbSet<Ogretmen> Ogretmenler { get; set; }
        public DbSet<OgretmenProgram> OgretmenProgramlari { get; set; }
        public DbSet<KariyerBasamagi> KariyerBasamaglari { get; set; }
        public DbSet<Tatil> Tatiller { get; set; }
        public DbSet<ProgramGroup> ProgramGrouplari { get; set; }
        public DbSet<MezuniyetTuru> MezuniyetTurleri { get; set; }


        }
}
