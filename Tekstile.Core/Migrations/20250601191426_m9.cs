using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tekstile.Migrations
{
    /// <inheritdoc />
    public partial class m9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Desenler_Musteriler_MusteriId",
                table: "Desenler");

            migrationBuilder.DropColumn(
                name: "Boyasayisi",
                table: "Desenler");

            migrationBuilder.DropColumn(
                name: "GramMiktari",
                table: "DesenBoyalari");

            migrationBuilder.RenameColumn(
                name: "MusteriId",
                table: "Desenler",
                newName: "MusterilerId");

            migrationBuilder.RenameIndex(
                name: "IX_Desenler_MusteriId",
                table: "Desenler",
                newName: "IX_Desenler_MusterilerId");

            migrationBuilder.AddColumn<int>(
                name: "BoyaSayisi",
                table: "DesenBoyalari",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Desenler_Musteriler_MusterilerId",
                table: "Desenler",
                column: "MusterilerId",
                principalTable: "Musteriler",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Desenler_Musteriler_MusterilerId",
                table: "Desenler");

            migrationBuilder.DropColumn(
                name: "BoyaSayisi",
                table: "DesenBoyalari");

            migrationBuilder.RenameColumn(
                name: "MusterilerId",
                table: "Desenler",
                newName: "MusteriId");

            migrationBuilder.RenameIndex(
                name: "IX_Desenler_MusterilerId",
                table: "Desenler",
                newName: "IX_Desenler_MusteriId");

            migrationBuilder.AddColumn<int>(
                name: "Boyasayisi",
                table: "Desenler",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "GramMiktari",
                table: "DesenBoyalari",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Desenler_Musteriler_MusteriId",
                table: "Desenler",
                column: "MusteriId",
                principalTable: "Musteriler",
                principalColumn: "Id");
        }
    }
}
