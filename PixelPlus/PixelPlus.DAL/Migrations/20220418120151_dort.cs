using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PixelPlus.DAL.Migrations
{
    public partial class dort : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FaturaaFaturaId",
                table: "Fatura",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fatura_FaturaaFaturaId",
                table: "Fatura",
                column: "FaturaaFaturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fatura_Fatura_FaturaaFaturaId",
                table: "Fatura",
                column: "FaturaaFaturaId",
                principalTable: "Fatura",
                principalColumn: "FaturaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fatura_Fatura_FaturaaFaturaId",
                table: "Fatura");

            migrationBuilder.DropIndex(
                name: "IX_Fatura_FaturaaFaturaId",
                table: "Fatura");

            migrationBuilder.DropColumn(
                name: "FaturaaFaturaId",
                table: "Fatura");
        }
    }
}
