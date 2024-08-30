using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceAPI.Infrastructure.Migrations
{
    public partial class FixNullable_FilePicture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("1f9af0b9-2fb1-45ac-80cf-59b704a00b31"), null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("5496889c-2940-4fbe-b810-dda85b9c6ff5"), 0, "a4bd6f10-1055-4a15-8167-c7182de4d5b3", "admin@example.com", true, "Admin", "User", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEN7iDokXv2q3sCsn76IbDR8MZRaqzZmU6QbkflJqH3rAoUXaVVAhHIoaU6enN/nTzg==", null, false, "", "5496889c-2940-4fbe-b810-dda85b9c6ff5", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("1f9af0b9-2fb1-45ac-80cf-59b704a00b31"), new Guid("5496889c-2940-4fbe-b810-dda85b9c6ff5") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1f9af0b9-2fb1-45ac-80cf-59b704a00b31"), new Guid("5496889c-2940-4fbe-b810-dda85b9c6ff5") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1f9af0b9-2fb1-45ac-80cf-59b704a00b31"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5496889c-2940-4fbe-b810-dda85b9c6ff5"));

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
