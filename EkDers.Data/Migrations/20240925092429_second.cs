using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EkDers.Data.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OgretmenGorev",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OgretmenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SinifOgretmeniOlduguSinif = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DanismaniOlduguKulup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NobetGoreviVarmi = table.Column<bool>(type: "bit", nullable: false),
                    SinifOgretmenligiVarmi = table.Column<bool>(type: "bit", nullable: false),
                    KulupOgretmenligiVarmi = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgretmenGorev", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgretmenGorev_Ogretmen_OgretmenId",
                        column: x => x.OgretmenId,
                        principalTable: "Ogretmen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Gorev",
                keyColumn: "Id",
                keyValue: new Guid("0c30e774-4b13-4ec4-b354-157728ffb11c"),
                column: "CreateDate",
                value: new DateTime(2024, 9, 25, 12, 24, 29, 173, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Gorev",
                keyColumn: "Id",
                keyValue: new Guid("35084397-55c0-47bb-b1fe-17f02ff27601"),
                column: "CreateDate",
                value: new DateTime(2024, 9, 25, 12, 24, 29, 173, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Gorev",
                keyColumn: "Id",
                keyValue: new Guid("3b4dcbef-c723-40be-b73e-19cd09604c59"),
                column: "CreateDate",
                value: new DateTime(2024, 9, 25, 12, 24, 29, 173, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.CreateIndex(
                name: "IX_OgretmenGorev_OgretmenId",
                table: "OgretmenGorev",
                column: "OgretmenId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OgretmenGorev");

            migrationBuilder.UpdateData(
                table: "Gorev",
                keyColumn: "Id",
                keyValue: new Guid("0c30e774-4b13-4ec4-b354-157728ffb11c"),
                column: "CreateDate",
                value: new DateTime(2024, 9, 25, 9, 49, 14, 891, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Gorev",
                keyColumn: "Id",
                keyValue: new Guid("35084397-55c0-47bb-b1fe-17f02ff27601"),
                column: "CreateDate",
                value: new DateTime(2024, 9, 25, 9, 49, 14, 891, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "Gorev",
                keyColumn: "Id",
                keyValue: new Guid("3b4dcbef-c723-40be-b73e-19cd09604c59"),
                column: "CreateDate",
                value: new DateTime(2024, 9, 25, 9, 49, 14, 891, DateTimeKind.Local).AddTicks(9500));
        }
    }
}
