using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAppMVC.Migrations
{
    /// <inheritdoc />
    public partial class InitalizeDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstMidName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RegisteredAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Carts",
                columns: table => new
                {
                    cartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkCustomerId = table.Column<int>(type: "int", nullable: false),
                    KoalaIdId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.cartId);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_KoalaIdId",
                        column: x => x.KoalaIdId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    cartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkCustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.cartId);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_FkCustomerId",
                        column: x => x.FkCustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    FkCategory = table.Column<int>(type: "int", nullable: true),
                    OrdercartId = table.Column<int>(type: "int", nullable: true),
                    cartId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Carts_cartId",
                        column: x => x.cartId,
                        principalTable: "Carts",
                        principalColumn: "cartId");
                    table.ForeignKey(
                        name: "FK_Products_Categories_FkCategory",
                        column: x => x.FkCategory,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                    table.ForeignKey(
                        name: "FK_Products_Orders_OrdercartId",
                        column: x => x.OrdercartId,
                        principalTable: "Orders",
                        principalColumn: "cartId");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ProductReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FK_ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ProductReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_FK_ProductId",
                        column: x => x.FK_ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstMidName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegisteredAt", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 11, 0, "Fakestreet101", "7d16478c-80ec-43fe-94e3-07ab13c38cf1", "jon.westman@mail.com", true, "Jon", "Westman", true, null, "JON.WESTMAN@MAIL.COM", "JON.WESTMAN@MAIL.COM", "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==", null, false, new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8453), "YVMQM56ICOUIV5F2OTMNZEU7H5HJCMXINV2OVSATBYNOTQV4LQHA", false, "jon.westman@mail.com" },
                    { 12, 0, "Fakestreet102", "36752463-45e4-449b-b456-08ab7afeb9eb", "bjorn.agnemo@mail.com", true, "Björn", "Agnemo", true, null, "BJORN.AGNEMO@MAIL.COM", "BJORN.AGNEMO@MAIL.COM", "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==", null, false, new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8503), "YWIHECMCFSWL4BGOB252Z47U4VKFPRKFZ6A4UAZ4GPU6I4QILVRQ", false, "bjorn.agnemo@mail.com" },
                    { 13, 0, "Fakestreet103", "5a025181-5ac6-463a-ac89-86223b236f54", "Oskar.Ahling@mail.com", true, "Oskar", "Åhling", true, null, "OSKAR.AHLING@MAIL.COM", "OSKAR.AHLING@MAIL.COM", "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==", null, false, new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8512), "NA7K6GWHHX65PQFBVTFFN7OSUOFVAM4JVLQVBODJ6JEWOYC545VA", false, "Oskar.Ahling@mail.com" },
                    { 14, 0, "Fakestreet104", "0a60cf9a-0cd3-4753-b5a7-a1ff2da7a7a1", "Reidar.Nilsen@mail.com", true, "Reidar", "Nilsen", true, null, "REIDAR.NILSEN@MAIL.COM", "REIDAR.NILSEN@MAIL.COM", "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==", null, false, new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8520), "7HV7D4HPGACVN2LNYY4M62SVYGDTP5FODUBDAZXGVMMTP572XR7A", false, "Reidar.Nilsen@mail.com" },
                    { 15, 0, "Fakestreet105", "28668eee-bded-457b-a357-74bf2069e455", "Ina.Nilsson@mail.com", true, "Ina", "Nilsson", true, null, "INA.NILSSON@MAIL.COM", "INA.NILSSON@MAIL.COM", "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==", null, false, new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8529), "MCFK7TKJXNZ3NYJFD4GOCGPM4FCTOG3RN26JIJD4COMHGFXSLBDQ", false, "Ina.Nilsson@mail.com" },
                    { 16, 0, "Fakestreet106", "7f22b9ba-550b-4a7b-ba46-5cf12c6694f5", "Martin.Petersson@mail.com", true, "Martin", "Petersson", true, null, "MARTIN.PETERSSON@MAIL.COM", "MARTIN.PETERSSON@MAIL.COM", "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==", null, false, new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8536), "UKU22CFLDWTSV46BP37CLQVBOWMLW4M3I36HBRVDNTP7ZN3DH7LA", false, "Martin.Petersson@mail.com" },
                    { 17, 0, "Fakestreet107", "ae454e74-aa4a-4e85-ac28-0a93be9fcb4b", "Steve.Carell@mail.com", true, "Steve", "Carell", true, null, "STEVE.CARELL@MAIL.COM", "STEVE.CARELL@MAIL.COM", "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==", null, false, new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8554), "Z4GZ6RD6AVH63PUB3AL5LTEDYRVMJGV2T2UWH4I3OL5PD7NGOBDQ", false, "Steve.Carell@mail.com" },
                    { 18, 0, "Fakestreet108", "618e149c-aa8a-4b54-8d23-eea6849428fd", "Grogu.Mandelorian@mail.com", true, "Grogu", "Mandelorian", true, null, "GROGU.MANDELORIAN@MAIL.COM", "GROGU.MANDELORIAN@MAIL.COM", "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==", null, false, new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8579), "7234TR6OXKDKU5JGXAZXCTCWCDODEF4BIYOUJCUI4AFCXSPHJ4CQ", false, "Grogu.Mandelorian@mail.com" },
                    { 19, 0, "Fakestreet109", "89b3e1c0-5507-4551-9211-9314311e7d09", "Lotta.Svensson@mail.com", true, "Lotta", "Svensson", true, null, "LOTTA.SVENSSON@MAIL.COM", "LOTTA.SVENSSON@MAIL.COM", "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==", null, false, new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8587), "CDJ6YGPKEGLGTHRLUH5QNSGMD2UEYXK3SZMZ6TUULH5Y4HQFIXBA", false, "Lotta.Svensson@mail.com" },
                    { 20, 0, "Fakestreet110", "798de012-b68c-438e-b653-cb2c92a8aa6b", "Emilia.Ristersson@mail.com", true, "Emilia", "Ristersson", true, null, "EMILIA.RISTERSSON@MAIL.COM", "EMILIA.RISTERSSON@MAIL.COM", "AQAAAAIAAYagAAAAEFrSRXmpzJHexZy2nKw2V+n87wZAm0zy27J97Wedsi7IDgPv0UDT0FbHzynhFGxSfw==", null, false, new DateTime(2023, 5, 19, 11, 27, 26, 972, DateTimeKind.Local).AddTicks(8596), "5DPYZVILA2FNVUHR4PQWR5ZX4GYRFTTZZDEMGHFUNAA6SRNP3EYQ", false, "Emilia.Ristersson@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Content", "Title" },
                values: new object[,]
                {
                    { 5, "Everything used in sports can be found in this category", "Sport" },
                    { 6, "Everything used in fashion can be found in this category", "Fashion" },
                    { 7, "Everything used in outdoor life can be found in this category", "Outdoor life" },
                    { 8, "Everything used in Electronic can be found in this category", "Electronic" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "FkCategory", "OrdercartId", "Price", "Quantity", "Title", "cartId" },
                values: new object[,]
                {
                    { 11, null, null, 599m, 5, "Jacket", null },
                    { 12, null, null, 499m, 6, "Pants", null },
                    { 13, null, null, 1299m, 11, "HockeyStick", null },
                    { 14, null, null, 399m, 12, "Football", null },
                    { 15, null, null, 2099m, 10, "Snowboard", null },
                    { 16, null, null, 1199m, 5, "HeadPhones", null },
                    { 17, null, null, 649m, 3, "GamingMouse", null },
                    { 18, null, null, 1799m, 7, "Mechanicle Keyboard", null },
                    { 19, null, null, 2199m, 2, "ComputerScreen", null },
                    { 20, null, null, 99m, 15, "MousePad", null }
                });

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
                name: "IX_Carts_KoalaIdId",
                table: "Carts",
                column: "KoalaIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FkCustomerId",
                table: "Orders",
                column: "FkCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_cartId",
                table: "Products",
                column: "cartId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_FkCategory",
                table: "Products",
                column: "FkCategory");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrdercartId",
                table: "Products",
                column: "OrdercartId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_FK_ProductId",
                table: "Reviews",
                column: "FK_ProductId");
        }

        /// <inheritdoc />
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
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
