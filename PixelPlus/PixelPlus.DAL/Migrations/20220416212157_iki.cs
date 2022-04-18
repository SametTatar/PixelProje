using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PixelPlus.DAL.Migrations
{
    public partial class iki : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abone_Fatura_FaturaId",
                table: "Abone");

            migrationBuilder.DropIndex(
                name: "IX_Abone_FaturaId",
                table: "Abone");

            migrationBuilder.DropColumn(
                name: "FaturaId",
                table: "Abone");

            migrationBuilder.AddColumn<int>(
                name: "AboneId",
                table: "Fatura",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Fatura_AboneId",
                table: "Fatura",
                column: "AboneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fatura_Abone_AboneId",
                table: "Fatura",
                column: "AboneId",
                principalTable: "Abone",
                principalColumn: "AboneId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fatura_Abone_AboneId",
                table: "Fatura");

            migrationBuilder.DropIndex(
                name: "IX_Fatura_AboneId",
                table: "Fatura");

            migrationBuilder.DropColumn(
                name: "AboneId",
                table: "Fatura");

            migrationBuilder.AddColumn<int>(
                name: "FaturaId",
                table: "Abone",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Abone_FaturaId",
                table: "Abone",
                column: "FaturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Abone_Fatura_FaturaId",
                table: "Abone",
                column: "FaturaId",
                principalTable: "Fatura",
                principalColumn: "FaturaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
