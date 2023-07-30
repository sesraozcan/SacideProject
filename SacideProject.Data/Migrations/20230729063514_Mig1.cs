using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacideProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class Mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Terapiler",
                columns: table => new
                {
                    TerapiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerapiAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerapiSayisi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terapiler", x => x.TerapiID);
                });

            migrationBuilder.CreateTable(
                name: "Danismanlar",
                columns: table => new
                {
                    DanismanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DanismanAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DanismanSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerapiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Danismanlar", x => x.DanismanID);
                    table.ForeignKey(
                        name: "FK_Danismanlar_Terapiler_TerapiID",
                        column: x => x.TerapiID,
                        principalTable: "Terapiler",
                        principalColumn: "TerapiID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Danismanlar_TerapiID",
                table: "Danismanlar",
                column: "TerapiID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Danismanlar");

            migrationBuilder.DropTable(
                name: "Terapiler");
        }
    }
}
