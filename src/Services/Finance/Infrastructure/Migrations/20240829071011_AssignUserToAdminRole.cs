using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceAPI.Infrastructure.Migrations
{
    public partial class AssignUserToAdminRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("254fbee4-e3c2-4d1a-9580-e3d56449e3fc"), new Guid("88c66435-f147-4e1c-8b38-fefdf1b0b239") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8b1232c-8b67-4e6f-904a-186ebe993537"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("254fbee4-e3c2-4d1a-9580-e3d56449e3fc"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("614067d9-d4ca-409a-bf67-a850646cc892"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f444b113-f89f-4f02-987f-bdcc59ef280f"), 0, "0ed6ce41-d5a0-4c9f-9b53-4f6760fe7b3f", "admin@example.com", true, "Admin", "User", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEF2EzLuOebgzobZU4vFtSMKBEulPnyLbc9AFj7kIh/ZIIezXSnjHsRpZB/H38lqJOA==", null, false, "", "f444b113-f89f-4f02-987f-bdcc59ef280f", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("614067d9-d4ca-409a-bf67-a850646cc892"), new Guid("f444b113-f89f-4f02-987f-bdcc59ef280f") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("614067d9-d4ca-409a-bf67-a850646cc892"), new Guid("f444b113-f89f-4f02-987f-bdcc59ef280f") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("614067d9-d4ca-409a-bf67-a850646cc892"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f444b113-f89f-4f02-987f-bdcc59ef280f"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("254fbee4-e3c2-4d1a-9580-e3d56449e3fc"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f8b1232c-8b67-4e6f-904a-186ebe993537"), 0, "b002a4e7-a48b-453e-84d2-3c77bb6b7eac", "admin@example.com", true, "Admin", "User", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFZ++x5xPXjhzc4qXvLWLMZgHZHaECZmOFFqYlDIG/C79Vfb81KP4wHbto23oOeVGQ==", null, false, "", "eb733f12-bf66-4048-a1ca-ede8d820207b", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("254fbee4-e3c2-4d1a-9580-e3d56449e3fc"), new Guid("88c66435-f147-4e1c-8b38-fefdf1b0b239") });
        }
    }
}
