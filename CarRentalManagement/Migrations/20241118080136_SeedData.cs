using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 1, 35, 545, DateTimeKind.Local).AddTicks(2338), new DateTime(2024, 11, 18, 16, 1, 35, 545, DateTimeKind.Local).AddTicks(2350), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 1, 35, 545, DateTimeKind.Local).AddTicks(2352), new DateTime(2024, 11, 18, 16, 1, 35, 545, DateTimeKind.Local).AddTicks(2353), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 1, 35, 545, DateTimeKind.Local).AddTicks(2613), new DateTime(2024, 11, 18, 16, 1, 35, 545, DateTimeKind.Local).AddTicks(2613), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 1, 35, 545, DateTimeKind.Local).AddTicks(2614), new DateTime(2024, 11, 18, 16, 1, 35, 545, DateTimeKind.Local).AddTicks(2615), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 1, 35, 545, DateTimeKind.Local).AddTicks(2532), new DateTime(2024, 11, 18, 16, 1, 35, 545, DateTimeKind.Local).AddTicks(2533), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 1, 35, 545, DateTimeKind.Local).AddTicks(2535), new DateTime(2024, 11, 18, 16, 1, 35, 545, DateTimeKind.Local).AddTicks(2536), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 16, 1, 35, 545, DateTimeKind.Local).AddTicks(2537), new DateTime(2024, 11, 18, 16, 1, 35, 545, DateTimeKind.Local).AddTicks(2538), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 16, 1, 35, 545, DateTimeKind.Local).AddTicks(2539), new DateTime(2024, 11, 18, 16, 1, 35, 545, DateTimeKind.Local).AddTicks(2539), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
