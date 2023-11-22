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
            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Vehicles",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Vehicles",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Models",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Models",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Makes",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Makes",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Customers",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Customers",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Colours",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Colours",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Bookings",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Bookings",
                newName: "DateCreated");

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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "9dddc73c-be4c-4e71-979a-845872b413f3", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEO105bZclYqcbBMZkd+B6FiGwqVrHpGcAgMOxeUEwyiM6+58m/J4HgFMbInMDQzJ/g==", null, false, "dc3c255a-d21f-4786-8f98-66b81743fd24", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 42, 4, 56, DateTimeKind.Local).AddTicks(3227), new DateTime(2023, 11, 22, 11, 42, 4, 56, DateTimeKind.Local).AddTicks(3245), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 42, 4, 56, DateTimeKind.Local).AddTicks(3249), new DateTime(2023, 11, 22, 11, 42, 4, 56, DateTimeKind.Local).AddTicks(3250), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 42, 4, 56, DateTimeKind.Local).AddTicks(3829), new DateTime(2023, 11, 22, 11, 42, 4, 56, DateTimeKind.Local).AddTicks(3830), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 42, 4, 56, DateTimeKind.Local).AddTicks(3833), new DateTime(2023, 11, 22, 11, 42, 4, 56, DateTimeKind.Local).AddTicks(3833), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 22, 11, 42, 4, 56, DateTimeKind.Local).AddTicks(4151), new DateTime(2023, 11, 22, 11, 42, 4, 56, DateTimeKind.Local).AddTicks(4151), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 22, 11, 42, 4, 56, DateTimeKind.Local).AddTicks(4155), new DateTime(2023, 11, 22, 11, 42, 4, 56, DateTimeKind.Local).AddTicks(4155), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 22, 11, 42, 4, 56, DateTimeKind.Local).AddTicks(4157), new DateTime(2023, 11, 22, 11, 42, 4, 56, DateTimeKind.Local).AddTicks(4158), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 22, 11, 42, 4, 56, DateTimeKind.Local).AddTicks(4160), new DateTime(2023, 11, 22, 11, 42, 4, 56, DateTimeKind.Local).AddTicks(4161), "Rav4", "System" }
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

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Vehicles",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Vehicles",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Models",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Models",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Makes",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Makes",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Customers",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Customers",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Colours",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Colours",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Bookings",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Bookings",
                newName: "DataCreated");
        }
    }
}
