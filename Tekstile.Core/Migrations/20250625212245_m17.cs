using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tekstile.Migrations
{
    /// <inheritdoc />
    public partial class m17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Giderlers",
                table: "Giderlers");

            migrationBuilder.RenameTable(
                name: "Giderlers",
                newName: "Giderler");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Giderler",
                table: "Giderler",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Giderler",
                table: "Giderler");

            migrationBuilder.RenameTable(
                name: "Giderler",
                newName: "Giderlers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Giderlers",
                table: "Giderlers",
                column: "Id");
        }
    }
}
