using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PixelPlus.DAL.Migrations
{
    public partial class ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fatura",
                columns: table => new
                {
                    FaturaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaturaTutar = table.Column<int>(type: "int", nullable: false),
                    FaturaTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FaturaDurumu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fatura", x => x.FaturaId);
                });

            migrationBuilder.CreateTable(
                name: "Abone",
                columns: table => new
                {
                    AboneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Depozito = table.Column<int>(type: "int", nullable: false),
                    AboneBakiye = table.Column<int>(type: "int", nullable: false),
                    AbonelikDurumu = table.Column<bool>(type: "bit", nullable: false),
                    FaturaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abone", x => x.AboneId);
                    table.ForeignKey(
                        name: "FK_Abone_Fatura_FaturaId",
                        column: x => x.FaturaId,
                        principalTable: "Fatura",
                        principalColumn: "FaturaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abone_FaturaId",
                table: "Abone",
                column: "FaturaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abone");

            migrationBuilder.DropTable(
                name: "Fatura");
        }
    }
}
