using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GcApp.Migrations
{
    public partial class iDmodelo_toModeloObject_caminhao5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Caminhao_IdModeloVeiculo",
                table: "Caminhao");

            migrationBuilder.CreateIndex(
                name: "IX_Caminhao_IdModeloVeiculo",
                table: "Caminhao",
                column: "IdModeloVeiculo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Caminhao_IdModeloVeiculo",
                table: "Caminhao");

            migrationBuilder.CreateIndex(
                name: "IX_Caminhao_IdModeloVeiculo",
                table: "Caminhao",
                column: "IdModeloVeiculo",
                unique: true);
        }
    }
}
