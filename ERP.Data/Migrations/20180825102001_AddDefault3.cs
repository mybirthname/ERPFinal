using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.Data.Migrations
{
    public partial class AddDefault3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "28370cf4-4a5a-45de-9593-1caa71155238", "02e0ee59-c38d-4527-b603-9e29f63146d4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "3c505214-66a4-46ba-87cf-e44f0ea4a995", "3d5d6066-9fc7-4dda-a123-a18cf0991d40" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "59a78f86-e7f4-4893-a7fc-7f3b195dc5ff", "88add917-5ae0-409f-89e2-581cd846a838" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7d371ee9-3754-42fd-bad9-86feec0f5ef2", "09865a7f-4a72-48db-94cf-47cc3a55820a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c125bca5-7877-4423-bc47-59a56dbe5fb2", "b432df60-5f6a-4ec5-9f43-7c1601ecc25e" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "065548f8-a5a6-4e2a-a30f-000b8d109ed2",
                column: "ConcurrencyStamp",
                value: "be84ada0-4878-4662-9f66-ad218564ab39");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "db24fb40-e9b2-4f69-a631-64839af694c9", "a2e5a5cb-49ca-463b-9672-5fee58d3bebd", "Order", "ORDER" },
                    { "1f01f9b2-505a-4562-a1cc-e513b727f017", "6614ccf4-1c2f-48ea-92b7-bf3d1a55dce6", "StockReceipt", "STOCKRECEIPT" },
                    { "7b19ee1f-272b-441c-b12e-edeb4ce6504d", "2a2c14c9-9963-48e5-b253-0e2959f10532", "Invoice", "INVOICE" },
                    { "e50d6d13-917c-4147-822f-049a019c8716", "3c8494e9-d6d0-4417-9e19-032276d7b674", "Supplier", "SUPPLIER" },
                    { "98c78665-dd66-4459-9fa3-4495cf28005d", "87166fe9-f59d-4f78-9895-e29711739ae3", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49dc92d3-0025-42eb-8bc0-b3c3acde0f39",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp", "UpdateDate" },
                values: new object[] { "66eb8b22-55e6-43b4-b317-f70de58aae8d", new DateTime(2018, 8, 25, 13, 20, 0, 811, DateTimeKind.Local), "AQAAAAEAACcQAAAAEJnVMA97ZSq0QJkGbJmz/Pwo2foBWWrzGL9GempX6N+jNXxNs/9fZj22JkWBt83hbg==", "b399d2c8-aaca-40a7-b147-7982c31c8703", new DateTime(2018, 8, 25, 13, 20, 0, 813, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "ID",
                keyValue: new Guid("065548f8-a5a6-4e2a-a30f-000b8d109ed2"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2018, 8, 25, 13, 20, 0, 826, DateTimeKind.Local), new DateTime(2018, 8, 25, 13, 20, 0, 826, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1f01f9b2-505a-4562-a1cc-e513b727f017", "6614ccf4-1c2f-48ea-92b7-bf3d1a55dce6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7b19ee1f-272b-441c-b12e-edeb4ce6504d", "2a2c14c9-9963-48e5-b253-0e2959f10532" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "98c78665-dd66-4459-9fa3-4495cf28005d", "87166fe9-f59d-4f78-9895-e29711739ae3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "db24fb40-e9b2-4f69-a631-64839af694c9", "a2e5a5cb-49ca-463b-9672-5fee58d3bebd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e50d6d13-917c-4147-822f-049a019c8716", "3c8494e9-d6d0-4417-9e19-032276d7b674" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "065548f8-a5a6-4e2a-a30f-000b8d109ed2",
                column: "ConcurrencyStamp",
                value: "87c9cf67-b558-48c2-8d76-880526cfa3fc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3c505214-66a4-46ba-87cf-e44f0ea4a995", "3d5d6066-9fc7-4dda-a123-a18cf0991d40", "Order", "ORDER" },
                    { "28370cf4-4a5a-45de-9593-1caa71155238", "02e0ee59-c38d-4527-b603-9e29f63146d4", "StockReceipt", "STOCKRECEIPT" },
                    { "59a78f86-e7f4-4893-a7fc-7f3b195dc5ff", "88add917-5ae0-409f-89e2-581cd846a838", "Invoice", "INVOICE" },
                    { "7d371ee9-3754-42fd-bad9-86feec0f5ef2", "09865a7f-4a72-48db-94cf-47cc3a55820a", "Supplier", "SUPPLIER" },
                    { "c125bca5-7877-4423-bc47-59a56dbe5fb2", "b432df60-5f6a-4ec5-9f43-7c1601ecc25e", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49dc92d3-0025-42eb-8bc0-b3c3acde0f39",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp", "UpdateDate" },
                values: new object[] { "c324b854-993f-4a82-898f-0e465c893635", new DateTime(2018, 8, 25, 9, 26, 48, 787, DateTimeKind.Local), "AQAAAAEAACcQAAAAEN8qxaf3flb76w8pcLwSEa4yvWaMAe5clQ1RtrDg1tDNQEdzX8L0yZxTFxzSR7/LVw==", "50b70623-4b29-40ea-8b1f-d09980513c39", new DateTime(2018, 8, 25, 9, 26, 48, 788, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "ID",
                keyValue: new Guid("065548f8-a5a6-4e2a-a30f-000b8d109ed2"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2018, 8, 25, 9, 26, 48, 801, DateTimeKind.Local), new DateTime(2018, 8, 25, 9, 26, 48, 801, DateTimeKind.Local) });
        }
    }
}
