using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskManager.API.Migrations
{
    /// <inheritdoc />
    public partial class AddDataSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskMs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "DueDate", "Title" },
                values: new object[] { "Implement RESTful API for the project", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Develop RESTful API" });

            migrationBuilder.UpdateData(
                table: "TaskMs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "DueDate", "Title" },
                values: new object[] { "Create database schema for the application", new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "Design Database Schema" });

            migrationBuilder.InsertData(
                table: "TaskMs",
                columns: new[] { "Id", "Description", "DueDate", "Title" },
                values: new object[,]
                {
                    { 3, "Integrate user authentication using OAuth 2.0", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), "Implement User Authentication" },
                    { 4, "Review and optimize the existing codebase", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "Optimize Codebase" },
                    { 5, "Create unit tests for critical components", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "Write Unit Tests" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaskMs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TaskMs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TaskMs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "TaskMs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "DueDate", "Title" },
                values: new object[] { "Description 1", new DateTime(2024, 1, 18, 11, 58, 17, 807, DateTimeKind.Local).AddTicks(9848), "Task 1" });

            migrationBuilder.UpdateData(
                table: "TaskMs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "DueDate", "Title" },
                values: new object[] { "Description 2", new DateTime(2024, 1, 19, 11, 58, 17, 807, DateTimeKind.Local).AddTicks(9869), "Task 2" });
        }
    }
}
