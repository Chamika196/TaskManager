using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskManager.API.Migrations
{
    /// <inheritdoc />
    public partial class AddDataSet1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaskMs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaskMs",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.InsertData(
                table: "TaskMs",
                columns: new[] { "Id", "Description", "DueDate", "Title" },
                values: new object[,]
                {
                    { 11, "Implement RESTful API for the project", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Develop RESTful API" },
                    { 12, "Create database schema for the application", new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "Design Database Schema" },
                    { 13, "Integrate user authentication using OAuth 2.0", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), "Implement User Authentication" },
                    { 14, "Review and optimize the existing codebase", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "Optimize Codebase" },
                    { 15, "Create unit tests for critical components", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "Write Unit Tests" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaskMs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TaskMs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TaskMs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TaskMs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TaskMs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.InsertData(
                table: "TaskMs",
                columns: new[] { "Id", "Description", "DueDate", "Title" },
                values: new object[,]
                {
                    { 1, "Implement RESTful API for the project", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Develop RESTful API" },
                    { 2, "Create database schema for the application", new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "Design Database Schema" },
                    { 3, "Integrate user authentication using OAuth 2.0", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Local), "Implement User Authentication" },
                    { 4, "Review and optimize the existing codebase", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Local), "Optimize Codebase" },
                    { 5, "Create unit tests for critical components", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "Write Unit Tests" }
                });
        }
    }
}
