using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tekstile.Migrations
{
    /// <inheritdoc />
    public partial class m11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Durum",
                table: "Siparisler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ToplamFiyat",
                table: "Siparisler",
                type: "decimal(18,2)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Siparisler");

            migrationBuilder.DropColumn(
                name: "ToplamFiyat",
                table: "Siparisler");
        }
    }
}
