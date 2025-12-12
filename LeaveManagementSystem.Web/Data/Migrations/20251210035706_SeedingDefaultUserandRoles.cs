using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultUserandRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17d7d0e7-71b9-47a7-a0bb-aaa7318476f3", "978a19be-b7c8-42d1-b3cb-8fb19e6f8756", "Supervisor", "SUPERVISOR" },
                    { "58b9fee9-333f-4278-a792-53860fd0b7ca", "c87b586b-a804-4b71-b671-fc6daac9d338", "Employee", "EMPLOYEE" },
                    { "b29fe88e-ed6d-4359-b82c-5953425ab3e1", "8ff85667-fe7f-4c9d-a30f-28ce536dbd27", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b29fe88e-ed6d-4359-b82c-5953425ab3e1", 0, "a078cae8-0de7-4207-8094-9c133a0a2231", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBhz8hHaAbCMu0ILuGwNqLPqLPH8hj5qXqCqN3qL0wZYTwVfOPfL2qN2JIQH3UM8Fg==", null, false, "e2307f74-c8b6-4b6e-898e-54214ab6abc1", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b29fe88e-ed6d-4359-b82c-5953425ab3e1", "b29fe88e-ed6d-4359-b82c-5953425ab3e1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17d7d0e7-71b9-47a7-a0bb-aaa7318476f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58b9fee9-333f-4278-a792-53860fd0b7ca");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b29fe88e-ed6d-4359-b82c-5953425ab3e1", "b29fe88e-ed6d-4359-b82c-5953425ab3e1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b29fe88e-ed6d-4359-b82c-5953425ab3e1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b29fe88e-ed6d-4359-b82c-5953425ab3e1");
        }
    }
}
