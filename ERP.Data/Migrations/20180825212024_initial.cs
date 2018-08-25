using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 4000, nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    OrganizationID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    NrIntern = table.Column<string>(maxLength: 50, nullable: false),
                    UserID = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    OrganizationID = table.Column<Guid>(nullable: false),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    Deleted = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 4000, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    Street = table.Column<string>(maxLength: 50, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerOrganizationID = table.Column<Guid>(nullable: false),
                    Phone = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    NrIntern = table.Column<string>(maxLength: 50, nullable: false),
                    UserID = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    OrganizationID = table.Column<Guid>(nullable: false),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    Deleted = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 4000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    NrIntern = table.Column<string>(maxLength: 50, nullable: false),
                    UserID = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    OrganizationID = table.Column<Guid>(nullable: false),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    Deleted = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 4000, nullable: true),
                    SendDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    AmountNet = table.Column<int>(nullable: false),
                    SupplierOrganizationID = table.Column<Guid>(nullable: true),
                    SupplierID = table.Column<Guid>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: true),
                    AttachmentPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ProviderOrganizationID = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 4000, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    Street = table.Column<string>(maxLength: 50, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Phone = table.Column<string>(maxLength: 20, nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    Remark = table.Column<string>(maxLength: 50, nullable: true),
                    Deleted = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    NrIntern = table.Column<string>(maxLength: 50, nullable: false),
                    UserID = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    OrganizationID = table.Column<Guid>(nullable: false),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    Deleted = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 4000, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    Street = table.Column<string>(maxLength: 50, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    SupplierOrganizationID = table.Column<Guid>(nullable: false),
                    Phone = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderPositions",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    NrIntern = table.Column<string>(maxLength: 50, nullable: false),
                    UserID = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    OrganizationID = table.Column<Guid>(nullable: false),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    Deleted = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    OrderID = table.Column<Guid>(nullable: false),
                    AttachmentPath = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPositions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderPositions_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockReceipts",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    NrIntern = table.Column<string>(maxLength: 50, nullable: false),
                    UserID = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    OrganizationID = table.Column<Guid>(nullable: false),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    Deleted = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 4000, nullable: true),
                    SendDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    AmountNet = table.Column<decimal>(nullable: false),
                    OrderID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockReceipts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StockReceipts_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    NrIntern = table.Column<string>(maxLength: 50, nullable: false),
                    UserID = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    OrganizationID = table.Column<Guid>(nullable: false),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    Deleted = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 4000, nullable: true),
                    SendDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    AmountNet = table.Column<decimal>(nullable: false),
                    SupplierOrganizationID = table.Column<Guid>(nullable: false),
                    OrderID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Invoices_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_Organizations_SupplierOrganizationID",
                        column: x => x.SupplierOrganizationID,
                        principalTable: "Organizations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockReceiptPositions",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    NrIntern = table.Column<string>(maxLength: 50, nullable: false),
                    UserID = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    OrganizationID = table.Column<Guid>(nullable: false),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    Deleted = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    StockReceiptID = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockReceiptPositions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StockReceiptPositions_StockReceipts_StockReceiptID",
                        column: x => x.StockReceiptID,
                        principalTable: "StockReceipts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoicePositions",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    NrIntern = table.Column<string>(maxLength: 50, nullable: false),
                    UserID = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    OrganizationID = table.Column<Guid>(nullable: false),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    Deleted = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    InvoiceID = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoicePositions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_InvoicePositions_Invoices_InvoiceID",
                        column: x => x.InvoiceID,
                        principalTable: "Invoices",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "065548f8-a5a6-4e2a-a30f-000b8d109ed2", "c7602496-d764-4a7f-9aed-b76f2f39e68d", "SuperAdmin", "SUPERADMIN" },
                    { "d2484b7a-d555-49de-9aa8-dae591651a18", "e2ab21c1-2fb4-4a8b-a1fe-c15b47a44064", "Order", "ORDER" },
                    { "314705da-cec4-4cac-a164-84dea9e6fafe", "a1c53435-5946-4b68-83b6-9176182c7cf4", "StockReceipt", "STOCKRECEIPT" },
                    { "a04d4a79-7829-4014-8199-8127840db3fe", "832e2a52-49ec-4519-90d6-92d2e40f4d72", "Invoice", "INVOICE" },
                    { "8bc867b3-01a6-4e51-999a-598bb6e1cbd3", "ba97e85d-355c-4563-bd4d-c6b159509d89", "Supplier", "SUPPLIER" },
                    { "e875c0ba-a379-4114-8c9a-3493feb737e9", "5d40b982-7da6-48ea-939f-38a566773e88", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreateBy", "CreateDate", "Description", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrganizationID", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdateBy", "UpdateDate", "UserName" },
                values: new object[] { "49dc92d3-0025-42eb-8bc0-b3c3acde0f39", 0, "e1b8900d-3d8c-4989-8fc0-9251ed3e9fa7", "Automatic Seed Function", new DateTime(2018, 8, 26, 0, 20, 23, 954, DateTimeKind.Local), null, "martin.stanchev87@gmail.com", true, "Martin", "Stanchev", false, null, "MARTIN.STANCHEV87@GMAIL.COM", "MARTIN.STANCHEV87@GMAIL.COM", new Guid("065548f8-a5a6-4e2a-a30f-000b8d109ed2"), "AQAAAAEAACcQAAAAEHP/wuxDATM8MUW7F9RlWPOCGKBZhQ+biqGX56V7KGrmDEJk3opUBKWg30n3mfr0lw==", null, false, "2fbd3b0a-e9cd-4d02-b173-6cf4c07f5ca4", false, "Automatic Seed Function", new DateTime(2018, 8, 26, 0, 20, 23, 956, DateTimeKind.Local), "martin.stanchev87@gmail.com" });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "ID", "City", "Country", "CreateBy", "CreateDate", "Deleted", "Description", "Email", "Phone", "ProviderOrganizationID", "Remark", "Street", "Title", "UpdateBy", "UpdateDate", "ZipCode" },
                values: new object[] { new Guid("065548f8-a5a6-4e2a-a30f-000b8d109ed2"), "Sofia", "Bulgaria", "Automatic Seed Function", new DateTime(2018, 8, 26, 0, 20, 23, 974, DateTimeKind.Local), 0, "Organization of the company which provides ", "ContactCompanyEmail@CompanyDomain.com", "+359 888 123 456", new Guid("00000000-0000-0000-0000-000000000000"), "Values are filled automatically", null, "Provider Organization", "Automatic Seed Function", new DateTime(2018, 8, 26, 0, 20, 23, 974, DateTimeKind.Local), "1000" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "49dc92d3-0025-42eb-8bc0-b3c3acde0f39", "065548f8-a5a6-4e2a-a30f-000b8d109ed2" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicePositions_InvoiceID",
                table: "InvoicePositions",
                column: "InvoiceID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_OrderID",
                table: "Invoices",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_SupplierOrganizationID",
                table: "Invoices",
                column: "SupplierOrganizationID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPositions_OrderID",
                table: "OrderPositions",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_StockReceiptPositions_StockReceiptID",
                table: "StockReceiptPositions",
                column: "StockReceiptID");

            migrationBuilder.CreateIndex(
                name: "IX_StockReceipts_OrderID",
                table: "StockReceipts",
                column: "OrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "IdentityUserClaims");

            migrationBuilder.DropTable(
                name: "InvoicePositions");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "OrderPositions");

            migrationBuilder.DropTable(
                name: "StockReceiptPositions");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "StockReceipts");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
