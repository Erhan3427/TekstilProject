using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tekstile.Migrations
{
    /// <inheritdoc />
    public partial class m6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MusteriId",
                table: "DesenBoyalari",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DesenBoyalari_MusteriId",
                table: "DesenBoyalari",
                column: "MusteriId");

            migrationBuilder.AddForeignKey(
                name: "FK_DesenBoyalari_Musteriler_MusteriId",
                table: "DesenBoyalari",
                column: "MusteriId",
                principalTable: "Musteriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DesenBoyalari_Musteriler_MusteriId",
                table: "DesenBoyalari");

            migrationBuilder.DropIndex(
                name: "IX_DesenBoyalari_MusteriId",
                table: "DesenBoyalari");

            migrationBuilder.DropColumn(
                name: "MusteriId",
                table: "DesenBoyalari");
        }
    }
}
