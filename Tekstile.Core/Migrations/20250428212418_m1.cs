using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tekstile.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boyalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoyaKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RenkAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoyaTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KovaAdedi = table.Column<int>(type: "int", nullable: true),
                    BoyaFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StokDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GelenAdet = table.Column<int>(type: "int", nullable: true),
                    BitenAdet = table.Column<int>(type: "int", nullable: true),
                    AcilanAdet = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boyalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kumascinsleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KumasAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gramaj = table.Column<int>(type: "int", nullable: true),
                    IplikTipi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kumascinsleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Makineler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MakineAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Makineler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YetkiliAdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Desenler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesenAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FotoYolu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Boyasayisi = table.Column<int>(type: "int", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desenler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Desenler_Musteriler_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteriler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DesenBoyalari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesenId = table.Column<int>(type: "int", nullable: false),
                    BoyaId = table.Column<int>(type: "int", nullable: false),
                    GramMiktari = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesenBoyalari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DesenBoyalari_Boyalar_BoyaId",
                        column: x => x.BoyaId,
                        principalTable: "Boyalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DesenBoyalari_Desenler_DesenId",
                        column: x => x.DesenId,
                        principalTable: "Desenler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Siparisler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    DesenId = table.Column<int>(type: "int", nullable: false),
                    KumasId = table.Column<int>(type: "int", nullable: false),
                    MakineId = table.Column<int>(type: "int", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: true),
                    BaskiFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SiparisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparisler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Siparisler_Desenler_DesenId",
                        column: x => x.DesenId,
                        principalTable: "Desenler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Siparisler_Kumascinsleri_KumasId",
                        column: x => x.KumasId,
                        principalTable: "Kumascinsleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Siparisler_Makineler_MakineId",
                        column: x => x.MakineId,
                        principalTable: "Makineler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Siparisler_Musteriler_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DesenBoyalari_BoyaId",
                table: "DesenBoyalari",
                column: "BoyaId");

            migrationBuilder.CreateIndex(
                name: "IX_DesenBoyalari_DesenId",
                table: "DesenBoyalari",
                column: "DesenId");

            migrationBuilder.CreateIndex(
                name: "IX_Desenler_MusteriId",
                table: "Desenler",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_Siparisler_DesenId",
                table: "Siparisler",
                column: "DesenId");

            migrationBuilder.CreateIndex(
                name: "IX_Siparisler_KumasId",
                table: "Siparisler",
                column: "KumasId");

            migrationBuilder.CreateIndex(
                name: "IX_Siparisler_MakineId",
                table: "Siparisler",
                column: "MakineId");

            migrationBuilder.CreateIndex(
                name: "IX_Siparisler_MusteriId",
                table: "Siparisler",
                column: "MusteriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DesenBoyalari");

            migrationBuilder.DropTable(
                name: "Siparisler");

            migrationBuilder.DropTable(
                name: "Boyalar");

            migrationBuilder.DropTable(
                name: "Desenler");

            migrationBuilder.DropTable(
                name: "Kumascinsleri");

            migrationBuilder.DropTable(
                name: "Makineler");

            migrationBuilder.DropTable(
                name: "Musteriler");
        }
    }
}
