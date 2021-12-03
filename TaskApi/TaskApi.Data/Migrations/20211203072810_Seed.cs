using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskApi.Data.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "work" },
                    { 2, "home" },
                    { 3, "entertainment" },
                    { 4, "Miscellaneous" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskId", "Body", "CategoryId", "CreatedOn", "HasCompleted", "LastModified" },
                values: new object[,]
                {
                    { 1, "task one", 1, new DateTime(2021, 12, 3, 2, 28, 9, 597, DateTimeKind.Local).AddTicks(7600), false, new DateTime(2021, 12, 3, 2, 28, 9, 602, DateTimeKind.Local).AddTicks(3340) },
                    { 2, "task two", 2, new DateTime(2021, 12, 3, 2, 28, 9, 602, DateTimeKind.Local).AddTicks(5130), false, new DateTime(2021, 12, 3, 2, 28, 9, 602, DateTimeKind.Local).AddTicks(5150) },
                    { 3, "task three", 2, new DateTime(2021, 12, 3, 2, 28, 9, 602, DateTimeKind.Local).AddTicks(5190), false, new DateTime(2021, 12, 3, 2, 28, 9, 602, DateTimeKind.Local).AddTicks(5190) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);
        }
    }
}
