using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GcApp.Migrations
{
    public partial class iDmodelo_toModeloObject_caminhao6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModeloVeiculo_Caminhao_CaminhaoId",
                table: "ModeloVeiculo");

            migrationBuilder.DropIndex(
                name: "IX_ModeloVeiculo_CaminhaoId",
                table: "ModeloVeiculo");

            migrationBuilder.DropColumn(
                name: "CaminhaoId",
                table: "ModeloVeiculo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CaminhaoId",
                table: "ModeloVeiculo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ModeloVeiculo_CaminhaoId",
                table: "ModeloVeiculo",
                column: "CaminhaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ModeloVeiculo_Caminhao_CaminhaoId",
                table: "ModeloVeiculo",
                column: "CaminhaoId",
                principalTable: "Caminhao",
                principalColumn: "Id");
        }
    }
}
