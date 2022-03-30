using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GcApp.Migrations
{
    public partial class iDmodelo_toModeloObject_caminhao8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caminhao_ModeloVeiculo_Modelo",
                table: "Caminhao");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "Caminhao",
                newName: "IdModelo");

            migrationBuilder.RenameIndex(
                name: "IX_Caminhao_Modelo",
                table: "Caminhao",
                newName: "IX_Caminhao_IdModelo");

            migrationBuilder.AddForeignKey(
                name: "FK_Caminhao_ModeloVeiculo_IdModelo",
                table: "Caminhao",
                column: "IdModelo",
                principalTable: "ModeloVeiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caminhao_ModeloVeiculo_IdModelo",
                table: "Caminhao");

            migrationBuilder.RenameColumn(
                name: "IdModelo",
                table: "Caminhao",
                newName: "Modelo");

            migrationBuilder.RenameIndex(
                name: "IX_Caminhao_IdModelo",
                table: "Caminhao",
                newName: "IX_Caminhao_Modelo");

            migrationBuilder.AddForeignKey(
                name: "FK_Caminhao_ModeloVeiculo_Modelo",
                table: "Caminhao",
                column: "Modelo",
                principalTable: "ModeloVeiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
