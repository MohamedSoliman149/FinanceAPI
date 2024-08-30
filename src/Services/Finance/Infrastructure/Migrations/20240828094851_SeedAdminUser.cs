using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceAPI.Infrastructure.Migrations
{
    public partial class SeedAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("66d34029-e5c7-4b79-a83e-0ede0bda3aa7"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("061a9536-98b2-48f7-9e49-8407454d4aaf"), 0, "6fdba48c-8388-4b6c-b047-e553a423d4af", "admin@42.group.com", true, "Admin", "User", false, null, "ADMIN@42.GROUP.COM", "ADMIN@42.GROUP.COM", "AQAAAAIAAYagAAAAEPQA0m/laRzpDGC67HOoi+p1TSue2I/qgKljFy+DumW1dVAQT3YN8yFoduYvh36V+w==", null, false, "", "63f56988-efb0-4063-87ed-65e749b05baf", false, "admin@42.group.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("66d34029-e5c7-4b79-a83e-0ede0bda3aa7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("061a9536-98b2-48f7-9e49-8407454d4aaf"));
        }
    }
}
