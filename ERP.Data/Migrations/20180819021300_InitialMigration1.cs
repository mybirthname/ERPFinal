using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.Data.Migrations
{
    public partial class InitialMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "065548f8-a5a6-4e2a-a30f-000b8d109ed2",
                column: "ConcurrencyStamp",
                value: "1b320143-e7fc-4b68-99e8-3192a871d19e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49dc92d3-0025-42eb-8bc0-b3c3acde0f39",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp", "UpdateDate" },
                values: new object[] { "2cc6f885-d16d-4201-9c75-865a5802ce91", new DateTime(2018, 8, 19, 5, 12, 59, 900, DateTimeKind.Local), "AQAAAAEAACcQAAAAEIdlhRKIVQ5pUkgKProOTNtzHAGKFOlNvsSH6YrwVZQM4a1mYJMMb1tgxyIeR/3BHQ==", "ff9b1d55-f039-4a65-bdb1-94c31b5001bc", new DateTime(2018, 8, 19, 5, 12, 59, 901, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "ID",
                keyValue: new Guid("065548f8-a5a6-4e2a-a30f-000b8d109ed2"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2018, 8, 19, 5, 12, 59, 914, DateTimeKind.Local), new DateTime(2018, 8, 19, 5, 12, 59, 914, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "065548f8-a5a6-4e2a-a30f-000b8d109ed2",
                column: "ConcurrencyStamp",
                value: "33542a57-fb53-4b65-9477-41252131984e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49dc92d3-0025-42eb-8bc0-b3c3acde0f39",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp", "UpdateDate" },
                values: new object[] { "e255971d-bdb1-4281-9e5f-593cb4d95d97", new DateTime(2018, 8, 19, 2, 32, 29, 903, DateTimeKind.Local), "AQAAAAEAACcQAAAAEHGkmG2aw1+J6VLOsY+Lp+Xx7Yog2klxJ8cvgcKJvv3JFs4Pq4qklW7t0p3kssQ5FA==", "878c50ab-59bc-4ed9-96b9-3a92bb87641c", new DateTime(2018, 8, 19, 2, 32, 29, 904, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "ID",
                keyValue: new Guid("065548f8-a5a6-4e2a-a30f-000b8d109ed2"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2018, 8, 19, 2, 32, 29, 917, DateTimeKind.Local), new DateTime(2018, 8, 19, 2, 32, 29, 917, DateTimeKind.Local) });
        }
    }
}
