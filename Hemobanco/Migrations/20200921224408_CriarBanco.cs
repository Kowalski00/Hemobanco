using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hemobanco.Migrations
{
    public partial class CriarBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doadores",
                columns: table => new
                {
                    DoadorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    CPF = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Idade = table.Column<int>(nullable: false),
                    Endereco = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doadores", x => x.DoadorId);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    FuncId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.FuncId);
                });

            migrationBuilder.CreateTable(
                name: "Sangues",
                columns: table => new
                {
                    SangueId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SangueTipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sangues", x => x.SangueId);
                });

            migrationBuilder.CreateTable(
                name: "Doacoes",
                columns: table => new
                {
                    DoacaoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    doacaoDoadorId = table.Column<int>(nullable: true),
                    QtdSangue = table.Column<double>(nullable: false),
                    SangueId = table.Column<int>(nullable: true),
                    RealizadoEm = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doacoes", x => x.DoacaoId);
                    table.ForeignKey(
                        name: "FK_Doacoes_Sangues_SangueId",
                        column: x => x.SangueId,
                        principalTable: "Sangues",
                        principalColumn: "SangueId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doacoes_Doadores_doacaoDoadorId",
                        column: x => x.doacaoDoadorId,
                        principalTable: "Doadores",
                        principalColumn: "DoadorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estoques",
                columns: table => new
                {
                    EstoqueId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SangueId = table.Column<int>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false),
                    FuncId = table.Column<int>(nullable: true),
                    ArmazenadoEm = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoques", x => x.EstoqueId);
                    table.ForeignKey(
                        name: "FK_Estoques_Funcionarios_FuncId",
                        column: x => x.FuncId,
                        principalTable: "Funcionarios",
                        principalColumn: "FuncId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estoques_Sangues_SangueId",
                        column: x => x.SangueId,
                        principalTable: "Sangues",
                        principalColumn: "SangueId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    ReservaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SangueId = table.Column<int>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false),
                    FuncId = table.Column<int>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.ReservaId);
                    table.ForeignKey(
                        name: "FK_Reservas_Funcionarios_FuncId",
                        column: x => x.FuncId,
                        principalTable: "Funcionarios",
                        principalColumn: "FuncId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservas_Sangues_SangueId",
                        column: x => x.SangueId,
                        principalTable: "Sangues",
                        principalColumn: "SangueId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doacoes_SangueId",
                table: "Doacoes",
                column: "SangueId");

            migrationBuilder.CreateIndex(
                name: "IX_Doacoes_doacaoDoadorId",
                table: "Doacoes",
                column: "doacaoDoadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Estoques_FuncId",
                table: "Estoques",
                column: "FuncId");

            migrationBuilder.CreateIndex(
                name: "IX_Estoques_SangueId",
                table: "Estoques",
                column: "SangueId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_FuncId",
                table: "Reservas",
                column: "FuncId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_SangueId",
                table: "Reservas",
                column: "SangueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doacoes");

            migrationBuilder.DropTable(
                name: "Estoques");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Doadores");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Sangues");
        }
    }
}
