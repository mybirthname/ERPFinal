using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.Data.Migrations
{
    public partial class AddDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "3c039bd0-fa93-460d-854f-8130d2e29e6d", "65614450-54e9-4edb-bce1-416f9249b6e0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b73298e2-6310-479b-b4dc-6cb86c78ebf7", "63d76371-84da-4601-8ee1-1570c2b180b0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "bd591d09-7749-4d53-976c-e31f20828b96", "e3072e05-ca1b-4eac-b5bf-eab86c960f09" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ddafd137-53fd-40fa-a4f2-defea5a89d02", "b05a8506-72d6-49ab-bb11-b98f9370e3d8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e2fa6ecb-f6d2-49ad-b394-b800703cbd0e", "118c5660-5beb-4843-bd54-444d628bc5eb" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "8edf4c1d-42c5-40ed-afbf-46f47bd43108");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ddafd137-53fd-40fa-a4f2-defea5a89d02", "b05a8506-72d6-49ab-bb11-b98f9370e3d8", "Order", "ORDER" },
                    { "3c039bd0-fa93-460d-854f-8130d2e29e6d", "65614450-54e9-4edb-bce1-416f9249b6e0", "StockReceipt", "STOCKRECEIPT" },
                    { "bd591d09-7749-4d53-976c-e31f20828b96", "e3072e05-ca1b-4eac-b5bf-eab86c960f09", "Invoice", "INVOICE" },
                    { "b73298e2-6310-479b-b4dc-6cb86c78ebf7", "63d76371-84da-4601-8ee1-1570c2b180b0", "Supplier", "SUPPLIER" },
                    { "e2fa6ecb-f6d2-49ad-b394-b800703cbd0e", "118c5660-5beb-4843-bd54-444d628bc5eb", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49dc92d3-0025-42eb-8bc0-b3c3acde0f39",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp", "UpdateDate" },
                values: new object[] { "7499dbda-792e-4d56-b0a6-f43a7046ecbb", new DateTime(2018, 8, 24, 9, 3, 59, 684, DateTimeKind.Local), "AQAAAAEAACcQAAAAEBFuakaYleC/Hpe/xbIbno20u0RAXQ1zKM6ifmvRyLDV024lxClkF6/COmDuSIQ8Hg==", "7e1ed5d7-0ecd-4136-b59c-eb6eb7fc6962", new DateTime(2018, 8, 24, 9, 3, 59, 686, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "ID",
                keyValue: new Guid("065548f8-a5a6-4e2a-a30f-000b8d109ed2"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2018, 8, 24, 9, 3, 59, 698, DateTimeKind.Local), new DateTime(2018, 8, 24, 9, 3, 59, 698, DateTimeKind.Local) });
        }
    }
}
