using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskApi.Data.Migrations
{
    public partial class RemoveNavigationalPropertyFromCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 3, 3, 35, 56, 770, DateTimeKind.Local).AddTicks(7180), new DateTime(2021, 12, 3, 3, 35, 56, 776, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 3, 3, 35, 56, 776, DateTimeKind.Local).AddTicks(3210), new DateTime(2021, 12, 3, 3, 35, 56, 776, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 3, 3, 35, 56, 776, DateTimeKind.Local).AddTicks(3300), new DateTime(2021, 12, 3, 3, 35, 56, 776, DateTimeKind.Local).AddTicks(3300) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 3, 3, 5, 49, 814, DateTimeKind.Local).AddTicks(580), new DateTime(2021, 12, 3, 3, 5, 49, 818, DateTimeKind.Local).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 3, 3, 5, 49, 818, DateTimeKind.Local).AddTicks(7770), new DateTime(2021, 12, 3, 3, 5, 49, 818, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 3, 3, 5, 49, 818, DateTimeKind.Local).AddTicks(7820), new DateTime(2021, 12, 3, 3, 5, 49, 818, DateTimeKind.Local).AddTicks(7830) });
        }
    }
}
