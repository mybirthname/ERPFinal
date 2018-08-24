using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.Data.Migrations
{
    public partial class AddFiledToOrdert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "38cfcddc-e2c8-4c34-b01d-6de9bdbe2875", "c05e36cf-51cb-4293-beed-6bdb36574c45" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "3c7d9095-df98-454f-bf59-1c5a61cedbf3", "2afde020-4da3-4466-af69-0c2ac01b0092" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "5da2b399-b57f-45a8-829e-bb367e999484", "b3dba00b-2624-40ef-8bec-db947db6b4d7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "819e04b3-2891-4569-b2c3-77b2bff52922", "f6496783-517b-4ef8-ab86-0b134d840825" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "c4de9d1c-a721-4232-8c7e-74f097287405", "1884c8bd-6aa8-4ff0-8054-67d090b34bd3" });

            migrationBuilder.AlterColumn<DateTime>(
                name: "SendDate",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<string>(
                name: "AttachmentPath",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryDate",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AttachmentPath",
                table: "OrderPositions",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "AttachmentPath",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeliveryDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AttachmentPath",
                table: "OrderPositions");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SendDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "065548f8-a5a6-4e2a-a30f-000b8d109ed2",
                column: "ConcurrencyStamp",
                value: "6f56a814-7d34-4590-bcd7-712e6d3508c3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3c7d9095-df98-454f-bf59-1c5a61cedbf3", "2afde020-4da3-4466-af69-0c2ac01b0092", "Order", "ORDER" },
                    { "819e04b3-2891-4569-b2c3-77b2bff52922", "f6496783-517b-4ef8-ab86-0b134d840825", "StockReceipt", "STOCKRECEIPT" },
                    { "c4de9d1c-a721-4232-8c7e-74f097287405", "1884c8bd-6aa8-4ff0-8054-67d090b34bd3", "Invoice", "INVOICE" },
                    { "5da2b399-b57f-45a8-829e-bb367e999484", "b3dba00b-2624-40ef-8bec-db947db6b4d7", "Supplier", "SUPPLIER" },
                    { "38cfcddc-e2c8-4c34-b01d-6de9bdbe2875", "c05e36cf-51cb-4293-beed-6bdb36574c45", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49dc92d3-0025-42eb-8bc0-b3c3acde0f39",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp", "UpdateDate" },
                values: new object[] { "97143119-a9b1-4129-8cc9-b5744a3781ad", new DateTime(2018, 8, 23, 1, 7, 32, 48, DateTimeKind.Local), "AQAAAAEAACcQAAAAEGbQY2+jcrMhvAffjxg0VGfSQTt2emXmIYJ3J/nj/RIk6s1Nc7wi6QFbHhNw4VR1aw==", "69f52d75-20f8-471f-8abf-7de6defdf6c1", new DateTime(2018, 8, 23, 1, 7, 32, 49, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "ID",
                keyValue: new Guid("065548f8-a5a6-4e2a-a30f-000b8d109ed2"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2018, 8, 23, 1, 7, 32, 64, DateTimeKind.Local), new DateTime(2018, 8, 23, 1, 7, 32, 64, DateTimeKind.Local) });
        }
    }
}
