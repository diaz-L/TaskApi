using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskApi.Data.Migrations
{
    public partial class UpdateTaskDatetimePropertyToHaveDefaultValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tasks",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 5, 2, 47, 56, 418, DateTimeKind.Local).AddTicks(1950),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Tasks",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 5, 2, 47, 56, 406, DateTimeKind.Local).AddTicks(6970),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 5, 2, 47, 56, 418, DateTimeKind.Local).AddTicks(4310), new DateTime(2021, 12, 5, 2, 47, 56, 418, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 5, 2, 47, 56, 418, DateTimeKind.Local).AddTicks(6810), new DateTime(2021, 12, 5, 2, 47, 56, 418, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 5, 2, 47, 56, 418, DateTimeKind.Local).AddTicks(6870), new DateTime(2021, 12, 5, 2, 47, 56, 418, DateTimeKind.Local).AddTicks(6880) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tasks",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 12, 5, 2, 47, 56, 418, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Tasks",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 12, 5, 2, 47, 56, 406, DateTimeKind.Local).AddTicks(6970));

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
    }
}
