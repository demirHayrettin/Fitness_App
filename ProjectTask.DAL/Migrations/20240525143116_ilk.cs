using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectTask.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ilk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Boy = table.Column<double>(type: "float", nullable: false),
                    Kilo = table.Column<double>(type: "float", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ogunler",
                columns: table => new
                {
                    OgunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogunler", x => x.OgunId);
                });

            migrationBuilder.CreateTable(
                name: "Porsiyonlar",
                columns: table => new
                {
                    PorsiyonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Miktar = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Porsiyonlar", x => x.PorsiyonId);
                });

            migrationBuilder.CreateTable(
                name: "Yemek Kategorileri",
                columns: table => new
                {
                    YemekKategoriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yemek Kategorileri", x => x.YemekKategoriId);
                });

            migrationBuilder.CreateTable(
                name: "YemekPlanlari",
                columns: table => new
                {
                    YemekPlaniId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekPlanlari", x => x.YemekPlaniId);
                    table.ForeignKey(
                        name: "FK_YemekPlanlari_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yemekler",
                columns: table => new
                {
                    YemekId = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tarif = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResimYolu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yemekler", x => x.YemekId);
                    table.ForeignKey(
                        name: "FK_Yemekler_Porsiyonlar_YemekId",
                        column: x => x.YemekId,
                        principalTable: "Porsiyonlar",
                        principalColumn: "PorsiyonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yemekler_Yemek Kategorileri_YemekId",
                        column: x => x.YemekId,
                        principalTable: "Yemek Kategorileri",
                        principalColumn: "YemekKategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Besinler",
                columns: table => new
                {
                    BesinId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Kalori = table.Column<double>(type: "float", nullable: false),
                    YemekId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Besinler", x => x.BesinId);
                    table.ForeignKey(
                        name: "FK_Besinler_Yemekler_YemekId",
                        column: x => x.YemekId,
                        principalTable: "Yemekler",
                        principalColumn: "YemekId");
                });

            migrationBuilder.CreateTable(
                name: "YemekPlaniOgesi",
                columns: table => new
                {
                    YemekPlaniOgesiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YemekId = table.Column<int>(type: "int", nullable: false),
                    OgunId = table.Column<int>(type: "int", nullable: false),
                    Saat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YemekPlaniId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekPlaniOgesi", x => x.YemekPlaniOgesiId);
                    table.ForeignKey(
                        name: "FK_YemekPlaniOgesi_Ogunler_OgunId",
                        column: x => x.OgunId,
                        principalTable: "Ogunler",
                        principalColumn: "OgunId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_YemekPlaniOgesi_YemekPlanlari_YemekPlaniId",
                        column: x => x.YemekPlaniId,
                        principalTable: "YemekPlanlari",
                        principalColumn: "YemekPlaniId");
                    table.ForeignKey(
                        name: "FK_YemekPlaniOgesi_Yemekler_YemekId",
                        column: x => x.YemekId,
                        principalTable: "Yemekler",
                        principalColumn: "YemekId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Besinler_YemekId",
                table: "Besinler",
                column: "YemekId");

            migrationBuilder.CreateIndex(
                name: "IX_YemekPlaniOgesi_OgunId",
                table: "YemekPlaniOgesi",
                column: "OgunId");

            migrationBuilder.CreateIndex(
                name: "IX_YemekPlaniOgesi_YemekId",
                table: "YemekPlaniOgesi",
                column: "YemekId");

            migrationBuilder.CreateIndex(
                name: "IX_YemekPlaniOgesi_YemekPlaniId",
                table: "YemekPlaniOgesi",
                column: "YemekPlaniId");

            migrationBuilder.CreateIndex(
                name: "IX_YemekPlanlari_KullaniciId",
                table: "YemekPlanlari",
                column: "KullaniciId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Besinler");

            migrationBuilder.DropTable(
                name: "YemekPlaniOgesi");

            migrationBuilder.DropTable(
                name: "Ogunler");

            migrationBuilder.DropTable(
                name: "YemekPlanlari");

            migrationBuilder.DropTable(
                name: "Yemekler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Porsiyonlar");

            migrationBuilder.DropTable(
                name: "Yemek Kategorileri");
        }
    }
}
