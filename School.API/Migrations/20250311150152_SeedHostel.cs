using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace School.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedHostel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Hostels",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1L, "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6101), "A boys hostel near the main block", "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6121), "Alpha Hostel" },
                    { 2L, "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6140), "A girls hostel with modern facilities", "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6146), "Beta Hostel" },
                    { 3L, "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6160), "A hostel for senior students", "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6163), "Gamma Hostel" },
                    { 4L, "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6173), "A new hostel with high security", "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6180), "Delta Hostel" },
                    { 5L, "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6193), "Spacious hostel with a gym facility", "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6196), "Epsilon Hostel" },
                    { 6L, "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6202), "Affordable accommodation for students", "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6208), "Zeta Hostel" },
                    { 7L, "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6217), "Premium hostel for postgraduate students", "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6227), "Eta Hostel" },
                    { 8L, "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6233), "Hostel with attached cafeteria", "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6236), "Theta Hostel" },
                    { 9L, "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6245), "Hostel with a large study hall", "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6251), "Iota Hostel" },
                    { 10L, "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6263), "A quiet place for research students", "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6266), "Kappa Hostel" },
                    { 11L, "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6272), "Hostel with a rooftop relaxation area", "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6278), "Lambda Hostel" },
                    { 12L, "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6288), "Affordable hostel near the sports complex", "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6297), "Mu Hostel" },
                    { 13L, "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6304), "Hostel with 24/7 medical assistance", "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6306), "Nu Hostel" },
                    { 14L, "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6315), "An eco-friendly hostel with solar power", "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6321), "Xi Hostel" },
                    { 15L, "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6333), "A centrally located hostel for all", "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6336), "Omicron Hostel" },
                    { 16L, "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6342), "Hostel with a dedicated tech lab", "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6345), "Pi Hostel" },
                    { 17L, "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6358), "A well-ventilated and green hostel", "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6366), "Rho Hostel" },
                    { 18L, "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6373), "Hostel with extra co-curricular facilities", "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6375), "Sigma Hostel" },
                    { 19L, "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6384), "Hostel with a library and digital lab", "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6391), "Tau Hostel" },
                    { 20L, "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6403), "A newly built hostel with modern amenities", "Admin", new DateTime(2025, 3, 11, 15, 1, 50, 657, DateTimeKind.Utc).AddTicks(6406), "Upsilon Hostel" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
