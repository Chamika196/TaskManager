using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskManager.API.Migrations
{
    /// <inheritdoc />
    public partial class datatest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TaskMs",
                columns: new[] { "Id", "Description", "DueDate", "Title" },
                values: new object[,]
                {
                    { 1, "Description 1", new DateTime(2024, 1, 18, 11, 58, 17, 807, DateTimeKind.Local).AddTicks(9848), "Task 1" },
                    { 2, "Description 2", new DateTime(2024, 1, 19, 11, 58, 17, 807, DateTimeKind.Local).AddTicks(9869), "Task 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaskMs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaskMs",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
