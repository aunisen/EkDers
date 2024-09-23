using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EkDers.Data.Migrations
{
    /// <inheritdoc />
    public partial class secondmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Gorev",
                keyColumn: "Id",
                keyValue: new Guid("0c30e774-4b13-4ec4-b354-157728ffb11c"),
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 15, 42, 43, 366, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Gorev",
                keyColumn: "Id",
                keyValue: new Guid("35084397-55c0-47bb-b1fe-17f02ff27601"),
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 15, 42, 43, 366, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "Gorev",
                keyColumn: "Id",
                keyValue: new Guid("3b4dcbef-c723-40be-b73e-19cd09604c59"),
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 15, 42, 43, 366, DateTimeKind.Local).AddTicks(6488));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Gorev",
                keyColumn: "Id",
                keyValue: new Guid("0c30e774-4b13-4ec4-b354-157728ffb11c"),
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 15, 34, 29, 112, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Gorev",
                keyColumn: "Id",
                keyValue: new Guid("35084397-55c0-47bb-b1fe-17f02ff27601"),
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 15, 34, 29, 112, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Gorev",
                keyColumn: "Id",
                keyValue: new Guid("3b4dcbef-c723-40be-b73e-19cd09604c59"),
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 15, 34, 29, 112, DateTimeKind.Local).AddTicks(8575));
        }
    }
}
