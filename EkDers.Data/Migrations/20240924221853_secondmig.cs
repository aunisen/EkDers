using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EkDers.Data.Migrations
{
    /// <inheritdoc />
    public partial class secondmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AktifProgramMi",
                table: "ProgramGroup",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ProgramKodu",
                table: "ProgramGroup",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Gorev",
                keyColumn: "Id",
                keyValue: new Guid("0c30e774-4b13-4ec4-b354-157728ffb11c"),
                column: "CreateDate",
                value: new DateTime(2024, 9, 25, 1, 18, 52, 695, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Gorev",
                keyColumn: "Id",
                keyValue: new Guid("35084397-55c0-47bb-b1fe-17f02ff27601"),
                column: "CreateDate",
                value: new DateTime(2024, 9, 25, 1, 18, 52, 695, DateTimeKind.Local).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "Gorev",
                keyColumn: "Id",
                keyValue: new Guid("3b4dcbef-c723-40be-b73e-19cd09604c59"),
                column: "CreateDate",
                value: new DateTime(2024, 9, 25, 1, 18, 52, 695, DateTimeKind.Local).AddTicks(9719));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AktifProgramMi",
                table: "ProgramGroup");

            migrationBuilder.DropColumn(
                name: "ProgramKodu",
                table: "ProgramGroup");

            migrationBuilder.UpdateData(
                table: "Gorev",
                keyColumn: "Id",
                keyValue: new Guid("0c30e774-4b13-4ec4-b354-157728ffb11c"),
                column: "CreateDate",
                value: new DateTime(2024, 9, 25, 1, 11, 59, 389, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Gorev",
                keyColumn: "Id",
                keyValue: new Guid("35084397-55c0-47bb-b1fe-17f02ff27601"),
                column: "CreateDate",
                value: new DateTime(2024, 9, 25, 1, 11, 59, 389, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "Gorev",
                keyColumn: "Id",
                keyValue: new Guid("3b4dcbef-c723-40be-b73e-19cd09604c59"),
                column: "CreateDate",
                value: new DateTime(2024, 9, 25, 1, 11, 59, 389, DateTimeKind.Local).AddTicks(1264));
        }
    }
}
