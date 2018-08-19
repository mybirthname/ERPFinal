using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.Data.Migrations
{
    public partial class InitialMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "065548f8-a5a6-4e2a-a30f-000b8d109ed2",
                column: "ConcurrencyStamp",
                value: "9e2aed98-761d-43ff-8456-3a5aa58cb9b2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49dc92d3-0025-42eb-8bc0-b3c3acde0f39",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp", "UpdateDate" },
                values: new object[] { "69bf0484-2995-4ecd-ba6d-314f19c7e0e8", new DateTime(2018, 8, 19, 5, 16, 46, 686, DateTimeKind.Local), "AQAAAAEAACcQAAAAEB88M+z7rdbgsic0bNhDLYlmGAlC5B8iI/uYDD14fRMarOxFRgLwI1i7Pp+bt45XyA==", "92afb652-0a63-4dfb-b5a0-511d456feda6", new DateTime(2018, 8, 19, 5, 16, 46, 688, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "ID",
                keyValue: new Guid("065548f8-a5a6-4e2a-a30f-000b8d109ed2"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2018, 8, 19, 5, 16, 46, 701, DateTimeKind.Local), new DateTime(2018, 8, 19, 5, 16, 46, 701, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
