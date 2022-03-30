using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GcApp.Migrations
{
    public partial class iDmodelo_toModeloObject_caminhao7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caminhao_ModeloVeiculo_IdModeloVeiculo",
                table: "Caminhao");

            migrationBuilder.RenameColumn(
                name: "IdModeloVeiculo",
                table: "Caminhao",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "DetalhesTecnicos",
                table: "Caminhao",
                newName: "Detalhes Ténicos");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Caminhao",
                newName: "Descrição");

            migrationBuilder.RenameColumn(
                name: "AnoModelo",
                table: "Caminhao",
                newName: "Ano Modelo");

            migrationBuilder.RenameColumn(
                name: "AnoFabricacao",
                table: "Caminhao",
                newName: "Ano Fafricação");

            migrationBuilder.RenameIndex(
                name: "IX_Caminhao_IdModeloVeiculo",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caminhao_ModeloVeiculo_Modelo",
                table: "Caminhao");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "Caminhao",
                newName: "IdModeloVeiculo");

            migrationBuilder.RenameColumn(
                name: "Detalhes Ténicos",
                table: "Caminhao",
                newName: "DetalhesTecnicos");

            migrationBuilder.RenameColumn(
                name: "Descrição",
                table: "Caminhao",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "Ano Modelo",
                table: "Caminhao",
                newName: "AnoModelo");

            migrationBuilder.RenameColumn(
                name: "Ano Fafricação",
                table: "Caminhao",
                newName: "AnoFabricacao");

            migrationBuilder.RenameIndex(
                name: "IX_Caminhao_Modelo",
                table: "Caminhao",
                newName: "IX_Caminhao_IdModeloVeiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_Caminhao_ModeloVeiculo_IdModeloVeiculo",
                table: "Caminhao",
                column: "IdModeloVeiculo",
                principalTable: "ModeloVeiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
