using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.Data.Migrations
{
    public partial class AddRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "065548f8-a5a6-4e2a-a30f-000b8d109ed2",
                column: "ConcurrencyStamp",
                value: "2589bb0f-91bb-49b9-96f4-213b8b3e4fc7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "345806a3-f0a1-4ff6-ac5b-2a6c0e291d6e", "145fc595-b259-4f0c-a072-c8b689d2a8df", "Order", "ORDER" },
                    { "f5359537-484c-4e8a-8909-0b8fd7007263", "e1e05435-c955-419b-990c-4447a0f57bee", "StockReceipt", "STOCKRECEIPT" },
                    { "10fb7884-3447-4a03-ab1d-3d2fa13fb63a", "0101e2e6-fe07-4df4-9875-424f313339ec", "Invoice", "INVOICE" },
                    { "c23b922c-779e-4814-a15b-d8b9651962e5", "f780de20-7617-41dd-898c-d6b1aa38af98", "Supplier", "SUPPLIER" },
                    { "f42af5c2-3eba-40d8-8162-635399364e75", "4819ff2b-d4e7-4c50-b484-fc98a9dd8abc", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49dc92d3-0025-42eb-8bc0-b3c3acde0f39",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp", "UpdateDate" },
                values: new object[] { "b1950900-5a30-45de-82e7-0dfb35ab790b", new DateTime(2018, 8, 19, 12, 59, 10, 454, DateTimeKind.Local), "AQAAAAEAACcQAAAAEIUVTTdzuT58n1GpBzhXaBzlPNkl0q91A57/qLrwufdJY3ePbAjZCsZ5oQjnTeoncg==", "e357420d-e08b-40e2-befb-525dcb6116fe", new DateTime(2018, 8, 19, 12, 59, 10, 455, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "ID",
                keyValue: new Guid("065548f8-a5a6-4e2a-a30f-000b8d109ed2"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2018, 8, 19, 12, 59, 10, 469, DateTimeKind.Local), new DateTime(2018, 8, 19, 12, 59, 10, 469, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "10fb7884-3447-4a03-ab1d-3d2fa13fb63a", "0101e2e6-fe07-4df4-9875-424f313339ec" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "345806a3-f0a1-4ff6-ac5b-2a6c0e291d6e", "145fc595-b259-4f0c-a072-c8b689d2a8df" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c23b922c-779e-4814-a15b-d8b9651962e5", "f780de20-7617-41dd-898c-d6b1aa38af98" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f42af5c2-3eba-40d8-8162-635399364e75", "4819ff2b-d4e7-4c50-b484-fc98a9dd8abc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f5359537-484c-4e8a-8909-0b8fd7007263", "e1e05435-c955-419b-990c-4447a0f57bee" });

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
    }
}
