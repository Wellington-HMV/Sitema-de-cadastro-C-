using Microsoft.EntityFrameworkCore.Migrations;

namespace sistema.Migrations
{
    public partial class teste02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cliente_ClienteId",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_ClienteId",
                table: "Pedido");

            migrationBuilder.AlterColumn<string>(
                name: "ClienteId",
                table: "Pedido",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ClienteId1",
                table: "Pedido",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ClienteId1",
                table: "Pedido",
                column: "ClienteId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cliente_ClienteId1",
                table: "Pedido",
                column: "ClienteId1",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cliente_ClienteId1",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_ClienteId1",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "ClienteId1",
                table: "Pedido");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Pedido",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ClienteId",
                table: "Pedido",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cliente_ClienteId",
                table: "Pedido",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
