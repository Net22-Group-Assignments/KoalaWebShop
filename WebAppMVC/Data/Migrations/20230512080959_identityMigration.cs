using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class identityMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FK_KoalaCustomerId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FK_KoalaCustomerId",
                table: "Carts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KoalaCustomerId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FK_KoalaCustomerId",
                table: "Orders",
                column: "FK_KoalaCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_FK_KoalaCustomerId",
                table: "Carts",
                column: "FK_KoalaCustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_FK_KoalaCustomerId",
                table: "Carts",
                column: "FK_KoalaCustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_FK_KoalaCustomerId",
                table: "Orders",
                column: "FK_KoalaCustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_FK_KoalaCustomerId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_FK_KoalaCustomerId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_FK_KoalaCustomerId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Carts_FK_KoalaCustomerId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "FK_KoalaCustomerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "FK_KoalaCustomerId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "KoalaCustomerId",
                table: "AspNetUsers");
        }
    }
}
