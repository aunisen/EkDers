using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EkDers.Data.Migrations
{
    /// <inheritdoc />
    public partial class bir : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BransAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                    DonemAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                    Kodu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IzinTuru", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KurumBilgi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Etiket = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Deger = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KurumBilgi", x => x.Id);
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
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tatil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TCKN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    GorevId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BransId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personel_Brans_BransId",
                        column: x => x.BransId,
                        principalTable: "Brans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personel_Gorev_GorevId",
                        column: x => x.GorevId,
                        principalTable: "Gorev",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EkdersResult",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gun0 = table.Column<int>(type: "int", nullable: false),
                    Gun1 = table.Column<int>(type: "int", nullable: false),
                    Gun2 = table.Column<int>(type: "int", nullable: false),
                    Gun3 = table.Column<int>(type: "int", nullable: false),
                    Gun4 = table.Column<int>(type: "int", nullable: false),
                    Gun5 = table.Column<int>(type: "int", nullable: false),
                    Gun6 = table.Column<int>(type: "int", nullable: false),
                    Gun7 = table.Column<int>(type: "int", nullable: false),
                    Gun8 = table.Column<int>(type: "int", nullable: false),
                    Gun9 = table.Column<int>(type: "int", nullable: false),
                    Gun10 = table.Column<int>(type: "int", nullable: false),
                    Gun11 = table.Column<int>(type: "int", nullable: false),
                    Gun13 = table.Column<int>(type: "int", nullable: false),
                    Gun14 = table.Column<int>(type: "int", nullable: false),
                    Gun15 = table.Column<int>(type: "int", nullable: false),
                    Gun16 = table.Column<int>(type: "int", nullable: false),
                    Gun17 = table.Column<int>(type: "int", nullable: false),
                    Gun18 = table.Column<int>(type: "int", nullable: false),
                    Gun19 = table.Column<int>(type: "int", nullable: false),
                    Gun20 = table.Column<int>(type: "int", nullable: false),
                    Gun21 = table.Column<int>(type: "int", nullable: false),
                    Gun22 = table.Column<int>(type: "int", nullable: false),
                    Gun23 = table.Column<int>(type: "int", nullable: false),
                    Gun24 = table.Column<int>(type: "int", nullable: false),
                    Gun25 = table.Column<int>(type: "int", nullable: false),
                    Gun26 = table.Column<int>(type: "int", nullable: false),
                    Gun27 = table.Column<int>(type: "int", nullable: false),
                    Gun28 = table.Column<int>(type: "int", nullable: false),
                    Gun29 = table.Column<int>(type: "int", nullable: false),
                    Gun30 = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EkdersResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EkdersResult_Donem_DonemId",
                        column: x => x.DonemId,
                        principalTable: "Donem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EkdersResult_EkdersKodu_KodId",
                        column: x => x.KodId,
                        principalTable: "EkdersKodu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EkdersResult_Personel_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Izin",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BaslagicTarihi = table.Column<DateOnly>(type: "date", nullable: false),
                    GunSayisi = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    EkDerskesilecekmi = table.Column<bool>(type: "bit", nullable: false),
                    IzinTuruId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Izin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Izin_IzinTuru_IzinTuruId",
                        column: x => x.IzinTuruId,
                        principalTable: "IzinTuru",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Izin_Personel_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Gorev",
                columns: new[] { "Id", "CreateDate", "GorevAd", "IsDeleted" },
                values: new object[,]
                {
                    { new Guid("0c30e774-4b13-4ec4-b354-157728ffb11c"), new DateTime(2024, 9, 19, 21, 21, 54, 199, DateTimeKind.Local).AddTicks(9151), "Müdür", false },
                    { new Guid("35084397-55c0-47bb-b1fe-17f02ff27601"), new DateTime(2024, 9, 19, 21, 21, 54, 199, DateTimeKind.Local).AddTicks(9186), "Öğretmen", false },
                    { new Guid("3b4dcbef-c723-40be-b73e-19cd09604c59"), new DateTime(2024, 9, 19, 21, 21, 54, 199, DateTimeKind.Local).AddTicks(9169), "Müdür Yardımcısı", false },
                    { new Guid("9b12ff59-0858-4fa2-9c20-f1ecd1c60098"), new DateTime(2024, 9, 19, 21, 21, 54, 199, DateTimeKind.Local).AddTicks(9187), "Uzman Öğretmen", false },
                    { new Guid("ac86700e-3f47-4b67-b0cd-06c038065ca7"), new DateTime(2024, 9, 19, 21, 21, 54, 199, DateTimeKind.Local).AddTicks(9189), "Baş Öğretmen", false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EkdersResult_DonemId",
                table: "EkdersResult",
                column: "DonemId");

            migrationBuilder.CreateIndex(
                name: "IX_EkdersResult_KodId",
                table: "EkdersResult",
                column: "KodId");

            migrationBuilder.CreateIndex(
                name: "IX_EkdersResult_PersonelId",
                table: "EkdersResult",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Izin_IzinTuruId",
                table: "Izin",
                column: "IzinTuruId");

            migrationBuilder.CreateIndex(
                name: "IX_Izin_PersonelId",
                table: "Izin",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Personel_BransId",
                table: "Personel",
                column: "BransId");

            migrationBuilder.CreateIndex(
                name: "IX_Personel_GorevId",
                table: "Personel",
                column: "GorevId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EkdersResult");

            migrationBuilder.DropTable(
                name: "Izin");

            migrationBuilder.DropTable(
                name: "KurumBilgi");

            migrationBuilder.DropTable(
                name: "Tatil");

            migrationBuilder.DropTable(
                name: "Donem");

            migrationBuilder.DropTable(
                name: "EkdersKodu");

            migrationBuilder.DropTable(
                name: "IzinTuru");

            migrationBuilder.DropTable(
                name: "Personel");

            migrationBuilder.DropTable(
                name: "Brans");

            migrationBuilder.DropTable(
                name: "Gorev");
        }
    }
}
