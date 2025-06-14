using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tekstile.Migrations
{
    /// <inheritdoc />
    public partial class m14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Kod",
                table: "Musteriler",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BoyaKodu",
                table: "Boyalar",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Musteriler_Kod",
                table: "Musteriler",
                column: "Kod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Boyalar_BoyaKodu",
                table: "Boyalar",
                column: "BoyaKodu",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Musteriler_Kod",
                table: "Musteriler");

            migrationBuilder.DropIndex(
                name: "IX_Boyalar_BoyaKodu",
                table: "Boyalar");

            migrationBuilder.AlterColumn<string>(
                name: "Kod",
                table: "Musteriler",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "BoyaKodu",
                table: "Boyalar",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
