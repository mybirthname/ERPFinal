using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.Data.Migrations
{
    public partial class InitialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "065548f8-a5a6-4e2a-a30f-000b8d109ed2",
                column: "ConcurrencyStamp",
                value: "f0e160fb-9779-4dc7-99b7-89010250d0cf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49dc92d3-0025-42eb-8bc0-b3c3acde0f39",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp", "UpdateDate" },
                values: new object[] { "0f4ef273-4ea3-46a7-964e-315599b27169", new DateTime(2018, 8, 19, 5, 15, 49, 336, DateTimeKind.Local), "AQAAAAEAACcQAAAAELtyHd8IkoZ/jTiInP8Nts66bKQNVuck45udTX+R6taTJ9RbP9POq6ujOXMgLbu2lA==", "1f7b21d7-8de6-4df3-9e2f-776cc0af9b42", new DateTime(2018, 8, 19, 5, 15, 49, 338, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "ID",
                keyValue: new Guid("065548f8-a5a6-4e2a-a30f-000b8d109ed2"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2018, 8, 19, 5, 15, 49, 351, DateTimeKind.Local), new DateTime(2018, 8, 19, 5, 15, 49, 351, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
