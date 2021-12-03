using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskApi.Data.Migrations
{
    public partial class AddedNavigationPropertyToTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 3, 2, 28, 9, 597, DateTimeKind.Local).AddTicks(7600), new DateTime(2021, 12, 3, 2, 28, 9, 602, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 3, 2, 28, 9, 602, DateTimeKind.Local).AddTicks(5130), new DateTime(2021, 12, 3, 2, 28, 9, 602, DateTimeKind.Local).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 3, 2, 28, 9, 602, DateTimeKind.Local).AddTicks(5190), new DateTime(2021, 12, 3, 2, 28, 9, 602, DateTimeKind.Local).AddTicks(5190) });
        }
    }
}
