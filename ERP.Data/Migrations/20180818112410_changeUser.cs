using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.Data.Migrations
{
    public partial class changeUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Suppliers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "StockReceipts",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "StockReceiptPositions",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "OrderPositions",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "News",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Invoices",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "InvoicePositions",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Suppliers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "StockReceipts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "StockReceiptPositions",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "OrderPositions",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "News",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Invoices",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "InvoicePositions",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "065548f8-a5a6-4e2a-a30f-000b8d109ed2",
                column: "ConcurrencyStamp",
                value: "a5542435-b54d-479d-8e25-84205490d98c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49dc92d3-0025-42eb-8bc0-b3c3acde0f39",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp", "UpdateDate" },
                values: new object[] { "4f73aaa9-319a-4d68-b548-9f1d0f07ce46", new DateTime(2018, 8, 17, 12, 34, 1, 313, DateTimeKind.Local), "AQAAAAEAACcQAAAAEJ60+IqiplcI1YGiBfSp2Bx5dQwDJcErdJn9PAJ+8z1b4mcQCu7ummCaZy/HW3oorA==", "84d53731-cec2-4fe7-b31c-64696a67a908", new DateTime(2018, 8, 17, 12, 34, 1, 315, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2018, 8, 17, 12, 34, 1, 327, DateTimeKind.Local), new DateTime(2018, 8, 17, 12, 34, 1, 327, DateTimeKind.Local) });
        }
    }
}
