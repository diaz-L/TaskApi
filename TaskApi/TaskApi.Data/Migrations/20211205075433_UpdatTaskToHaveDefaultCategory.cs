using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskApi.Data.Migrations
{
    public partial class UpdatTaskToHaveDefaultCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tasks",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 5, 2, 54, 32, 936, DateTimeKind.Local).AddTicks(7910),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 12, 5, 2, 47, 56, 418, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Tasks",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 5, 2, 54, 32, 926, DateTimeKind.Local).AddTicks(3670),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 12, 5, 2, 47, 56, 406, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Tasks",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 5, 2, 54, 32, 937, DateTimeKind.Local).AddTicks(9650), new DateTime(2021, 12, 5, 2, 54, 32, 938, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 5, 2, 54, 32, 938, DateTimeKind.Local).AddTicks(2690), new DateTime(2021, 12, 5, 2, 54, 32, 938, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 5, 2, 54, 32, 938, DateTimeKind.Local).AddTicks(2780), new DateTime(2021, 12, 5, 2, 54, 32, 938, DateTimeKind.Local).AddTicks(2780) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tasks",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 5, 2, 47, 56, 418, DateTimeKind.Local).AddTicks(1950),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 12, 5, 2, 54, 32, 936, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Tasks",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 5, 2, 47, 56, 406, DateTimeKind.Local).AddTicks(6970),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 12, 5, 2, 54, 32, 926, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Tasks",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 1);

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
    }
}
