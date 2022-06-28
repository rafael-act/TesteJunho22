using Microsoft.EntityFrameworkCore.Migrations;

namespace RevendaVeiculos.Repositorio.Migrations
{
    public partial class EdicaoBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proprietarios_Endereços_EnderecoId",
                table: "Proprietarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endereços",
                table: "Endereços");

            migrationBuilder.RenameTable(
                name: "Endereços",
                newName: "Enderecos");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Marcas",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "Enderecos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Proprietarios_Enderecos_EnderecoId",
                table: "Proprietarios",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proprietarios_Enderecos_EnderecoId",
                table: "Proprietarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Enderecos");

            migrationBuilder.RenameTable(
                name: "Enderecos",
                newName: "Endereços");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Marcas",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endereços",
                table: "Endereços",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Proprietarios_Endereços_EnderecoId",
                table: "Proprietarios",
                column: "EnderecoId",
                principalTable: "Endereços",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
