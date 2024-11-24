using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "5ab33238-af69-4a0c-a563-c565337d93df", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBZqhhUe46rsWKzGRhFfy7ygavl3uiBDZ+ddrMM79itWHuvyMo1h3ZgQHk/kd0mdpQ==", null, false, "c9427395-6549-42af-98eb-3578eb05bc63", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 47, 43, 934, DateTimeKind.Local).AddTicks(911), new DateTime(2024, 11, 18, 16, 47, 43, 934, DateTimeKind.Local).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 47, 43, 934, DateTimeKind.Local).AddTicks(928), new DateTime(2024, 11, 18, 16, 47, 43, 934, DateTimeKind.Local).AddTicks(928) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 47, 43, 934, DateTimeKind.Local).AddTicks(1211), new DateTime(2024, 11, 18, 16, 47, 43, 934, DateTimeKind.Local).AddTicks(1211) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 47, 43, 934, DateTimeKind.Local).AddTicks(1213), new DateTime(2024, 11, 18, 16, 47, 43, 934, DateTimeKind.Local).AddTicks(1213) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 47, 43, 934, DateTimeKind.Local).AddTicks(1104), new DateTime(2024, 11, 18, 16, 47, 43, 934, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 47, 43, 934, DateTimeKind.Local).AddTicks(1107), new DateTime(2024, 11, 18, 16, 47, 43, 934, DateTimeKind.Local).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 47, 43, 934, DateTimeKind.Local).AddTicks(1109), new DateTime(2024, 11, 18, 16, 47, 43, 934, DateTimeKind.Local).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 47, 43, 934, DateTimeKind.Local).AddTicks(1110), new DateTime(2024, 11, 18, 16, 47, 43, 934, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 21, 51, 78, DateTimeKind.Local).AddTicks(6747), new DateTime(2024, 11, 18, 16, 21, 51, 78, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 21, 51, 78, DateTimeKind.Local).AddTicks(6761), new DateTime(2024, 11, 18, 16, 21, 51, 78, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 21, 51, 78, DateTimeKind.Local).AddTicks(7031), new DateTime(2024, 11, 18, 16, 21, 51, 78, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 21, 51, 78, DateTimeKind.Local).AddTicks(7033), new DateTime(2024, 11, 18, 16, 21, 51, 78, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 21, 51, 78, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 11, 18, 16, 21, 51, 78, DateTimeKind.Local).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 21, 51, 78, DateTimeKind.Local).AddTicks(6933), new DateTime(2024, 11, 18, 16, 21, 51, 78, DateTimeKind.Local).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 21, 51, 78, DateTimeKind.Local).AddTicks(6935), new DateTime(2024, 11, 18, 16, 21, 51, 78, DateTimeKind.Local).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 21, 51, 78, DateTimeKind.Local).AddTicks(6937), new DateTime(2024, 11, 18, 16, 21, 51, 78, DateTimeKind.Local).AddTicks(6937) });
        }
    }
}
