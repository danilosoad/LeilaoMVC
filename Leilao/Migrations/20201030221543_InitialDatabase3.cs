using Microsoft.EntityFrameworkCore.Migrations;

namespace Leilao.Migrations
{
    public partial class InitialDatabase3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Pessoas_UlTIMAPESSOAID",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "UlTIMAPESSOAID",
                table: "Produtos",
                newName: "ULTIMAPESSOAID");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_UlTIMAPESSOAID",
                table: "Produtos",
                newName: "IX_Produtos_ULTIMAPESSOAID");

            migrationBuilder.AlterColumn<int>(
                name: "ULTIMAPESSOAID",
                table: "Produtos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ULTIMAPESSOANOME",
                table: "Produtos",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Pessoas_ULTIMAPESSOAID",
                table: "Produtos",
                column: "ULTIMAPESSOAID",
                principalTable: "Pessoas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Pessoas_ULTIMAPESSOAID",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "ULTIMAPESSOANOME",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "ULTIMAPESSOAID",
                table: "Produtos",
                newName: "UlTIMAPESSOAID");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_ULTIMAPESSOAID",
                table: "Produtos",
                newName: "IX_Produtos_UlTIMAPESSOAID");

            migrationBuilder.AlterColumn<int>(
                name: "UlTIMAPESSOAID",
                table: "Produtos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Pessoas_UlTIMAPESSOAID",
                table: "Produtos",
                column: "UlTIMAPESSOAID",
                principalTable: "Pessoas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
