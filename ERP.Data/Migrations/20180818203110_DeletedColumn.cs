using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.Data.Migrations
{
    public partial class DeletedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Deleted",
                table: "Suppliers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Deleted",
                table: "StockReceipts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Deleted",
                table: "StockReceiptPositions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Deleted",
                table: "Organizations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Deleted",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Deleted",
                table: "OrderPositions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Deleted",
                table: "News",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Deleted",
                table: "Invoices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Deleted",
                table: "InvoicePositions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Deleted",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "065548f8-a5a6-4e2a-a30f-000b8d109ed2",
                column: "ConcurrencyStamp",
                value: "525ee629-9019-4a37-9539-cd71a7f9508d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49dc92d3-0025-42eb-8bc0-b3c3acde0f39",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp", "UpdateDate" },
                values: new object[] { "7b4e23ad-47e7-450b-aebb-153b938efb29", new DateTime(2018, 8, 18, 23, 31, 10, 651, DateTimeKind.Local), "AQAAAAEAACcQAAAAEAi18MSbH0K3TZ7kE+wuRQLKv+VrdhgAYv6u2Hk7UogJ5YB8XUXcMuww284t5b1BHQ==", "bf9e8265-475a-453f-89f9-e7a5fc157e4e", new DateTime(2018, 8, 18, 23, 31, 10, 653, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2018, 8, 18, 23, 31, 10, 666, DateTimeKind.Local), new DateTime(2018, 8, 18, 23, 31, 10, 666, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "StockReceipts");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "StockReceiptPositions");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "OrderPositions");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "InvoicePositions");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "065548f8-a5a6-4e2a-a30f-000b8d109ed2",
                column: "ConcurrencyStamp",
                value: "67e287fc-ed95-4993-b26f-a1ca768d5131");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49dc92d3-0025-42eb-8bc0-b3c3acde0f39",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp", "UpdateDate" },
                values: new object[] { "bc2f4004-17bb-4429-960d-5cf78176217c", new DateTime(2018, 8, 18, 14, 24, 10, 223, DateTimeKind.Local), "AQAAAAEAACcQAAAAELkdYbPSu9VUmu2hL43/iD1I41yNBS6BkW6CSSbcBeFWAQ5Tesmq1zo7r1WrdbQ+Mw==", "32fb198f-7fb1-4b64-8558-7f7c0b23ce90", new DateTime(2018, 8, 18, 14, 24, 10, 225, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2018, 8, 18, 14, 24, 10, 238, DateTimeKind.Local), new DateTime(2018, 8, 18, 14, 24, 10, 238, DateTimeKind.Local) });
        }
    }
}
