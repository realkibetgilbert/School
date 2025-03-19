using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.API.Migrations
{
    /// <inheritdoc />
    public partial class FileDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7343), new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7351), new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7354), new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7356), new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7358), new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7360), new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7362), new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7364), new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7376), new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7378), new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7380), new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7382), new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7384), new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7386), new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7388), new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7390), new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7392), new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7394), new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7396), new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7398), new DateTime(2025, 3, 17, 11, 59, 0, 141, DateTimeKind.Utc).AddTicks(7399) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6101), new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6140), new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6160), new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6173), new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6193), new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6202), new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6208) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6217), new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6233), new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6245), new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6263), new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6272), new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6288), new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6304), new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6315), new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6321) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6333), new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6336) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6342), new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6358), new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6373), new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6384), new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6403), new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6406) });
        }
    }
}
