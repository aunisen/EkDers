﻿// <auto-generated />
using System;
using EkDers.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EkDers.Data.Migrations
{
    [DbContext(typeof(EkdersDbContext))]
    partial class EkdersDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EkDers.Entity.DbEntity.Brans", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BransAd")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Brans", (string)null);
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.Donem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DonemAd")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("DonemAy")
                        .HasColumnType("int");

                    b.Property<DateOnly>("DonemBaslangicTarihi")
                        .HasColumnType("date");

                    b.Property<DateOnly>("DonemBitisTarihi")
                        .HasColumnType("date");

                    b.Property<int>("DonemYil")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Donem", (string)null);
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.EkdersKodu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("KodAd")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Kodu")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("EkdersKodu", (string)null);
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.Gorev", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GorevAd")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Gorev", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("0c30e774-4b13-4ec4-b354-157728ffb11c"),
                            CreateDate = new DateTime(2024, 9, 25, 12, 24, 29, 173, DateTimeKind.Local).AddTicks(7515),
                            GorevAd = "Müdür",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("3b4dcbef-c723-40be-b73e-19cd09604c59"),
                            CreateDate = new DateTime(2024, 9, 25, 12, 24, 29, 173, DateTimeKind.Local).AddTicks(7533),
                            GorevAd = "Müdür Yardımcısı",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("35084397-55c0-47bb-b1fe-17f02ff27601"),
                            CreateDate = new DateTime(2024, 9, 25, 12, 24, 29, 173, DateTimeKind.Local).AddTicks(7535),
                            GorevAd = "Öğretmen",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.IzinTuru", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("RaporKodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TurAdi")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("IzinTuru", (string)null);
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.KariyerBasamagi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("KariyerBasamagi", (string)null);
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.KurumBilgi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Deger")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Etiket")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("KurumBilgi", (string)null);
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.MezuniyetTuru", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MezuniyetTurAd")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("OdemeKodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MezuniyetTuru", (string)null);
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.Ogretmen", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("BransId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("GorevId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("KariyerBasamagiId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("KulubuVarmi")
                        .HasColumnType("bit");

                    b.Property<Guid>("MezuniyetTuruId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("SinifOgretmenligiVarmi")
                        .HasColumnType("bit");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TCKN")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("BransId");

                    b.HasIndex("GorevId");

                    b.HasIndex("KariyerBasamagiId");

                    b.HasIndex("MezuniyetTuruId");

                    b.ToTable("Ogretmen", (string)null);
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.OgretmenGorev", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DanismaniOlduguKulup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("KulupOgretmenligiVarmi")
                        .HasColumnType("bit");

                    b.Property<bool>("NobetGoreviVarmi")
                        .HasColumnType("bit");

                    b.Property<Guid>("OgretmenId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SinifOgretmeniOlduguSinif")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SinifOgretmenligiVarmi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("OgretmenId");

                    b.ToTable("OgretmenGorev", (string)null);
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.OgretmenIzin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateOnly>("BaslagicTarihi")
                        .HasColumnType("date");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("GunSayisi")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("IzinTuruId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("OdenecekEkdersSaati")
                        .HasColumnType("int");

                    b.Property<Guid>("OgretmenId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("IzinTuruId");

                    b.HasIndex("OgretmenId");

                    b.ToTable("OgretmenIzin", (string)null);
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.OgretmenProgram", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CarsambaDersSaati")
                        .HasColumnType("int");

                    b.Property<int>("CarsambaEkDersSaati")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CumaDersSaati")
                        .HasColumnType("int");

                    b.Property<int>("CumaEkDersSaati")
                        .HasColumnType("int");

                    b.Property<int>("CumartesiDersSaati")
                        .HasColumnType("int");

                    b.Property<int>("CumartesiEkDersSaati")
                        .HasColumnType("int");

                    b.Property<Guid>("EkdersKoduId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("OgretmenId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PazarDersSaati")
                        .HasColumnType("int");

                    b.Property<int>("PazarEkDersSaati")
                        .HasColumnType("int");

                    b.Property<int>("PazartesiDersSaati")
                        .HasColumnType("int");

                    b.Property<int>("PazartesiEkDersSaati")
                        .HasColumnType("int");

                    b.Property<int>("PersembeDersSaati")
                        .HasColumnType("int");

                    b.Property<int>("PersembeEkDersSaati")
                        .HasColumnType("int");

                    b.Property<Guid>("ProgramGroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SaliDersSaati")
                        .HasColumnType("int");

                    b.Property<int>("SaliEkDersSaati")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EkdersKoduId");

                    b.HasIndex("OgretmenId");

                    b.HasIndex("ProgramGroupId");

                    b.ToTable("OgretmenProgram", (string)null);
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.ProgramGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("AktifProgramMi")
                        .HasColumnType("bit");

                    b.Property<DateOnly>("BaslangicTarihi")
                        .HasColumnType("date");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GroupAd")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ProgramKodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProgramGroup", (string)null);
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.RaporItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<Guid>("DonemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("GunSayisi")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("KodId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OgretmenId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Toplam")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DonemId");

                    b.HasIndex("KodId");

                    b.HasIndex("OgretmenId");

                    b.ToTable("RaporItem", (string)null);
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.Tatil", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("BaslangicTarihi")
                        .HasColumnType("date");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EkDersKesilirmi")
                        .HasColumnType("bit");

                    b.Property<int>("GunSayisi")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("RaporKodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TatilAd")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("TatilTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Yarimgunvarmi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Tatil", (string)null);
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.Ogretmen", b =>
                {
                    b.HasOne("EkDers.Entity.DbEntity.Brans", "Brans")
                        .WithMany("Ogretmens")
                        .HasForeignKey("BransId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EkDers.Entity.DbEntity.Gorev", "Gorev")
                        .WithMany("Personels")
                        .HasForeignKey("GorevId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EkDers.Entity.DbEntity.KariyerBasamagi", "KariyerBasamagi")
                        .WithMany("Ogretmens")
                        .HasForeignKey("KariyerBasamagiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EkDers.Entity.DbEntity.MezuniyetTuru", "MezuniyetTuru")
                        .WithMany("Ogretmens")
                        .HasForeignKey("MezuniyetTuruId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brans");

                    b.Navigation("Gorev");

                    b.Navigation("KariyerBasamagi");

                    b.Navigation("MezuniyetTuru");
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.OgretmenGorev", b =>
                {
                    b.HasOne("EkDers.Entity.DbEntity.Ogretmen", "Ogretmen")
                        .WithMany("OgretmenGorevs")
                        .HasForeignKey("OgretmenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ogretmen");
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.OgretmenIzin", b =>
                {
                    b.HasOne("EkDers.Entity.DbEntity.IzinTuru", "IzinTuru")
                        .WithMany("Izins")
                        .HasForeignKey("IzinTuruId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EkDers.Entity.DbEntity.Ogretmen", "Ogretmen")
                        .WithMany("OgretmenIzins")
                        .HasForeignKey("OgretmenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IzinTuru");

                    b.Navigation("Ogretmen");
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.OgretmenProgram", b =>
                {
                    b.HasOne("EkDers.Entity.DbEntity.EkdersKodu", "EkdersKodu")
                        .WithMany("OgretmenPrograms")
                        .HasForeignKey("EkdersKoduId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EkDers.Entity.DbEntity.Ogretmen", "Ogretmen")
                        .WithMany("Programs")
                        .HasForeignKey("OgretmenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EkDers.Entity.DbEntity.ProgramGroup", "ProgramGroup")
                        .WithMany("OgretmenPrograms")
                        .HasForeignKey("ProgramGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EkdersKodu");

                    b.Navigation("Ogretmen");

                    b.Navigation("ProgramGroup");
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.RaporItem", b =>
                {
                    b.HasOne("EkDers.Entity.DbEntity.Donem", "Donem")
                        .WithMany("EkdersResults")
                        .HasForeignKey("DonemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EkDers.Entity.DbEntity.EkdersKodu", "Kod")
                        .WithMany()
                        .HasForeignKey("KodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EkDers.Entity.DbEntity.Ogretmen", "Ogretmen")
                        .WithMany("EkdersResults")
                        .HasForeignKey("OgretmenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Donem");

                    b.Navigation("Kod");

                    b.Navigation("Ogretmen");
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.Brans", b =>
                {
                    b.Navigation("Ogretmens");
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.Donem", b =>
                {
                    b.Navigation("EkdersResults");
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.EkdersKodu", b =>
                {
                    b.Navigation("OgretmenPrograms");
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.Gorev", b =>
                {
                    b.Navigation("Personels");
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.IzinTuru", b =>
                {
                    b.Navigation("Izins");
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.KariyerBasamagi", b =>
                {
                    b.Navigation("Ogretmens");
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.MezuniyetTuru", b =>
                {
                    b.Navigation("Ogretmens");
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.Ogretmen", b =>
                {
                    b.Navigation("EkdersResults");

                    b.Navigation("OgretmenGorevs");

                    b.Navigation("OgretmenIzins");

                    b.Navigation("Programs");
                });

            modelBuilder.Entity("EkDers.Entity.DbEntity.ProgramGroup", b =>
                {
                    b.Navigation("OgretmenPrograms");
                });
#pragma warning restore 612, 618
        }
    }
}
