using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.Data.Migrations
{
    public partial class addOrganizationFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Suppliers",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SupplierOrganizationID",
                table: "Suppliers",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Customers",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerOrganizationID",
                table: "Customers",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "SupplierOrganizationID",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "CustomerOrganizationID",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Suppliers",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Customers",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

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
    }
}
