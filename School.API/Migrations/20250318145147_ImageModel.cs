using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.API.Migrations
{
    /// <inheritdoc />
    public partial class ImageModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileExtension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6719), new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6730), new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6733), new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6737), new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6738) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6739), new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6741), new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6744), new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6748), new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6750), new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6752), new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6755), new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6759), new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6762), new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6764), new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6766), new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6769), new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6771), new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6773), new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6775), new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6778), new DateTime(2025, 3, 18, 14, 51, 46, 465, DateTimeKind.Utc).AddTicks(6778) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

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
    }
}
