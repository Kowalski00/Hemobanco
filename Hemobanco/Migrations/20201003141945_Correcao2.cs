using Microsoft.EntityFrameworkCore.Migrations;

namespace Hemobanco.Migrations
{
    public partial class Correcao2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Quantidade",
                table: "Estoques",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Quantidade",
                table: "Estoques",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
