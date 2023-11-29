using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "d7e1ec20-d9a6-4450-af2f-791eea2c4fce", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAENNKBiKthLgZxH/ANtmHbj79qZ9X7uYI4RKtslGOjU0+DxC/U7jSK1I5hRur64a1+g==", null, false, "25478f2b-9a80-4b8d-b2e5-b927396c03c3", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 30, 4, 0, 27, 632, DateTimeKind.Local).AddTicks(7889), new DateTime(2023, 11, 30, 4, 0, 27, 632, DateTimeKind.Local).AddTicks(7902), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 30, 4, 0, 27, 632, DateTimeKind.Local).AddTicks(7908), new DateTime(2023, 11, 30, 4, 0, 27, 632, DateTimeKind.Local).AddTicks(7910), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 30, 4, 0, 27, 632, DateTimeKind.Local).AddTicks(9333), new DateTime(2023, 11, 30, 4, 0, 27, 632, DateTimeKind.Local).AddTicks(9340), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 30, 4, 0, 27, 632, DateTimeKind.Local).AddTicks(9343), new DateTime(2023, 11, 30, 4, 0, 27, 632, DateTimeKind.Local).AddTicks(9345), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 30, 4, 0, 27, 633, DateTimeKind.Local).AddTicks(232), new DateTime(2023, 11, 30, 4, 0, 27, 633, DateTimeKind.Local).AddTicks(237), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 30, 4, 0, 27, 633, DateTimeKind.Local).AddTicks(241), new DateTime(2023, 11, 30, 4, 0, 27, 633, DateTimeKind.Local).AddTicks(243), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 30, 4, 0, 27, 633, DateTimeKind.Local).AddTicks(246), new DateTime(2023, 11, 30, 4, 0, 27, 633, DateTimeKind.Local).AddTicks(248), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 30, 4, 0, 27, 633, DateTimeKind.Local).AddTicks(251), new DateTime(2023, 11, 30, 4, 0, 27, 633, DateTimeKind.Local).AddTicks(254), "RAV4", "System" }
                });

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
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
