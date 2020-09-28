using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hemobanco.Migrations
{
    public partial class Correcao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doacoes_Doadores_doacaoDoadorId",
                table: "Doacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Estoques_Funcionarios_FuncId",
                table: "Estoques");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Funcionarios_FuncId",
                table: "Reservas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcionarios",
                table: "Funcionarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doadores",
                table: "Doadores");

            migrationBuilder.DropIndex(
                name: "IX_Doacoes_doacaoDoadorId",
                table: "Doacoes");

            migrationBuilder.DropColumn(
                name: "FuncId",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "DoadorId",
                table: "Doadores");

            migrationBuilder.DropColumn(
                name: "doacaoDoadorId",
                table: "Doacoes");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Funcionarios",
                newName: "CPF");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Funcionarios",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CriadoEm",
                table: "Funcionarios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Doadores",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CriadoEm",
                table: "Doadores",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DoadorId",
                table: "Doacoes",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcionarios",
                table: "Funcionarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doadores",
                table: "Doadores",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Doacoes_DoadorId",
                table: "Doacoes",
                column: "DoadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doacoes_Doadores_DoadorId",
                table: "Doacoes",
                column: "DoadorId",
                principalTable: "Doadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estoques_Funcionarios_FuncId",
                table: "Estoques",
                column: "FuncId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Funcionarios_FuncId",
                table: "Reservas",
                column: "FuncId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doacoes_Doadores_DoadorId",
                table: "Doacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Estoques_Funcionarios_FuncId",
                table: "Estoques");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Funcionarios_FuncId",
                table: "Reservas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcionarios",
                table: "Funcionarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doadores",
                table: "Doadores");

            migrationBuilder.DropIndex(
                name: "IX_Doacoes_DoadorId",
                table: "Doacoes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "CriadoEm",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Doadores");

            migrationBuilder.DropColumn(
                name: "CriadoEm",
                table: "Doadores");

            migrationBuilder.DropColumn(
                name: "DoadorId",
                table: "Doacoes");

            migrationBuilder.RenameColumn(
                name: "CPF",
                table: "Funcionarios",
                newName: "Cpf");

            migrationBuilder.AddColumn<int>(
                name: "FuncId",
                table: "Funcionarios",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "DoadorId",
                table: "Doadores",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "doacaoDoadorId",
                table: "Doacoes",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcionarios",
                table: "Funcionarios",
                column: "FuncId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doadores",
                table: "Doadores",
                column: "DoadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Doacoes_doacaoDoadorId",
                table: "Doacoes",
                column: "doacaoDoadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doacoes_Doadores_doacaoDoadorId",
                table: "Doacoes",
                column: "doacaoDoadorId",
                principalTable: "Doadores",
                principalColumn: "DoadorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estoques_Funcionarios_FuncId",
                table: "Estoques",
                column: "FuncId",
                principalTable: "Funcionarios",
                principalColumn: "FuncId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Funcionarios_FuncId",
                table: "Reservas",
                column: "FuncId",
                principalTable: "Funcionarios",
                principalColumn: "FuncId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
