using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class secondMigraton : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_FK_UserId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_FK_UserId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropIndex(
                name: "IX_Orders_FK_UserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Carts_FK_UserId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "FK_UserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "FK_UserId",
                table: "Carts");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<int>(
                name: "FK_ProductId",
                table: "ProductCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "Totalamount",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemDiscount",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<string>(
                name: "FirstMidName",
                table: "AspNetUsers",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLogin",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "RegisteredAt",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_FK_ProductId",
                table: "ProductCategories",
                column: "FK_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Products_FK_ProductId",
                table: "ProductCategories",
                column: "FK_ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Products_FK_ProductId",
                table: "ProductCategories");

            migrationBuilder.DropIndex(
                name: "IX_ProductCategories_FK_ProductId",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "FK_ProductId",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "FirstMidName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastLogin",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RegisteredAt",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Products",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<float>(
                name: "Discount",
                table: "Products",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<float>(
                name: "Totalamount",
                table: "Orders",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<float>(
                name: "ItemDiscount",
                table: "Orders",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "FK_UserId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FK_UserId",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_AdminId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstMidName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNr = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Profile = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RegisteredAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Admins_FK_AdminId",
                        column: x => x.FK_AdminId,
                        principalTable: "Admins",
                        principalColumn: "AdminId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FK_UserId",
                table: "Orders",
                column: "FK_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_FK_UserId",
                table: "Carts",
                column: "FK_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_FK_AdminId",
                table: "Users",
                column: "FK_AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_FK_UserId",
                table: "Carts",
                column: "FK_UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_FK_UserId",
                table: "Orders",
                column: "FK_UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
