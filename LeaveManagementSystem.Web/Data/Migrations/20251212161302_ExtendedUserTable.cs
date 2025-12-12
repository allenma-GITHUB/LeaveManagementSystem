using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b29fe88e-ed6d-4359-b82c-5953425ab3e1",
                columns: new[] { "DateOfBirth", "FirstName", "LastName", "PasswordHash" },
                values: new object[] { new DateOnly(1975, 10, 9), "Default", "Admin", "AQAAAAIAAYagAAAAEMydVtNM95kptUlOh9H2YWFym9RxVJ6Akfpku2D1fagkkbtqx9fQXBhEMSR1cC2/eA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b29fe88e-ed6d-4359-b82c-5953425ab3e1",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBhz8hHaAbCMu0ILuGwNqLPqLPH8hj5qXqCqN3qL0wZYTwVfOPfL2qN2JIQH3UM8Fg==");
        }
    }
}
