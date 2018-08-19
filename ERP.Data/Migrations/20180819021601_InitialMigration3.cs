using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.Data.Migrations
{
    public partial class InitialMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "065548f8-a5a6-4e2a-a30f-000b8d109ed2",
                column: "ConcurrencyStamp",
                value: "7d35c1f7-67ae-41a2-9a8e-5991a363b485");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49dc92d3-0025-42eb-8bc0-b3c3acde0f39",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp", "UpdateDate" },
                values: new object[] { "28164a03-8480-4cc0-bdcf-27a8ca4bd1fd", new DateTime(2018, 8, 19, 5, 16, 1, 94, DateTimeKind.Local), "AQAAAAEAACcQAAAAEM5VtQPh69WHjtJlu6WLw0Evx5rB/47K1DrIBUW4FhtT6oihduvjdipsp6S2Kh/EBw==", "fa66e521-295f-43be-87bb-65d197affebd", new DateTime(2018, 8, 19, 5, 16, 1, 95, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "ID",
                keyValue: new Guid("065548f8-a5a6-4e2a-a30f-000b8d109ed2"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2018, 8, 19, 5, 16, 1, 108, DateTimeKind.Local), new DateTime(2018, 8, 19, 5, 16, 1, 108, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
