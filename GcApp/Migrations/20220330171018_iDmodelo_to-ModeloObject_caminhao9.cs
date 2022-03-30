using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GcApp.Migrations
{
    public partial class iDmodelo_toModeloObject_caminhao9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caminhao_ModeloVeiculo_IdModelo",
                table: "Caminhao");

            migrationBuilder.RenameColumn(
                name: "IdModelo",
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
                name: "IX_Caminhao_IdModelo",
                table: "Caminhao",
                newName: "IX_Caminhao_IdModeloVeiculo");

            migrationBuilder.AlterColumn<string>(
                name: "DetalhesTecnicos",
                table: "Caminhao",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Caminhao",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Caminhao_ModeloVeiculo_IdModeloVeiculo",
                table: "Caminhao",
                column: "IdModeloVeiculo",
                principalTable: "ModeloVeiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caminhao_ModeloVeiculo_IdModeloVeiculo",
                table: "Caminhao");

            migrationBuilder.RenameColumn(
                name: "IdModeloVeiculo",
                table: "Caminhao",
                newName: "IdModelo");

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
                newName: "IX_Caminhao_IdModelo");

            migrationBuilder.AlterColumn<string>(
                name: "Detalhes Ténicos",
                table: "Caminhao",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descrição",
                table: "Caminhao",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Caminhao_ModeloVeiculo_IdModelo",
                table: "Caminhao",
                column: "IdModelo",
                principalTable: "ModeloVeiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
