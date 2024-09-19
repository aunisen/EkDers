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
            modelBuilder.Entity<EkdersResult>().ToTable("EkdersResult");
            modelBuilder.Entity<Gorev>().ToTable("Gorev");
            modelBuilder.Entity<Izin>().ToTable("Izin");
            modelBuilder.Entity<IzinTuru>().ToTable("IzinTuru");
            modelBuilder.Entity<KurumBilgi>().ToTable("KurumBilgi");
            modelBuilder.Entity<Personel>().ToTable("Personel");
            modelBuilder.Entity<Tatil>().ToTable("Tatil");


            
            
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string _connectionStringLocalDb = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EkdersDbV1; Integrated Security=True";
            string _connectionStringSqlServer = @"Data Source=.;Initial Catalog=EkdersDbV1; Integrated Security=True";
          
            optionsBuilder.UseSqlServer(_connectionStringLocalDb);
            
        }


        public DbSet<Brans> Branslar { get; set; }
        public DbSet<Donem> Donemler { get; set; }
        public DbSet<EkdersKodu> EkDersKodlari { get; set; }
        public DbSet<EkdersResult> EkDersResults { get; set; }
        public DbSet<Gorev> Gorevler { get; set; }
        public DbSet<Izin> Izinler { get; set; }
        public DbSet<IzinTuru> IzinTurleri { get; set; }
        public DbSet<KurumBilgi> KurumBilgileri { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Tatil> Tatiller { get; set; }
    }
}
