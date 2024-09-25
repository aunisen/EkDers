using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EkDers.Data.Migrations
{
    /// <inheritdoc />
    public partial class firstmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BransAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Donem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonemAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DonemBaslangicTarihi = table.Column<DateOnly>(type: "date", nullable: false),
                    DonemBitisTarihi = table.Column<DateOnly>(type: "date", nullable: false),
                    DonemYil = table.Column<int>(type: "int", nullable: false),
                    DonemAy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EkdersKodu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KodAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Kodu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EkdersKodu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gorev",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GorevAd = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gorev", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IzinTuru",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TurAdi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RaporKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IzinTuru", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KariyerBasamagi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KariyerBasamagi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KurumBilgi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Etiket = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Deger = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KurumBilgi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MezuniyetTuru",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MezuniyetTurAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OdemeKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MezuniyetTuru", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgramGroup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupAd = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    BaslangicTarihi = table.Column<DateOnly>(type: "date", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tatil",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TatilAd = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TatilTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaslangicTarihi = table.Column<DateOnly>(type: "date", nullable: false),
                    Yarimgunvarmi = table.Column<bool>(type: "bit", nullable: false),
                    GunSayisi = table.Column<int>(type: "int", nullable: false),
                    EkDersKesilirmi = table.Column<bool>(type: "bit", nullable: false),
                    RaporKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tatil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ogretmen",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TCKN = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SinifOgretmenligiVarmi = table.Column<bool>(type: "bit", nullable: false),
                    KulubuVarmi = table.Column<bool>(type: "bit", nullable: false),
                    GorevId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BransId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MezuniyetTuruId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KariyerBasamagiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogretmen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogretmen_Brans_BransId",
                        column: x => x.BransId,
                        principalTable: "Brans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ogretmen_Gorev_GorevId",
                        column: x => x.GorevId,
                        principalTable: "Gorev",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ogretmen_KariyerBasamagi_KariyerBasamagiId",
                        column: x => x.KariyerBasamagiId,
                        principalTable: "KariyerBasamagi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ogretmen_MezuniyetTuru_MezuniyetTuruId",
                        column: x => x.MezuniyetTuruId,
                        principalTable: "MezuniyetTuru",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OgretmenIzin",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BaslagicTarihi = table.Column<DateOnly>(type: "date", nullable: false),
                    GunSayisi = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    OdenecekEkdersSaati = table.Column<int>(type: "int", nullable: false),
                    IzinTuruId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OgretmenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgretmenIzin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgretmenIzin_IzinTuru_IzinTuruId",
                        column: x => x.IzinTuruId,
                        principalTable: "IzinTuru",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgretmenIzin_Ogretmen_OgretmenId",
                        column: x => x.OgretmenId,
                        principalTable: "Ogretmen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OgretmenProgram",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProgramGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OgretmenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EkdersKoduId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PazartesiDersSaati = table.Column<int>(type: "int", nullable: false),
                    SaliDersSaati = table.Column<int>(type: "int", nullable: false),
                    CarsambaDersSaati = table.Column<int>(type: "int", nullable: false),
                    PersembeDersSaati = table.Column<int>(type: "int", nullable: false),
                    CumaDersSaati = table.Column<int>(type: "int", nullable: false),
                    CumartesiDersSaati = table.Column<int>(type: "int", nullable: false),
                    PazarDersSaati = table.Column<int>(type: "int", nullable: false),
                    PazartesiEkDersSaati = table.Column<int>(type: "int", nullable: false),
                    SaliEkDersSaati = table.Column<int>(type: "int", nullable: false),
                    CarsambaEkDersSaati = table.Column<int>(type: "int", nullable: false),
                    PersembeEkDersSaati = table.Column<int>(type: "int", nullable: false),
                    CumaEkDersSaati = table.Column<int>(type: "int", nullable: false),
                    CumartesiEkDersSaati = table.Column<int>(type: "int", nullable: false),
                    PazarEkDersSaati = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgretmenProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgretmenProgram_EkdersKodu_EkdersKoduId",
                        column: x => x.EkdersKoduId,
                        principalTable: "EkdersKodu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgretmenProgram_Ogretmen_OgretmenId",
                        column: x => x.OgretmenId,
                        principalTable: "Ogretmen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgretmenProgram_ProgramGroup_ProgramGroupId",
                        column: x => x.ProgramGroupId,
                        principalTable: "ProgramGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaporItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OgretmenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GunSayisi = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Toplam = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaporItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RaporItem_Donem_DonemId",
                        column: x => x.DonemId,
                        principalTable: "Donem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaporItem_EkdersKodu_KodId",
                        column: x => x.KodId,
                        principalTable: "EkdersKodu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaporItem_Ogretmen_OgretmenId",
                        column: x => x.OgretmenId,
                        principalTable: "Ogretmen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Gorev",
                columns: new[] { "Id", "CreateDate", "GorevAd", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("0c30e774-4b13-4ec4-b354-157728ffb11c"), new DateTime(2024, 9, 25, 1, 11, 59, 389, DateTimeKind.Local).AddTicks(1241), "Müdür", false },
                    { new Guid("35084397-55c0-47bb-b1fe-17f02ff27601"), new DateTime(2024, 9, 25, 1, 11, 59, 389, DateTimeKind.Local).AddTicks(1266), "Öğretmen", false },
                    { new Guid("3b4dcbef-c723-40be-b73e-19cd09604c59"), new DateTime(2024, 9, 25, 1, 11, 59, 389, DateTimeKind.Local).AddTicks(1264), "Müdür Yardımcısı", false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ogretmen_BransId",
                table: "Ogretmen",
                column: "BransId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogretmen_GorevId",
                table: "Ogretmen",
                column: "GorevId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogretmen_KariyerBasamagiId",
                table: "Ogretmen",
                column: "KariyerBasamagiId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogretmen_MezuniyetTuruId",
                table: "Ogretmen",
                column: "MezuniyetTuruId");

            migrationBuilder.CreateIndex(
                name: "IX_OgretmenIzin_IzinTuruId",
                table: "OgretmenIzin",
                column: "IzinTuruId");

            migrationBuilder.CreateIndex(
                name: "IX_OgretmenIzin_OgretmenId",
                table: "OgretmenIzin",
                column: "OgretmenId");

            migrationBuilder.CreateIndex(
                name: "IX_OgretmenProgram_EkdersKoduId",
                table: "OgretmenProgram",
                column: "EkdersKoduId");

            migrationBuilder.CreateIndex(
                name: "IX_OgretmenProgram_OgretmenId",
                table: "OgretmenProgram",
                column: "OgretmenId");

            migrationBuilder.CreateIndex(
                name: "IX_OgretmenProgram_ProgramGroupId",
                table: "OgretmenProgram",
                column: "ProgramGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_RaporItem_DonemId",
                table: "RaporItem",
                column: "DonemId");

            migrationBuilder.CreateIndex(
                name: "IX_RaporItem_KodId",
                table: "RaporItem",
                column: "KodId");

            migrationBuilder.CreateIndex(
                name: "IX_RaporItem_OgretmenId",
                table: "RaporItem",
                column: "OgretmenId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KurumBilgi");

            migrationBuilder.DropTable(
                name: "OgretmenIzin");

            migrationBuilder.DropTable(
                name: "OgretmenProgram");

            migrationBuilder.DropTable(
                name: "RaporItem");

            migrationBuilder.DropTable(
                name: "Tatil");

            migrationBuilder.DropTable(
                name: "IzinTuru");

            migrationBuilder.DropTable(
                name: "ProgramGroup");

            migrationBuilder.DropTable(
                name: "Donem");

            migrationBuilder.DropTable(
                name: "EkdersKodu");

            migrationBuilder.DropTable(
                name: "Ogretmen");

            migrationBuilder.DropTable(
                name: "Brans");

            migrationBuilder.DropTable(
                name: "Gorev");

            migrationBuilder.DropTable(
                name: "KariyerBasamagi");

            migrationBuilder.DropTable(
                name: "MezuniyetTuru");
        }
    }
}
